﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class teacher_STreportEA : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Write("<script>alert('用户登录超时，请重新登录。');location='../Default.aspx'</script>"); 
             return;
        }
        if (!Page.IsPostBack)
        {
            this.GridView1.Visible = false;
            this.GridView2.Visible = true;
        }
        else
        {
            this.GridView1.Visible = true;
            this.GridView2.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        this.GridView1.Visible = true;
        this.GridView2.Visible = false;

    }
}
