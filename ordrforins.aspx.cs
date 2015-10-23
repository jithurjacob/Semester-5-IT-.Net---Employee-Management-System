using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ordrforins : System.Web.UI.Page
{
    Dbacess d1 = new Dbacess();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           
        }
        catch (Exception ex) {
            Label1.Text = ex.ToString();
            Response.Redirect("default.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string policyname, empname, emi, id;
            string sql5 = "Select max(id)+1 as count from policyrequest";
            empname = Session["username"].ToString(); // DropDownList2.SelectedItem.ToString();
            policyname = DropDownList1.SelectedItem.ToString();
            emi = TextBox5.Text;
            //  medicalid = TextBox6.Text;
            if(emi.Equals("")){
                Label1.Text = "Emi cannot be empty...";
                return;
            }
            DataTable dt, dt1,dt2;
            dt = d1.GetData(sql5);
            id = (dt.Rows[0][0]).ToString();
            Boolean valid = true;
            string sql1 = "select empname from emp_policy where empname='" + empname + "' and policyname='" + policyname + "'  ";
            dt1 = d1.GetData(sql1);
            if (dt1.Rows.Count > 0)
                valid = false;

            if (id == "")
                id = "1";
            Boolean valid1 = true;
            string sql2 = "select * from policyrequest where empname='" + empname + "' and policyname='" + policyname + "' ";
            dt2 = d1.GetData(sql2);
            if (dt2.Rows.Count > 0)
                valid1 = false;

            if (valid && valid1)
            {
                string sql3 = "insert into policyrequest values('" + id + "','" + policyname + "','" + empname + "','" + emi + "' ,'pending');";
                //Label1.Text = sql3;
                int b = d1.InsertData(sql3);
                if (b > 0)
                {

                    Label1.Text = "Policy requested successfully...";
                }

                else
                    Label1.Text = " Policy request Failed";

            }
            else if (!valid)
                Label1.Text = "Policy has already been added...";
            else if (!valid1)
                Label1.Text = "Policy has already been requested...";

        }
        catch (Exception ex) {
            Label1.Text = ex.ToString();
            
            Response.Redirect("default.aspx");
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Text = "yo";
      
    }
}