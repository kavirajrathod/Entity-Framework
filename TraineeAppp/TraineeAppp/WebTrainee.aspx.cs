using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeAppp
{
    public partial class WebTrainee : System.Web.UI.Page
    {
        DataLayer d = new DataLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            { 
            
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            
            

            int tid = Convert.ToInt32( TextBox1.Text);
            string tname = TextBox2.Text;
            string tlocation = TextBox3.Text;
            string techdomain = TextBox4.Text;
            string startdate = TextBox5.Text;
            d.InsertInForm(tid,tname,tlocation,techdomain,startdate);
            var i = d.Getallrecords();
            GridView1.DataSource = i;
            GridView1.DataBind();

         

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(TextBox6.Text);           
            GridView2.DataSource = d.SearchById(uid);
            GridView2.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            int tid = Convert.ToInt32(utid.Text);
            string techdomain = newTech.Text;
            d.UpdateData(tid,techdomain);

            GridView3.DataSource = d.Getallrecords();
            GridView3.DataBind();
        }
    }
}