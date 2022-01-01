Imports System.Data.SqlClient
Public Class doctorForm
    Public patname As String
    Private Sub doctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcdoclabel.Text = "مرحبا بك مرة اخرى د. " + loginForm.welc
    End Sub

    Private Sub showapb_Click(sender As Object, e As EventArgs) Handles showapb.Click
        con.Open()
        Try
            Dim ad As New SqlDataAdapter($"select id as [رقم الموعد],ap_date as [تاريخ الموعد] ,ap_time as [وقت الموعد],reason  as [الحالة الطبية],p_name as [اسم المريض] ,d_name as [اسم الطبيب] from Appointments where d_name='{loginForm.welc}'", con)
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

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        Dim i As Integer
        i = e.RowIndex
        Dim sr As New DataGridViewRow
        sr = dgv1.Rows(i)
        apdatetb.Text = sr.Cells(1).Value.ToString()
        aptimetb.Text = sr.Cells(2).Value.ToString()
        patcondtb.Text = sr.Cells(3).Value.ToString()
        patnametb.Text = sr.Cells(4).Value.ToString()
    End Sub

    Private Sub gotoreceiptb_Click(sender As Object, e As EventArgs) Handles gotoreceiptb.Click
        If patnametb.Text = Nothing Then
            MsgBox("يرجى اختيار موعد")
        Else
            receiptForm.Show()
            patname = patnametb.Text
            receiptForm.patnametb.Text = patname
            receiptForm.patnametb.ReadOnly = True
        End If
    End Sub
End Class