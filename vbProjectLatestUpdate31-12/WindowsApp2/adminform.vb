Imports System.Data.SqlClient
Public Class adminform
    Private Sub adddb_Click(sender As Object, e As EventArgs) Handles adddb.Click
        con.Open()
        Try
            Dim cmd As New SqlCommand($"insert into doctors(id,name,specialty,start_time,end_time) values('{Trim(docidtb.Text)}','{Trim(docnametb.Text)}','{Trim(docsptb.Text)}','{starttime.Value.ToLongTimeString}','{endtime.Value.ToLongTimeString}')", con)
            cmd.ExecuteNonQuery()
            MsgBox("نم اضافة الطبيب بنجاح")
            Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub showdb_Click(sender As Object, e As EventArgs) Handles showdb.Click
        con.Open()
        Try
            Dim ad As New SqlDataAdapter("select * from doctors", con)
            Dim ds As New DataSet
            ad.Fill(ds)
            dgv1.DataSource = ds
            dgv1.DataMember = ds.Tables(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub removedb_Click(sender As Object, e As EventArgs) Handles removedb.Click
        con.Open()
        Try
            Dim cmd As New SqlCommand($"delete from doctors where id={docidtb.Text}", con)
            cmd.ExecuteNonQuery()
            MsgBox("تم ازالة الطبيب بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        loginForm.Show()
    End Sub

    Private Sub Closeb_Click(sender As Object, e As EventArgs) Handles Closeb.Click
        loginForm.Close()
        Me.Close()
    End Sub

    Private Sub addpb_Click(sender As Object, e As EventArgs) Handles addpb.Click
        con.Open()
        Try
            If patidtb.Text = Nothing Then
                MsgBox("يرجى ادخال رقم المريض")
            ElseIf patnametb.Text = Nothing Then
                MsgBox("يرجى ادخال اسم المريض")
            Else
                MsgBox("")
            End If
            Dim cmd As New SqlCommand($"insert into patient(id,name,phone) values('{Trim(patidtb.Text)}','{Trim(patnametb.Text)}','{Trim(patphonetb.Text)}')", con)
            cmd.ExecuteNonQuery()
            MsgBox("تم اضافة المريض بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub showpb_Click(sender As Object, e As EventArgs) Handles showpb.Click
        con.Open()
        Try
            Dim ad As New SqlDataAdapter("select * from patient", con)
            Dim ds As New DataSet
            ad.Fill(ds)
            dgv1.DataSource = ds
            dgv1.DataMember = ds.Tables(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub mngcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mngcb.SelectedIndexChanged
        patconcb.Items.Clear()
        If mngcb.SelectedIndex = 0 Then
            doctors_managmentgb.Visible = True
            patients_managmentgb.Visible = False
            Appointment_managmentgb.Visible = False
            doctors_managmentgb.Width = 700
        ElseIf mngcb.SelectedIndex = 1 Then
            doctors_managmentgb.Visible = False
            patients_managmentgb.Visible = True
            Appointment_managmentgb.Visible = False
            patients_managmentgb.Width = 700
        ElseIf mngcb.SelectedIndex = 2 Then
            doctors_managmentgb.Visible = False
            patients_managmentgb.Visible = False
            Appointment_managmentgb.Visible = True
            Appointment_managmentgb.Width = 700
        End If
        'fill specialties in patconcb (condition)
        con.Open()
        Try
            Dim cmd As New SqlCommand("select specialty from doctors", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While (dr.Read())
                patconcb.Items.Add(dr(0))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub removepb_Click(sender As Object, e As EventArgs) Handles removepb.Click
        con.Open()
        Try
            If patidtb.Text = Nothing Then
                MsgBox("الرجاء ادخال رقم المريض المراد ازالته")
            Else
                Dim cmd As New SqlCommand($"delete from patient where id={patidtb.Text}", con)
                cmd.ExecuteNonQuery()
                MsgBox("تم ازالة المريض بنجاح")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub showapb_Click(sender As Object, e As EventArgs) Handles showapb.Click
        con.Open()
        Try
            Dim ad As New SqlDataAdapter("select * from appointments", con)
            Dim ds As New DataSet
            ad.Fill(ds)
            dgv1.DataSource = ds
            dgv1.DataMember = ds.Tables(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub addapb_Click(sender As Object, e As EventArgs) Handles addapb.Click
        con.Open()
        Try
            Dim chk As New SqlCommand($"select * from patient where name='{appatnametb.Text}'", con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(chk)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Dim cmd As New SqlCommand($"insert into appointments(id,ap_date,ap_time,reason,p_name,d_name) values('{Trim(appidtb.Text)}','{Trim(apdate.Value)}','{Trim(aptime.Value.ToLongTimeString)}','{Trim(patconcb.Text)}','{Trim(appatnametb.Text)}','{Trim(apdocnamecb.Text)}')", con)
                cmd.ExecuteNonQuery()
                MsgBox("تم اضافة الموعد بنجاح")
            Else
                MsgBox("المريض غير موجود")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            patconcb.Items.Clear()
            con.Open()
            Dim cmd1 As New SqlCommand($"select name from doctors where specialty ='{patconcb.Text}'", con)
            Dim dr1 As SqlDataReader = cmd1.ExecuteReader
            While (dr1.Read())
                apdocnamecb.Items.Add(dr1(0))
            End While
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub patconcb_TextChanged(sender As Object, e As EventArgs) Handles patconcb.TextChanged
        Try
            apdocnamecb.Items.Clear()
            con.Open()
            Dim cmd1 As New SqlCommand($"select name from doctors where specialty ='{patconcb.Text}'", con)
            Dim dr1 As SqlDataReader = cmd1.ExecuteReader
            While (dr1.Read())
                apdocnamecb.Items.Add(dr1(0))
            End While
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub apdocnamecb_TextChanged(sender As Object, e As EventArgs) Handles apdocnamecb.TextChanged
        con.Open()
        Try

            Dim cmd As New SqlCommand($"select start_time,end_time from doctors where name='{apdocnamecb.Text}'", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While (dr.Read())
                avtimetb.Text = dr("start_time").ToString & " To " & dr("end_time").ToString
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub removeapb_Click(sender As Object, e As EventArgs) Handles removeapb.Click
        con.Open()
        Try
            Dim cmd As New SqlCommand($"delete from appointments where id={appidtb.Text}", con)
            cmd.ExecuteNonQuery()
            MsgBox("تم ازالة الموعد بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        mynametb.Text = loginForm.welc

    End Sub
    'edit my name
    Private Sub editb1_Click(sender As Object, e As EventArgs) Handles editb1.Click
        mynametb.ReadOnly = False
        doneb1.Visible = True
    End Sub

    Private Sub doneb1_Click(sender As Object, e As EventArgs) Handles doneb1.Click
        con.Open()
        Try
            Dim cmd As New SqlCommand($"update users  set name='{mynametb.Text}' where id='{loginForm.myid}'", con)
            cmd.ExecuteNonQuery()
            doneb1.Visible = False
            mynametb.ReadOnly = True
            MsgBox("تم تغيير الاسم بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub showoldpass_CheckedChanged(sender As Object, e As EventArgs) Handles showoldpass.CheckedChanged
        If showoldpass.Checked Then
            oldpasstb.PasswordChar = ""
        Else
            oldpasstb.PasswordChar = "*"
        End If
    End Sub

    Private Sub shownewpass_CheckedChanged(sender As Object, e As EventArgs) Handles shownewpass.CheckedChanged
        If shownewpass.Checked Then
            newpasstb.PasswordChar = ""
        Else
            newpasstb.PasswordChar = "*"
        End If
    End Sub

    Private Sub cahangepassb_Click(sender As Object, e As EventArgs) Handles cahangepassb.Click
        con.Open()
        Try
            If oldpasstb.Text = loginForm.mypass Then
                Dim cmd As New SqlCommand($"update users  set password='{newpasstb.Text}' where id='{loginForm.myid}'", con)
                cmd.ExecuteNonQuery()
                MsgBox("تم تغيير كلمة السر  بنجاح")
            Else
                MsgBox("كلمة السر التي تم ادخالها خاطئة")
                oldpasstb.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'change password

End Class