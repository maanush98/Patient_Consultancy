Imports MySql.Data.MySqlClient

Public Class Register
    Dim gender As String
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim fname As String = TextBoxfn.Text
        Dim lname As String = TextBoxln.Text
        Dim username As String = TextBoxun.Text
        Dim occupation As String = TextBoxocc.Text
        Dim password As String = TextBoxpass.Text
        Dim age As String = TextBoxage.Text
        Dim address As String = TextBoxadd.Text


        If fname.Trim() = "" Or lname.Trim() = "" Or username.Trim() = "" Or occupation.Trim() = "" Or password.Trim() = "" Or age.Trim() = "" Or address.Trim() = "" Then

            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)


        ElseIf usernameExist(username) Then

            MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            ' add the new user
            Dim conn As New Connection()
            Dim command As New MySqlCommand("INSERT INTO `users`(`username`, `password`, `first_name`, `last_name`, `occupation`, `address`, `age`, `gender`) VALUES (@usn, @pass, @fn, @ln, @occ, @add, @age, @gen)", conn.getConnection)

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
            command.Parameters.Add("@occ", MySqlDbType.VarChar).Value = occupation
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = address
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age
            command.Parameters.Add("@gen", MySqlDbType.VarChar).Value = gender

            conn.OpenConnection()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.CloseConnection()

            Else

                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.CloseConnection()

            End If


        End If

    End Sub

    ' create a function to check if the username already exists
    Public Function usernameExist(ByVal username As String) As Boolean

        Dim con As New Connection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the username exist return true
        If table.Rows.Count > 0 Then

            Return True

            ' if not return false  
        Else

            Return False

        End If

    End Function

    Private Sub TextBoxfn_TextChanged(sender As Object, e As EventArgs) Handles TextBoxfn.TextChanged

    End Sub

    Private Sub TextBoxfn_Enter(sender As Object, e As EventArgs) Handles TextBoxfn.Enter
        Labelfn.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxfn_Leave(sender As Object, e As EventArgs) Handles TextBoxfn.Leave
        Labelfn.ForeColor = Color.Black

    End Sub

    Private Sub TextBoxun_TextChanged(sender As Object, e As EventArgs) Handles TextBoxun.TextChanged

    End Sub

    Private Sub TextBoxun_Enter(sender As Object, e As EventArgs) Handles TextBoxun.Enter
        Labelun.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxun_Leave(sender As Object, e As EventArgs) Handles TextBoxun.Leave
        Labelun.ForeColor = Color.Black
    End Sub

    Private Sub TextBoxln_Enter(sender As Object, e As EventArgs) Handles TextBoxln.Enter
        Labelln.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxln_Leave(sender As Object, e As EventArgs) Handles TextBoxln.Leave
        Labelln.ForeColor = Color.Black
    End Sub

    Private Sub TextBoxpass_Enter(sender As Object, e As EventArgs) Handles TextBoxpass.Enter
        Labelpass.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxpass_Leave(sender As Object, e As EventArgs) Handles TextBoxpass.Leave
        Labelpass.ForeColor = Color.Black
    End Sub

    Private Sub TextBoxocc_Enter(sender As Object, e As EventArgs) Handles TextBoxocc.Enter
        Labeloc.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxocc_Leave(sender As Object, e As EventArgs) Handles TextBoxocc.Leave
        Labeloc.ForeColor = Color.Black
    End Sub

    Private Sub TextBoxage_Enter(sender As Object, e As EventArgs) Handles TextBoxage.Enter
        Labelage.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxage_Leave(sender As Object, e As EventArgs) Handles TextBoxage.Leave
        Labelage.ForeColor = Color.Black
    End Sub

    Private Sub RadioButtonmale_Enter(sender As Object, e As EventArgs) Handles RadioButtonmale.Enter
        RadioButtonmale.ForeColor = Color.Red
    End Sub

    Private Sub RadioButtonmale_Leave(sender As Object, e As EventArgs) Handles RadioButtonmale.Leave
        RadioButtonmale.ForeColor = Color.Black

    End Sub

    Private Sub RadioButtonfemale_Enter(sender As Object, e As EventArgs) Handles RadioButtonfemale.Enter
        RadioButtonfemale.ForeColor = Color.Red
    End Sub

    Private Sub RadioButtonfemale_Leave(sender As Object, e As EventArgs) Handles RadioButtonfemale.Leave
        RadioButtonfemale.ForeColor = Color.Black
    End Sub

    Private Sub TextBoxadd_Enter(sender As Object, e As EventArgs) Handles TextBoxadd.Enter
        Labeladd.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxadd_Leave(sender As Object, e As EventArgs) Handles TextBoxadd.Leave
        Labeladd.ForeColor = Color.Black
    End Sub

    Private Sub RadioButtonmale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonmale.CheckedChanged
        gender = "male"
    End Sub

    Private Sub RadioButtonfemale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonfemale.CheckedChanged
        gender = "female"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Dim lform As New Login()
        lform.Show()

    End Sub
End Class