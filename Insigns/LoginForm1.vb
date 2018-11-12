Imports Insigns
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim db As New ConnectionClass.ClassDB

        Dim ds As New DataSet
        Dim ds2 As New DataSet
        Dim query As String


        query = "SELECT Users.IdUser, UserTypes.LevelAcces, Users.DescUser FROM UserTypes INNER JOIN Users ON UserTypes.IdUserType = Users.idUserType WHERE (((Users.login) = '" + UsernameTextBox.Text + "') AND ((Users.password) = '" + PasswordTextBox.Text + "'))"

        'MessageBox.Show(query)

        'ds = db.portaTaula("Users")
        ds = db.portaPerConsulta("SELECT * FROM Users WHERE login = '" + UsernameTextBox.Text + "' AND password = '" + PasswordTextBox.Text + "'")

        'MessageBox.Show(ds.Tables(0).Rows.Count)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim frm As New MDI_Insign
            Dim v_infoUsuario(2) As String

            v_infoUsuario(0) = ds.Tables(0).Rows(0).Item("idUserType").ToString
            v_infoUsuario(1) = ds.Tables(0).Rows(0).Item("idUser").ToString
            v_infoUsuario(2) = ds.Tables(0).Rows(0).Item("login").ToString


            frm.Show()
            Me.Close()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If


        '
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
