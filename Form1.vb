Imports System.Data.SqlClient

Public Class Form1
    Private Connection As SqlConnection

    ' Handles the form load event to initialize settings and UI elements
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.SaveConnection Then
            TextBoxServer.Text = My.Settings.ServerName
            TextBoxDB.Text = My.Settings.DatabaseName
            TextBoxUser.Text = My.Settings.Username
            TextBoxPassword.Text = My.Settings.Password
            CheckBoxWindows.Checked = My.Settings.UseWindowsAuth
            CheckBoxSaveSettings.Checked = True
        End If
        ButtonDisconnect.Enabled = False
        TabPage1.Text = "Connection"
        TabPage2.Text = "Item - Search"
        TabPage3.Text = "Digimon - Search"
        LinkLabel1.Text = "Shadoukita"
        LinkLabel1.Links.Clear()
        LinkLabel1.Links.Add(0, 12, "https://github.com/Shadoukita") ' (start, length, URL)
    End Sub

    ' Handles the connect button click
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        Dim connString As String

        If CheckBoxWindows.Checked Then
            connString = $"Server={TextBoxServer.Text};Database={TextBoxDB.Text};Trusted_Connection=True;"
        Else
            connString = $"Server={TextBoxServer.Text};Database={TextBoxDB.Text};User Id={TextBoxUser.Text};Password={TextBoxPassword.Text};"
        End If

        Try
            Connection = New SqlConnection(connString)
            Connection.Open()
            MessageBox.Show("successfully connected.", "SQL-Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ButtonConnect.Enabled = False
            ButtonDisconnect.Enabled = True
            TextBoxServer.Enabled = False
            TextBoxDB.Enabled = False
            TextBoxUser.Enabled = False
            TextBoxPassword.Enabled = False
            CheckBoxWindows.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If CheckBoxSaveSettings.Checked Then
            My.Settings.ServerName = TextBoxServer.Text
            My.Settings.DatabaseName = TextBoxDB.Text
            My.Settings.Username = TextBoxUser.Text
            My.Settings.Password = TextBoxPassword.Text
            My.Settings.UseWindowsAuth = CheckBoxWindows.Checked
            My.Settings.SaveConnection = True
            My.Settings.Save()
        Else
            My.Settings.ServerName = ""
            My.Settings.DatabaseName = ""
            My.Settings.Username = ""
            My.Settings.Password = ""
            My.Settings.UseWindowsAuth = False
            My.Settings.SaveConnection = False
            My.Settings.Save()
        End If

    End Sub

    ' Handles the disconnect button click
    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        If Connection IsNot Nothing AndAlso Connection.State = ConnectionState.Open Then
            Connection.Close()
            MessageBox.Show("Disconnected.", "SQL-Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ButtonConnect.Enabled = True
        ButtonDisconnect.Enabled = False

        TextBoxServer.Enabled = True
        TextBoxDB.Enabled = True
        TextBoxUser.Enabled = Not CheckBoxWindows.Checked
        TextBoxPassword.Enabled = Not CheckBoxWindows.Checked
        CheckBoxWindows.Enabled = True
    End Sub

    ' Handles the checkbox change for Windows Authentication
    Private Sub CheckBoxWindows_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWindows.CheckedChanged
        Dim isChecked = CheckBoxWindows.Checked
        TextBoxUser.Enabled = Not isChecked
        TextBoxPassword.Enabled = Not isChecked
    End Sub

    ' Searches for items by name in the database
    Private Function SearchItemsByName(itemName As String) As DataTable
        Dim dt As New DataTable()

        If Connection Is Nothing OrElse Connection.State <> ConnectionState.Open Then
            MessageBox.Show("no connection to the Database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return dt
        End If

        Try
            Dim query As String = "SELECT ItemId, Name FROM [DMOX].[Asset].[ItemInfo] WHERE [Name] LIKE @name"
            Using cmd As New SqlCommand(query, Connection)
                cmd.Parameters.AddWithValue("@name", "%" & itemName & "%")
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("search error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    ' Searches for Digimon by name in the database
    Private Function SearchDigimonByName(DigiName As String) As DataTable
        Dim dt As New DataTable()

        If Connection Is Nothing OrElse Connection.State <> ConnectionState.Open Then
            MessageBox.Show("no connection to the Database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return dt
        End If

        Try
            Dim query As String = "SELECT Type, Model, Name FROM [DMOX].[Asset].[DigimonBaseInfo] WHERE [Name] LIKE @name"
            Using cmd As New SqlCommand(query, Connection)
                cmd.Parameters.AddWithValue("@name", "%" & DigiName & "%")
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("search error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    ' Handles the search button click for items
    Private Sub ButtonSearchItem_Click(sender As Object, e As EventArgs) Handles ButtonSearchItem.Click
        Dim suchbegriff = TextBoxSearchItemName.Text.Trim

        If suchbegriff = "" Then
            MessageBox.Show("Please enter an item name.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim resultTable = SearchItemsByName(suchbegriff)
        DataGridViewResults.DataSource = resultTable

        With DataGridViewResults
            .AutoGenerateColumns = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ColumnHeadersVisible = True
        End With
    End Sub

    ' Handles the search button click for Digimon
    Private Sub ButtonSearchDigi_Click(sender As Object, e As EventArgs) Handles ButtonSearchDigi.Click
        Dim suchbegriff = TextBoxSearchDigi.Text.Trim

        If suchbegriff = "" Then
            MessageBox.Show("Please enter an Digimon name.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim resultTable = SearchDigimonByName(suchbegriff)
        DataGridViewResultDigi.DataSource = resultTable

        With DataGridViewResultDigi
            .AutoGenerateColumns = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ColumnHeadersVisible = True
        End With
    End Sub

    'handles the link click event for LinkLabel
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim psi As New ProcessStartInfo With {
            .FileName = e.Link.LinkData.ToString(),
            .UseShellExecute = True
        }
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Could not open the link: " & ex.Message)
        End Try
    End Sub

End Class