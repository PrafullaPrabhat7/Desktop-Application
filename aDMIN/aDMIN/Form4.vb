Imports System.Data.SqlClient

Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = "Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=minor;Integrated Security=True"
            con.Open()
            cmd.Connection = con

            cmd = New SqlCommand("delete from e_fdetail where u_id=('" & TextBox1.Text & "')", con)

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
        End Try
        MessageBox.Show("Employee deleted")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub
End Class