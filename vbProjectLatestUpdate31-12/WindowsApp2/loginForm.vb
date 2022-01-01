Imports System.Data.SqlClient
Public Class loginForm
    Public welc As String
    Public myid As String
    Public mypass As String
    Private Sub showpasschb_CheckedChanged(sender As Object, e As EventArgs) Handles showpasschb.CheckedChanged
        If showpasschb.Checked Then
            passwordtb.PasswordChar = ""
        Else
            passwordtb.PasswordChar = "*"
        End If
    End Sub

    Private Sub loginb_Click(sender As Object, e As EventArgs) Handles loginb.Click
        If idtb.Text = Nothing Or passwordtb.Text = Nothing Then
            MsgBox("Enter Information!", MsgBoxStyle.Exclamation)
        Else
            con.Open()
            Try
                Dim cmd As New SqlCommand($"select * from users where id={idtb.Text} and password={passwordtb.Text}", con)
                Dim lvlcmd As New SqlCommand($"select level from users where id={idtb.Text}", con)
                Dim namecmd As New SqlCommand($"select name from users where id={idtb.Text}", con)
                Dim idcmd As New SqlCommand($"select id from users where id={idtb.Text}", con)
                Dim passcmd As New SqlCommand($"select password from users where id={idtb.Text}", con)
                Dim level = lvlcmd.ExecuteScalar
                Dim name = namecmd.ExecuteScalar
                Dim id = idcmd.ExecuteScalar
                Dim pass = passcmd.ExecuteScalar
                Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                If (dt.Rows.Count > 0) Then
                    If (level = 1) Then
                        welc = name.ToString
                        myid = id.ToString
                        mypass = pass.ToString
                        adminform.Show()
                        idtb.Text = ""
                        passwordtb.Text = ""
                    ElseIf (level = 2) Then
                        welc = name.ToString
                        doctorForm.Show()
                        idtb.Text = ""
                        passwordtb.Text = ""
                    ElseIf (level = 3) Then
                        welc = name.ToString
                        patientForm.Show()
                        idtb.Text = ""
                        passwordtb.Text = ""
                    ElseIf (level = 4) Then
                        welc = name.ToString
                        PharmacyForm.Show()
                        idtb.Text = ""
                        passwordtb.Text = ""
                    Else
                        MsgBox("Account not found!", MsgBoxStyle.Critical)
                        idtb.Text = ""
                        passwordtb.Text = ""
                    End If
                Else
                    MessageBox.Show("Username or Password Incorrect!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

        End If
    End Sub

End Class
