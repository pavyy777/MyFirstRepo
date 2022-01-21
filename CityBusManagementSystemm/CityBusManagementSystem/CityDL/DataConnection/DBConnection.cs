using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace CityDL.DataConnection
{
    public class DBConnection
    {
        string sqlConnectionStr = "Data Source=DESKTOP-PAVAN\\SQLEXPRESS;Initial Catalog=CityBusManagementSystemDB;Integrated Security=True";



        public string InsertTutorial(DBModel DBModelObj)
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into RouteManagementTbl values(" + DBModelObj.Route_no + "," + DBModelObj.No_of_Stops + ",'" + DBModelObj.Start_time + "','" + DBModelObj.End_time + "')", sqlConnectionObj);
            adp.Fill(dt);
            return " Details saved successfully";
        }
        public DataTable SelectTutorial()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from RouteManagementTbl", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;

        }
        public string DeleteRouteManagementTblByRoute_no(int route_no)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlCommand sqlCommandObj = new SqlCommand("delete from RouteManagementTbl where Route_no=" + route_no + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Route Number " + route_no + " details deleted successfully";
        }
        public DataTable EditRouteManagementTblByRoute_no(int route_no)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from RouteManagementTbl where Route_no=" + route_no + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
    }
    public class DBConnectionEmployeeDetails
    {
        string sqlConnectionStr = "Data Source=DESKTOP-PAVAN\\SQLEXPRESS;Initial Catalog=CityBusManagementSystemDB;Integrated Security=True";



        public string InsertTutorial(EmployeeModel EmployeeModelobj)
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into EmployeeDetailsTbl values(" + EmployeeModelobj.Employee_ID + ",'" + EmployeeModelobj.Employee_Name + "','" + EmployeeModelobj.Designation + "')", sqlConnectionObj);
            adp.Fill(dt);
            //adp.Fill(dt);
            return " Details saved successfully";
        }
        public DataTable SelectTutorial()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from EmployeeDetailsTbl", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;

        }

    }
    public class DBConnectionBusDetails
    {
        string sqlConnectionStr = "Data Source=DESKTOP-PAVAN\\SQLEXPRESS;Initial Catalog=CityBusManagementSystemDB;Integrated Security=True";



        public string InsertTutorial(BusDetailsModel BusDetailsModelobj)
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into BusDetailsTbl values('" + BusDetailsModelobj.Bus_name + "'," + BusDetailsModelobj.Bus_Number + "," + BusDetailsModelobj.Route_No + ",'" + BusDetailsModelobj.Arrival_Time + "','" + BusDetailsModelobj.Departure_time + "')", sqlConnectionObj);
            adp.Fill(dt);
            return " Details saved successfully";
        }
        public DataTable SelectTutorial()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from BusDetailsTbl", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;

        }
        public string DeleteBusDetailsTblByBus_Number(int bus_Number)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);

            SqlCommand sqlCommandObj = new SqlCommand("delete from BusDetailsTbl where Bus_Number=" + bus_Number + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Bus Number " + bus_Number + " details deleted successfully";
        }
        public DataTable EditBusDetailsTblByBus_Name(int bus_Number)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from BusDetailsTbl where Bus_Number=" + bus_Number + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        
    }   }
