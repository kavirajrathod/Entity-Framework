using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TraineeAppp
{
    public class DataLayer
    {

        DataSet ds = new DataSet();
        string constr = "";
        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        }


        public DataSet Getallrecords()
        {         
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand();                  
                    cmd.CommandText = "ViewData";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ds;
        }



        public void InsertInForm(int Tid,string Tname,string Tlocation,string Techdomain,string Startdate)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Tid",Tid);
                    cmd.Parameters.AddWithValue("@Tname", Tname);
                    cmd.Parameters.AddWithValue("@Tlocation", Tlocation);
                    cmd.Parameters.AddWithValue("@Techdomain", Techdomain);
                    cmd.Parameters.AddWithValue("@Startdate", Startdate);

                    cmd.CommandText = "InsertData1";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);

                    sd.Fill(ds);
                    sd.Update(ds);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        public DataSet SearchById(int Tid)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Tid", Tid);               
                    cmd.CommandText = "SearchData";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                    sd.Update(ds);
                    
                }

            }
            catch (Exception e)
            {               Console.WriteLine(e.Message);
            }
            return ds;

        }


        public void UpdateData(int Tid,string Techdomain)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@Tid", Tid);
                    cmd.Parameters.AddWithValue("@Techdomain", Techdomain);

                    cmd.CommandText = "UpdateData";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);

                    sd.Fill(ds);
                    sd.Update(ds);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}