using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CityBL;
using System.Data;

using CityDL.DataConnection;

namespace CityBusManagementSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DBConnection DBConnectionObj = new DBConnection();
            DBModel DBModelObj = new DBModel();

            
            DBModelObj.Route_no = Convert.ToInt32(TxtRouteNum.Text);
            DBModelObj.No_of_Stops = Convert.ToInt32(TxtNumOfStops.Text);
            DBModelObj.Start_time = TxtStartTime.Text;
            DBModelObj.End_time = TxtEndTime.Text;

            string msg = DBConnectionObj.InsertTutorial(DBModelObj);
            lblResults.Text = msg;
            DataTable DtResult = DBConnectionObj.SelectTutorial();

            GridView2.DataSource = DtResult;
            GridView2.DataBind();
            


        }


        protected void Btndelete_Click(object sender, EventArgs e)
        {
            DBConnection DBConnectionObj = new DBConnection();
            string msg = DBConnectionObj.DeleteRouteManagementTblByRoute_no(Convert.ToInt32(TxtRouteNum.Text));
            lblResults.Text = msg;

            LoadData();

        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            DBConnection DBConnectionObj = new DBConnection();
            DataTable dtResult = DBConnectionObj.EditRouteManagementTblByRoute_no(Convert.ToInt32(TxtRouteNum.Text));
            TxtNumOfStops.Text = dtResult.Rows[0][1].ToString();
            TxtStartTime.Text = dtResult.Rows[0][2].ToString();
            TxtEndTime.Text = dtResult.Rows[0][3].ToString();
        }

        protected void BtnExit_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            DBConnection DBConnectionObj = new DBConnection();
            DataTable dtResult = DBConnectionObj.SelectTutorial();
            GridView2.DataSource = dtResult;
            GridView2.DataBind();
        }
    }
}