using System.Data.SqlClient;
using System.Data;
using MVCWebApplicationHTD.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Configuration;

using System.Reflection;
using MVCWebApplicationHTD.Controllers;

namespace MVCWebApplicationHTD.Business_Logic
{
    public class InsertCarData
    {
        public static bool Insertdata(CarModelcs obj)
        {
            bool res = false;
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                try
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("sp_car", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Equipment", obj.Equipment);
                    cmd.Parameters.AddWithValue("@cartype", obj.cartype);
                    cmd.Parameters.AddWithValue("@commodity", obj.commodity);
                    cmd.Parameters.AddWithValue("@arrived", Convert.ToDateTime(obj.arrived));
                    cmd.Parameters.AddWithValue("@modified", Convert.ToDateTime(obj.modified));
                    cmd.Parameters.AddWithValue("@orderid", Convert.ToDateTime(obj.orderid));
                    cmd.Parameters.AddWithValue("@placed", Convert.ToDateTime(obj.placed));
                    cmd.Parameters.AddWithValue("@released", Convert.ToDateTime(obj.released));
                    cmd.Parameters.AddWithValue("@credit", obj.credit);

                    cmd.Parameters.AddWithValue("@days", obj.days);
                    cmd.Parameters.AddWithValue("@missedswitch", obj.missedswitch);

                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        return res = true;
                    }
                    else
                    {
                        return res = false;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    con.Close();
                }
                return res = true;
            }

        }


        public static List<CarModelcs> GetAllData()
        {
            List<CarModelcs> obj = new List<CarModelcs>();
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_displaycar", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
            
                foreach (DataRow dr in dt.Rows)
                {
                    obj.Add(new CarModelcs
                    {
                            Equipment =Convert.ToString( dr["Equipment"].ToString()),
                            cartype = Convert.ToString(dr["cartype"].ToString()),
                            commodity = Convert.ToString(dr["commodity"].ToString()),
                            arrived = Convert.ToDateTime(dr["arrived"].ToString()),
                            modified = Convert.ToDateTime(dr["modified"].ToString()),
                            orderid = Convert.ToDateTime(dr["orderid"].ToString()),
                            placed = Convert.ToDateTime(dr["placed"].ToString()),
                            released = Convert.ToDateTime(dr["released"].ToString()),
                            credit = Convert.ToInt32(dr["credit"].ToString()),
                            days = Convert.ToInt32(dr["days"].ToString()),
                            missedswitch = Convert.ToInt32(dr["missedswitch"].ToString())        }
                        );
                }
                return obj;
            }

        }
        public static bool GetDataByCARTYPE(String cartype)
        {
            bool res = false;
            CarModelcs OBJ = null;
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_GETDATA_CAR", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cartype", cartype);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        OBJ = new CarModelcs();
                        OBJ.Equipment = ds.Tables[0].Rows[i]["Equipment"].ToString();
                        OBJ.cartype = ds.Tables[0].Rows[i]["cartype"].ToString();
                        OBJ.commodity = ds.Tables[0].Rows[i]["commodity"].ToString();
                        OBJ.arrived = Convert.ToDateTime(ds.Tables[0].Rows[i]["arrived"].ToString());
                        OBJ.modified = Convert.ToDateTime(ds.Tables[0].Rows[i]["modified"].ToString());
                        OBJ.orderid = Convert.ToDateTime(ds.Tables[0].Rows[i]["orderid"].ToString());
                        OBJ.placed = Convert.ToDateTime(ds.Tables[0].Rows[i]["placed"].ToString());
                        OBJ.released = Convert.ToDateTime(ds.Tables[0].Rows[i]["released"].ToString());
                        OBJ.credit = Convert.ToInt32(ds.Tables[0].Rows[i]["credit"].ToString());
                        OBJ.days = Convert.ToInt32(ds.Tables[0].Rows[i]["days"].ToString());
                        OBJ.missedswitch = Convert.ToInt32(ds.Tables[0].Rows[i]["missedswitch"].ToString());
                        int x = cmd.ExecuteNonQuery();
                        if (x > 0)
                        {
                            return res = true;
                        }
                        else
                        {
                            return res = false;
                        }
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    con.Close();
                }
                return res = true;
            }
        }
        public static bool UPDATEDATA(CarModelcs obj)
        {
            bool res = false;
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                try
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("sp_updatecar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Equipment", obj.Equipment);
                    cmd.Parameters.AddWithValue("@cartype", obj.cartype);
                    cmd.Parameters.AddWithValue("@commodity", obj.commodity);
                    cmd.Parameters.AddWithValue("@arrived", Convert.ToDateTime(obj.arrived));
                    cmd.Parameters.AddWithValue("@modified", Convert.ToDateTime(obj.modified));
                    cmd.Parameters.AddWithValue("@orderid", Convert.ToDateTime(obj.orderid));
                    cmd.Parameters.AddWithValue("@placed", Convert.ToDateTime(obj.placed));
                    cmd.Parameters.AddWithValue("@released", Convert.ToDateTime( obj.released));
                    cmd.Parameters.AddWithValue("@credit", obj.credit);
                    cmd.Parameters.AddWithValue("@days", obj.days);
                    cmd.Parameters.AddWithValue("@missedswitch", obj.missedswitch);
                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        return res = true;
                    }
                    else
                    {
                        return res = false;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    con.Close();
                }
                return res = true;
            }
        }
        public static bool DELETEDATA(string cartype)
        {
            bool res = false;
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))
            {
                try
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("SP_DELETEDATABY_ID", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cartype", cartype);
                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        return res = true;
                    }
                    else
                    {
                        return res = false;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    con.Close();
                }
                return res = true;
            }
        }
    }
}