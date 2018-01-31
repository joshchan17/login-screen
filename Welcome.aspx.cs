﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["user"] != null)
        {
            txtuser.Text = "Welcome " + Session["user"].ToString();
        }
    }
    protected void logoutbtn_Click(object sender, EventArgs e)
    {
        Session.Remove("user");
        Response.Redirect("~/Default.aspx");
    }
}