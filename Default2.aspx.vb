
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Web.UI.WebControls
Partial Class Default2
    Inherits System.Web.UI.Page

    Private con As New SqlConnection("Data Source=xxxx;Integrated Security=true;Initial Catalog=xxxx")
    Protected Sub ImgBtn_Click(sender As Object, e As ImageClickEventArgs)
        Dim ImgBtn As ImageButton = TryCast(sender, ImageButton)
        Dim gvrow As GridViewRow = TryCast(ImgBtn.NamingContainer, GridViewRow)
        Dim filePath As String = gvDetails.DataKeys(gvrow.RowIndex).Value.ToString()
        Response.ContentType = "image/jpg"
        Response.AddHeader("Content-Disposition", "attachment;filename=""" & filePath & """")
        Response.TransmitFile(Server.MapPath(filePath))
        Response.[End]()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            BindGridviewData()
        End If
    End Sub
    Private Sub BindGridviewData()
        con.Open()
        Dim cmd As New SqlCommand("select * from FilesTable", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        con.Close()
        gvDetails.DataSource = ds
        gvDetails.DataBind()
    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
       
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filename As String = Path.GetFileName(fileUpload1.PostedFile.FileName)
        Dim ext As String = Path.GetExtension(fileUpload1.FileName)
        'Response.Write(ext)
        If ext.ToLower() = ".xlsx" Or ext.ToLower() = ".xls" Then
            fileUpload1.SaveAs(Server.MapPath("Files/" & filename))
            con.Open()
            Dim cmd As New SqlCommand("insert into FilesTable(FileName,FilePath) values(@Name,@Path)", con)
            cmd.Parameters.AddWithValue("@Name", filename)
            cmd.Parameters.AddWithValue("@Path", "Files/" & filename)
            cmd.ExecuteNonQuery()
            con.Close()
            BindGridviewData()

        Else
            Page.RegisterStartupScript("kk", "<script>alert('Invalid file selection')</script>")
        End If
        
    End Sub
End Class
