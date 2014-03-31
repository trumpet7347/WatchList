Imports Awesomium.Core




Public Class EveGate


    Private webView As WebView
    Private Parent As WatchList
    Public CreatedLabelID As String = ""
    Public Sub New(ParentWatchList As WatchList)
        Me.Parent = ParentWatchList
        Dim pref As WebPreferences = New WebPreferences
        pref.LoadImagesAutomatically = True
        pref.RemoteFonts = False
        pref.WebAudio = False

        Dim session As WebSession = WebCore.CreateWebSession(pref)

        'Me.webView = WebCore.CreateWebView(1000, 900, session)


        Me.Parent.GetWebView().WebSession = WebCore.CreateWebSession(pref)

    End Sub

    Private Sub PauseUntilFinished()
        Do Until Me.Parent.GetWebView().IsDocumentReady And Me.Parent.GetWebView().IsLoading = False And Me.Parent.GetWebView().IsNavigating = False
            Application.DoEvents()
            Me.Parent.GetWebView().Update()
        Loop
        'MessageBox.Show("Review automation.")
    End Sub

    Public Function Login(username As String, password As String)

        Parent.ToolStripStatusLabel2.Text = "Please Wait, Logging in..."

        Me.Parent.GetWebView().Source = New Uri("https://login.eveonline.com/Account/LogOn")


        PauseUntilFinished()

        Debug.Print(Me.Parent.GetWebView().Title)

        Dim test = Me.Parent.GetWebView().ExecuteJavascriptWithResult("$('#UserName').val('" & username & "'); $('#Password').val('" & password & "'); ")
        Me.Parent.GetWebView().Update()
        Debug.Print(test)
        helperSS("result.png")

        test = Me.Parent.GetWebView().ExecuteJavascriptWithResult(helperClick("#submitButton")) '"$('#submitButton').trigger('click'); $('#submitButton').invoke('click');")
        Debug.Print(helperClick("#submitButton"))
        Me.Parent.GetWebView().Update()
        PauseUntilFinished()

        Me.Parent.GetWebView().Source = New Uri("https://gate.eveonline.com/Contacts")

        PauseUntilFinished()

        Debug.Print(Me.Parent.GetWebView().Title)

        'check if we're back at the same page!!
        If Me.Parent.GetWebView().Source.ToString = "https://login.eveonline.com/Account/LogOn" Then
            Parent.ToolStripStatusLabel2.Text = "Failed to login..."
            helperSS("result-after.png")
            Debug.Print(Me.Parent.GetWebView().Source.ToString)
            Return False
        End If


        Parent.ToolStripStatusLabel2.Text = "Logged in!"
        Debug.Print(Me.Parent.GetWebView().Source.ToString)

        Me.Parent.GetWebView().Update()
        helperSS("result-after.png")


        'check session

        Parent.ToolStripStatusLabel2.Text = "Logged in! Selecting Character..."
        Me.Parent.GetWebView().Source = New Uri("https://gate.eveonline.com/Contacts")

        PauseUntilFinished()

        helperSS("result-after-loggedin.png")

        Debug.Print(Me.Parent.GetWebView().Source.ToString) ''this should be https://gate.eveonline.com/Contacts
        If Me.Parent.GetWebView().Source.ToString = "https://gate.eveonline.com/LogOn/CharacterSelection" Then
            'we have to select a character, sadly.
            test = Me.Parent.GetWebView().ExecuteJavascriptWithResult(helperClick(".character-profile.active > a"))
            Me.Parent.GetWebView().Update()
            PauseUntilFinished()

            'lets see if we selected a character.
            helperSS("result-after-loggedin-selected.png")
            Debug.Print(Me.Parent.GetWebView().Source.ToString)

        End If


        Return True
    End Function

    Public Function AddContact(CharacterName As String)
        Dim navigated As Boolean = False
        Parent.ToolStripStatusLabel2.Text = "Adding contact " & CharacterName
        Me.Parent.GetWebView().Source = New Uri("https://gate.eveonline.com/Profile/" & CharacterName) ' System.Web.HttpUtility.UrlEncode(CharacterName)
        Debug.Print("https://gate.eveonline.com/Profile/" & CharacterName)
        Me.Parent.GetWebView().Update()
        PauseUntilFinished()


        Dim test = Me.Parent.GetWebView().ExecuteJavascriptWithResult(helperClick("#addContact") & "document.getElementById('addContactPopUp').setAttribute('style', ''); " & helperClick("#divStanding0 img") & helperClick("#addToWatchlist") & helperClick("#addContactButton img"))
        Do Until Me.Parent.GetWebView().IsDocumentReady And Me.Parent.GetWebView().IsLoading = False And Me.Parent.GetWebView().IsNavigating = False
            navigated = True
            Application.DoEvents()
            Me.Parent.GetWebView().Update()
        Loop

        'Debug.Print(helperClick("#addContact") & "document.getElementById('addContactPopUp').setAttribute('style', ''); " & helperClick("#divStanding0 img") & helperClick("#addToWatchlist") & helperClick("#addContactButton img"))
        Me.Parent.GetWebView().Update()

        helperSS("contact-ADDING.png")


        'Debug.Print(Me.Parent.GetWebView().Source.ToString)
        Parent.ToolStripStatusLabel2.Text = "Added contact " & CharacterName
        Return navigated

    End Function

    Public Function ApplyLabelToNeutrals(label As String) As Boolean

        If Me.CreatedLabelID = "" Then
            Dim newID = CreateLabel(label)
            If newID <> "" And newID <> vbNullString Then
                Me.CreatedLabelID = newID
            End If
        End If

        If Me.CreatedLabelID = "" Then
            Return False
        End If

        PauseUntilFinished()
        Me.Parent.GetWebView().Source = New Uri("https://gate.eveonline.com/Contacts/Index/Neutral")
        PauseUntilFinished()

        Me.Parent.GetWebView().ExecuteJavascript("" & _
            helperClick("#checkBoxCheckAll") & _
            helperClick("#checkBoxCheckAll") & _
            "document.getElementById('toggleContainerContentLabels').setAttribute('style', 'display: block; left: 163px; top: 48px;');" & _
            "document.getElementById('chkLabel" & Me.CreatedLabelID & "').setAttribute('checked', 'checked');" & _
            "input[id=chkLabel" & Me.CreatedLabelID & "].click();" & _
            "document.getElementById('labelApply').setAttribute('style', 'display: inline;');")

        'MessageBox.Show("Checked off Label?")

        Me.Parent.GetWebView().ExecuteJavascript(helperClick("#labelApply"))

        Me.Parent.GetWebView().Update()
        helperSS("movedlabel.png")
        PauseUntilFinished()

        'set them to red!
        Me.Parent.GetWebView().Source = New Uri("https://gate.eveonline.com/Contacts/Index/Neutral")
        PauseUntilFinished()
        Me.Parent.GetWebView().ExecuteJavascript("" & _
           helperClick("#checkBoxCheckAll") & _
           helperClick("#checkBoxCheckAll") & _
           helperClick("#editMultipleContactsButtonTop") & _
           helperClick("#divStandingM10"))
        Me.Parent.GetWebView().Update()
        helperSS("settingstandingafterlabel.png")

        Me.Parent.GetWebView().ExecuteJavascript(helperClick("#editContactButton"))
        Me.Parent.GetWebView().Update()
        PauseUntilFinished()
        helperSS("settingstandingafterlabelsubmitted.png")

        Return True

    End Function

    Private Function CreateLabel(label As String) As String
        Me.Parent.GetWebView().Source = New Uri("https://gate.eveonline.com/Contacts")
        PauseUntilFinished()
        Me.Parent.GetWebView().ExecuteJavascript("" & _
            "document.getElementById('toggleContainerContentLabels').setAttribute('style', 'display: block; left: 163px; top: 48px;'); " & _
            "document.getElementById('labelFilterField').value = '" & label & "';" & _
            helperClick("#labelCreateNew"))

        Me.Parent.GetWebView().Update()
        helperSS("createdlabel.png")
        PauseUntilFinished()
        Me.Parent.GetWebView().Source = New Uri("https://gate.eveonline.com/Contacts")
        PauseUntilFinished()
        Dim result As Awesomium.Core.JSValue
        result = Me.Parent.GetWebView().ExecuteJavascriptWithResult("var LabelID = 0; $('.labelListContainer').each( function(){ var id = $(this).attr('id'); var text = $(this).find('a > span').text();  if(text.split(' (')[0] == '" & label & "') LabelID = id;  } ) ; LabelID.replace(/[a-z]+/, '');")
        Debug.Print(result.ToString)
        Return result.ToString()

    End Function


    Private Function helperClick(elementpath As String, Optional useAdvanced As Boolean = False)

        If Not useAdvanced Then
            'Return "try{$('" & elementpath & "').trigger('click').invoke('click').click();}catch(e){};"
            Return "try{$('" & elementpath & "').click();}catch(e){$('" & elementpath & "').trigger('click').invoke('click');}; "
        Else
            Return "$('" & elementpath & "').trigger('click').invoke('click'); "
        End If


        Dim js As String = "function clickEvent(obj){    " & _
                                "var fireOnThis = obj;" & _
                                "if( document.createEvent ) {" & _
                                "  var evObj = document.createEvent('MouseEvents');" & _
                                "  evObj.initEvent( 'click', true, false );" & _
                                "  fireOnThis.dispatchEvent(evObj);" & _
                                "} else if( document.createEventObject ) {" & _
                                "  fireOnThis.fireEvent('onclick');" & _
                                "}" & _
                            "}"

        Return js & "; clickEvent($('" & elementpath & "'));" '"$('" & elementpath & "').click(); " '.trigger('click').invoke('click'); "
    End Function

    Private Sub helperSS(name As String)
        Exit Sub
        Try
            Dim surface As BitmapSurface = CType(Me.Parent.GetWebView().Surface, BitmapSurface)
            surface.SaveToPNG(name, True)
        Catch ex As NullReferenceException
            Debug.Print("Cant take screen shot. No Surface to capture.")
        End Try
    End Sub

End Class
