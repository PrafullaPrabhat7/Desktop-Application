Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con = New SqlConnection
        con.ConnectionString = "Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=minor;Integrated Security=True"
        Dim reader As SqlDataReader

        Try
            con.Open()
            cmd = New SqlCommand("select * from e_fdetail where u_id='" & TextBox1.Text & "'and u_Pass='" & TextBox2.Text & "'", con)
            reader = cmd.ExecuteReader
            If reader.Read Then
                Form2.Show()

            Else
                MessageBox.Show("Invalid details", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub
End Class
