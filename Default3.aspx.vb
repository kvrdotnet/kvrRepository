
Partial Class Default3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1Day As String = Me.t1.Text.Remove(2)
        Dim date2Day As String = Me.t2.Text.Remove(2)
        Dim date1Month As String = Me.t1.Text.Substring(3, 2)
        Dim date2Month As String = Me.t2.Text.Substring(3, 2)
        Dim date1Year As String = Me.t1.Text.Substring(6)
        Dim date2Year As String = Me.t2.Text.Substring(6)
        Dim d1 As DateTime = Convert.ToDateTime(date1Month + "/" + date1Day + "/" + date1Year)
        Dim d2 As DateTime = Convert.ToDateTime(date2Month + "/" + date2Day + "/" + date2Year)
        Response.Write(date1Day)
        Response.Write(date1Month)
        Response.Write(date1Year)
        Response.Write(date2Day)
        Response.Write(date2Month)
        Response.Write(date2Year)
        'If d1 > d2 Then

        '    ClientScript.RegisterStartupScript(Me.GetType(), "Alert", "alert('Date1isgreater')", True)

        'ElseIf d1 = d2 Then

        '    ClientScript.RegisterStartupScript(Me.GetType(), "Alert", "alert('Botharesame')", True)

        'Else

        '    ClientScript.RegisterStartupScript(Me.GetType(), "Alert", "alert('Date2isgreater')", True)
        'End If

    End Sub
End Class
