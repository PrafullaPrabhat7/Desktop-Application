Imports System.Data.SqlClient

Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


     


        Try
            con.ConnectionString = "Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=minor;Integrated Security=True"
            con.Open()
            cmd.Connection = con

            cmd = New SqlCommand("insert into e_fdetail ([fname], [lname], [Gender], [mno], [states], [District], [addres], [pcode], [u_id], [u_pass]) values ('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox10.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "')", con)

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("Invalid" & ex.Message)
        Finally
            con.Close()
        End Try
        MessageBox.Show("Employee Added")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False

    End Sub
End Class