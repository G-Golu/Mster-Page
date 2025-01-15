using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string path;
        string file = FileUpload1.FileName;
        path = Server.MapPath("~\\FILES\\") + file;

        // Save the file to the specified path
        FileUpload1.SaveAs(path);
    }
}