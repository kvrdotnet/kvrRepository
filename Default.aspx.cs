using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    private SqlConnection con = new SqlConnection("Data Source=xxxx;Integrated Security=true;Initial Catalog=xxx");
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindGridviewData();
        }
    }
    // Bind Gridview Data
    private void BindGridviewData()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from FilesTable",con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        gvDetails.DataSource = ds;
        gvDetails.DataBind();
    }
    // Save files to Folder and files path in database
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        string filename = Path.GetFileName(fileUpload1.PostedFile.FileName);
        fileUpload1.SaveAs(Server.MapPath("Files/"+filename));
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into FilesTable(FileName,FilePath) values(@Name,@Path)",con);
        cmd.Parameters.AddWithValue("@Name",filename );
        cmd.Parameters.AddWithValue("@Path", "Files/"+filename );
        cmd.ExecuteNonQuery();
        con.Close();
        BindGridviewData();
    }
    // This button click event is used to download files from gridview
    protected void lnkDownload_Click(object sender, EventArgs e)
    {
        LinkButton lnkbtn = sender as LinkButton;
        GridViewRow gvrow = lnkbtn.NamingContainer as GridViewRow;
        string filePath = gvDetails.DataKeys[gvrow.RowIndex].Value.ToString();
        Response.ContentType = "image/jpg";
        Response.AddHeader("Content-Disposition", "attachment;filename=\"" + filePath + "\"");
        Response.TransmitFile(Server.MapPath(filePath));
        Response.End();
    }
}
