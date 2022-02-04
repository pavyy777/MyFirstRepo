using CityDL.DataConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CityBusManagementSystem
{
    public partial class BusDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DBConnectionBusDetails DBConnectionBusDetailsobj = new DBConnectionBusDetails();
            BusDetailsModel BusDetailsModelobj = new BusDetailsModel();


            BusDetailsModelobj.Bus_name = TxtBusName.Text;
            BusDetailsModelobj.Bus_Number = Convert.ToInt32(TxtBusNum.Text);
            BusDetailsModelobj.Route_No = Convert.ToInt32(TxtRouteNo.Text);
            BusDetailsModelobj.Arrival_Time = TxtArrival.Text;
            BusDetailsModelobj.Departure_time = TextDepart.Text;

            string msg = DBConnectionBusDetailsobj.InsertTutorial(BusDetailsModelobj);
            lblResult.Text = msg;
            DataTable DtResult = DBConnectionBusDetailsobj.SelectTutorial();

            GridView1.DataSource = DtResult;
            GridView1.DataBind();

        }

        protected void Btndelete_Click(object sender, EventArgs e)
        {
             DBConnectionBusDetails DBConnectionBusDetailsobj = new DBConnectionBusDetails();
            string msg = DBConnectionBusDetailsobj.DeleteBusDetailsTblByBus_Number(Convert.ToInt32(TxtBusNum.Text));
            lblResult.Text = msg;

            LoadData();
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            DBConnectionBusDetails DBConnectionBusDetailsobj = new DBConnectionBusDetails();
            DataTable dtResult = DBConnectionBusDetailsobj.EditBusDetailsTblByBus_Name(Convert.ToInt32(TxtBusNum.Text));
            TxtBusName.Text = dtResult.Rows[0][1].ToString();
            TxtRouteNo.Text = dtResult.Rows[0][2].ToString();
            TxtArrival.Text = dtResult.Rows[0][3].ToString();
            TextDepart.Text = dtResult.Rows[0][4].ToString();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            DBConnectionBusDetails DBConnectionBusDetailsobj = new DBConnectionBusDetails();
            
            DataTable dtResult = DBConnectionBusDetailsobj.SelectTutorial();
            GridView1.DataSource = dtResult;
            GridView1.DataBind();
        }
    }
}