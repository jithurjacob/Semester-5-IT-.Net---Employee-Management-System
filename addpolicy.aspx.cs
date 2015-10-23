using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class addpolicy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    Dbacess d1 = new Dbacess();
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name, desc, amt,id;
        name = TextBox1.Text;
        desc = TextBox2.Text;
        amt = TextBox3.Text;

        DataTable dt,dt1;
        if(name.Equals("") || desc.Equals("") || amt.Equals("")){
        Label1.Text="All fields are necessary";
        return;
        }
        string sql5 = "Select max(policyid)+1 as count from policy";
        dt = d1.GetData(sql5);
        id = (dt.Rows[0][0]).ToString();
        Boolean  valid = true ;
        string sql1 = "select policytypename from policy where policytypename='"+name  +"'";
        dt1 = d1.GetData(sql1);
        if (dt1.Rows.Count > 0)
            valid = false;

        if (id == "")
            id = "1";
        if (valid)
        {
            string sql3 = "insert into policy values('" + id + "','" + name + "','" + desc  + "','" + amt  + "');";
            //Label1.Text = sql3;
            int b = d1.InsertData(sql3);
            if (b > 0)
            {

                Label1.Text = "Policy added...";
            }

            else
                Label1.Text = " Policy addition Failed";

        }
        else
            Label1.Text = "Policyame was already used...";
    }
    
}