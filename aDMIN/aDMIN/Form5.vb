Imports System.Data.SqlClient

Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As SqlConnection = New SqlConnection("Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=minor;Integrated Security=True")
        x.Open()
        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = x
        y.SelectCommand.CommandText = "Select * from e_fdetail"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "b")
        DataGridView1.DataSource = z
        DataGridView1.DataMember = "b"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()


    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub
End Class