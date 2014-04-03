Public Class WatchList

    Public CurrentEntity As EveEntity
    Private EveGateHandler As EveGate
    Private ContactLabel As String
    Private CancellingOperation As Boolean


    Public Function GetWebView() As Awesomium.Windows.Forms.WebControl
        Return Me.WebControl1
    End Function

    Private Sub WatchList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Test()
        Me.Text = Me.Text & " " & Application.ProductVersion
        EveGateHandler = New EveGate(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonLookup.Click

        lblContactLabel.Text = "Contact Label: " & Me.ContactLabel
        txtUpdateLabel.Visible = False
        btnUpdateLabel.Visible = False

        ToolStripStatusLabel1.Text = "Looking up entity..."
        Me.ButtonLookup.Enabled = False
        If ComboType.GetItemText(ComboType.SelectedItem) = "Corporation" Then
            CurrentEntity = New EveEntity(EveEntity.EntityType.Corporation, TextEntityName.Text)
        Else
            CurrentEntity = New EveEntity(EveEntity.EntityType.Alliance, TextEntityName.Text)
        End If

        If CurrentEntity.ApiID <> "" Then
            ToolStripStatusLabel1.Text = CurrentEntity.Name & "(" & CurrentEntity.ApiID & ")"
            Me.ContactLabel = CurrentEntity.Name
            lblContactLabel.Text = "Contact Label: " & Me.ContactLabel
            EveGateHandler.CreatedLabelID = ""
            PopulateMembers()
        Else
            ToolStripStatusLabel1.Text = "Can't find " & CurrentEntity.Name
            Me.ContactLabel = ""
            EveGateHandler.CreatedLabelID = ""
            lblContactLabel.Text = "Contact Label: " & Me.ContactLabel
        End If


        Me.ButtonLookup.Enabled = True


    End Sub


    Private Sub PopulateMembers()


        Try
            lblCharactersCount.Text = "0 characters in list"
            MembersList.Items.Clear()

            For Each Member As Object In CurrentEntity.Members
                MembersList.Items.Add(Member("name"))
            Next

            lblCharactersCount.Text = MembersList.Items.Count & " characters in list"



        Catch e As InvalidCastException
            ToolStripStatusLabel1.Text = "There was no members found..."

        Catch errorVariable As Exception
            'Error trapping
            Console.Write(errorVariable.ToString())
            'ToolStripStatusLabel1.Text = errorVariable.ToString()
        End Try

    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Test()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        'TabControl1.SelectTab(2)
        If EveGateHandler.Login(TextUser.Text, TextPass.Text) Then
            TabControl1.SelectTab(1)
        End If
        Button1.Enabled = True
    End Sub

    Private Sub MembersList_DoubleClick(sender As Object, e As EventArgs) Handles MembersList.DoubleClick
        'TabControl1.SelectTab(2)

        lblContactLabel.Text = "Contact Label: " & Me.ContactLabel
        txtUpdateLabel.Visible = False
        btnUpdateLabel.Visible = False


        EveGateHandler.CreatedLabelID = ""
        Debug.Print(MembersList.SelectedItems.Item(0).Text)
        EveGateHandler.AddContact(MembersList.SelectedItems.Item(0).Text)
        EveGateHandler.ApplyLabelToNeutrals(Me.ContactLabel)
        MembersList.Items.Item(MembersList.SelectedItems.Item(0).Index).ImageIndex = 0
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddAll.Click

        lblContactLabel.Text = "Contact Label: " & Me.ContactLabel
        txtUpdateLabel.Visible = False
        btnUpdateLabel.Visible = False

        CancellingOperation = False
        btnAddAll.Enabled = False
        btnCancel.Enabled = True
        EveGateHandler.CreatedLabelID = ""
        Dim member As ListViewItem, i As Integer = 0
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = MembersList.Items.Count
        For Each member In MembersList.Items()
            Application.DoEvents()
            If CancellingOperation Then
                GoTo cancel
                Exit For
            End If

            If EveGateHandler.AddContact(member.Text, chkCharCorpValidate.Checked) Then
                i = i + 1
                MembersList.Items.Item(member.Index).ImageIndex = 0
            Else
                MembersList.Items.Item(member.Index).ImageIndex = 1
            End If

            If i >= 10 Then
                i = 0
                EveGateHandler.ApplyLabelToNeutrals(Me.ContactLabel)
            End If
            ToolStripProgressBar1.Value = ToolStripProgressBar1.Value + 1
        Next

        If i <> 0 Then EveGateHandler.ApplyLabelToNeutrals(Me.ContactLabel)
cancel:
        btnAddAll.Enabled = True
        btnCancel.Enabled = False
        CancellingOperation = False
        ToolStripProgressBar1.Value = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CancellingOperation = True
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub WebControl1_AddressChanged(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles WebControl1.AddressChanged
        Debug.Print("Changed to " & WebControl1.Source.ToString)
        If WebControl1.Source.ToString = "https://login.eveonline.com/" Then
            If MessageBox.Show("It seems you might have just logged in." & vbCrLf & "Select character now?", "Select Character", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                WebControl1.Source = New Uri("https://gate.eveonline.com/LogOn/CharacterSelection")
            Else
                TabControl1.SelectTab(2)
            End If
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub TextEntityName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEntityName.KeyPress

        If e.KeyChar.GetHashCode = 851981 Then
            ButtonLookup.PerformClick()
        End If

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        FormAbout.ShowDialog()
    End Sub

    Private Sub lblContactLabel_Click(sender As Object, e As EventArgs) Handles lblContactLabel.Click
        btnUpdateLabel.Visible = True
        txtUpdateLabel.Text = Me.ContactLabel
        txtUpdateLabel.Visible = True
        lblContactLabel.Text = "Contact Label:"
    End Sub



    Private Sub btnUpdateLabel_Click(sender As Object, e As EventArgs) Handles btnUpdateLabel.Click
        Dim newLabel As String = System.Text.RegularExpressions.Regex.Replace(Trim(txtUpdateLabel.Text), "[^a-zA-Z0-9 \.\-]", "")

        If newLabel.Length > 1 Then
            Me.ContactLabel = newLabel
            lblContactLabel.Text = "Contact Label: " & Me.ContactLabel
            txtUpdateLabel.Visible = False
            btnUpdateLabel.Visible = False
        End If
    End Sub

    Private Sub txtUpdateLabel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUpdateLabel.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            btnUpdateLabel.PerformClick()
        End If
    End Sub

End Class
