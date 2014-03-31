Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Xml
Imports System.Web.Script.Serialization

Public Class EveEntity

    Enum EntityType
        Corporation
        Alliance
    End Enum

    '{"character_id":"92407017","corporation_id":"98220779","alliance_id":"99003763","name":"Alexander VanStahl"}
    Protected Friend Members As Object

    Protected Friend ApiID As String
    Protected Friend Name As String
    Protected Friend Type As EntityType

    Private Const EVE_WHO_URL As String = "http://evewho.com/api.php"
    Private Const EVE_API_URL As String = "http://api.eveonline.com/eve/CharacterID.xml.aspx?names="
    Private Const EVE_API_ALLIANCE_URL As String = "https://api.eveonline.com/eve/AllianceList.xml.aspx?version=1"

    Public Sub New(type As EntityType, name As String)
        Me.Name = name
        Me.Type = type
        Me.ApiID = ""
        Me.Members = New Object

        If Me.Type = EntityType.Corporation Then
            If Me.GetCorpID() Then Me.GetMembers()
        Else
            If Me.GetAllianceID() Then Me.GetMembers()
        End If
    End Sub


    Private Function GetCorpID()
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode

            m_xmld = New XmlDocument()

            m_xmld.Load(EVE_API_URL & Me.Name) 'EveryoneVersusEveryone.com
            Debug.Print(EVE_API_URL & Me.Name)

            m_nodelist = m_xmld.SelectNodes("/eveapi/result/rowset/row")

            For Each m_node In m_nodelist

                Dim corpID, corpName As String

                corpID = m_node.Attributes.GetNamedItem("characterID").Value
                corpName = m_node.Attributes.GetNamedItem("name").Value

                Debug.Print(corpName & ":" & corpID)
                Me.Name = corpName
                Me.ApiID = corpID

            Next

            Return True

        Catch errorVariable As Exception
            'Error trapping
            Console.Write(errorVariable.ToString())
        End Try

        Return False

    End Function

    Private Function GetAllianceID()
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode

            m_xmld = New XmlDocument()

            m_xmld.Load(EVE_API_ALLIANCE_URL)

            m_nodelist = m_xmld.SelectNodes("/eveapi/result/rowset/row")

            For Each m_node In m_nodelist
                'EveryoneVersusEveryone.com.

                If Me.Name <> m_node.Attributes.GetNamedItem("name").Value Then Continue For
                Me.ApiID = m_node.Attributes.GetNamedItem("allianceID").Value
                Debug.Print(m_node.Attributes.GetNamedItem("name").Value & ":" & m_node.Attributes.GetNamedItem("allianceID").Value)
                Exit For

            Next

            If Me.ApiID <> "" Then Return True
            Return False

        Catch errorVariable As Exception
            'Error trapping
            Console.Write(errorVariable.ToString())
        End Try

        Return False

    End Function

    Private Sub GetMembers()

        Dim EveUrl As String = EVE_WHO_URL & "?type=" & IIf(Me.Type = EntityType.Corporation, "corplist", "allilist") & "&id=" & Me.ApiID

Tryagain:

        Try

      
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim json As String = client.DownloadString(EveUrl)


            Dim serializer As New JavaScriptSerializer()
            Dim serializedResult As Object = serializer.DeserializeObject(json)
            Debug.Print(serializedResult("characters").length)
            Me.Members = serializedResult("characters")



        Catch ex As System.Net.WebException

            If MessageBox.Show(ex.Message & vbCrLf & EveUrl & vbCrLf & "Try again?", "Error", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then GoTo Tryagain

            Console.WriteLine(ex.Message)
            Debug.Print(ex.Message)
        Catch ex As Exception

        End Try

    End Sub


End Class
