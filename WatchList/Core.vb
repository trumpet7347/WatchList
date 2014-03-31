Imports System.IO
Imports System.Xml
Imports Awesomium.Core

Module Core



    Public Sub Test()

        Dim conf As WebConfig = New WebConfig()
        Dim pref As WebPreferences = New WebPreferences
        pref.LoadImagesAutomatically = False
        pref.RemoteFonts = False
        pref.WebAudio = False
        Dim session As WebSession = WebCore.CreateWebSession(pref)

        WebCore.Initialize(conf)

        Dim webView As WebView = WebCore.CreateWebView(800, 600)




        'webView.WebSession.Preferences.LoadImagesAutomatically = False


        webView.Source = New Uri("https://login.eveonline.com/Account/LogOn")


        Do Until webView.IsDocumentReady And webView.IsLoading = False
            WebCore.Update()
        Loop




        'webView.ExecuteJavascript("$('#UserName').val('test'); $('#Password').val('test'); $('#submitButton').trigger('click');")
        Debug.Print(webView.ExecuteJavascriptWithResult("$('#UserName').val('test'); $('#Password').val('test'); $('#submitButton').trigger('click');$('#submitButton')"))
        Debug.Print(webView.GetLastError)
        Dim surface As BitmapSurface = CType(webView.Surface, BitmapSurface)
        surface.SaveToPNG("result.png", True)

        Do Until webView.IsDocumentReady And webView.IsLoading = False
            WebCore.Update()
        Loop

        surface = CType(webView.Surface, BitmapSurface)
        surface.SaveToPNG("result-after.png", True)


        'WebCore.Shutdown()
    End Sub

    Public Function aTest()
        Try
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            Dim attr As XmlNode
            'Create the XML Document
            m_xmld = New XmlDocument()
            'Load the Xml file
            m_xmld.Load("http://api.eveonline.com/eve/CharacterID.xml.aspx?names=EveryoneVersusEveryone.com")

            'Debug.Print(m_xmld.InnerXml)

            For Each XmlNode As XmlNode In m_xmld.ChildNodes
                ' Debug.Print(XmlNode.InnerXml)
            Next

            'Get the list of name nodes 
            m_nodelist = m_xmld.SelectNodes("/eveapi/result/rowset/row")
            'Loop through the nodes
            For Each m_node In m_nodelist

                Dim corpID, corpName As String

                corpID = m_node.Attributes.GetNamedItem("characterID").Value
                corpName = m_node.Attributes.GetNamedItem("name").Value

                Debug.Print(corpName & ":" & corpID)

            Next
        Catch errorVariable As Exception
            'Error trapping
            Console.Write(errorVariable.ToString())
        End Try

        Return True
    End Function


End Module
