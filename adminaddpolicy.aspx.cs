using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class adminaddpolicy : System.Web.UI.Page
{
    Dbacess d1 = new Dbacess();
    protected void Page_Load(object sender, EventArgs e)
    { 
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string  policyname, empname, emi, id;
        string sql5 = "Select max(id)+1 as count from emp_policy";
        empname = DropDownList2.SelectedItem.ToString();
        policyname = DropDownList1.SelectedItem.ToString();
        emi = TextBox5.Text;
        //medicalid = TextBox9.Text;
        if(emi.Equals("")){
            Label1.Text = "Enter an emi value...";
            return;
        }
        DataTable dt, dt1;
        dt = d1.GetData(sql5);
        id = (dt.Rows[0][0]).ToString();
        Boolean valid = true;
        string sql1 = "select empname from emp_policy where empname='" + empname + "'  and policyname='"+policyname +"'";
        dt1 = d1.GetData(sql1);
        if (dt1.Rows.Count > 0)
            valid = false;

        if (id == "")
            id = "1";
        if (valid)
        {
            string sql3 = "insert into emp_policy values('" + id + "','" + policyname + "','" + empname + "','" + emi + "');";
            //Label1.Text = sql3;
            int b = d1.InsertData(sql3);
            if (b > 0)
            {

                Label1.Text = "Policy added";
            }

            else
                Label1.Text = " Policy addition Failed";

        }
        else
            Label1.Text = "Policy has already been added...";
    
    
    }
}