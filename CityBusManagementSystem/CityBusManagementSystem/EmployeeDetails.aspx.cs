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
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TxtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            DBConnectionEmployeeDetails DBConnectionEmployeeDetailsobj= new DBConnectionEmployeeDetails();
            EmployeeModel EmployeeModelobj = new EmployeeModel();


            EmployeeModelobj.Employee_ID = Convert.ToInt32(TxtEmpID.Text);
            EmployeeModelobj.Employee_Name =TxtEmpName.Text;
            EmployeeModelobj.Designation = TxtDes.Text;


            string msg = DBConnectionEmployeeDetailsobj.InsertTutorial(EmployeeModelobj);
            LabelRslt.Text = msg;
            DataTable DtResult = DBConnectionEmployeeDetailsobj.SelectTutorial();

            GridView1.DataSource = DtResult;
            GridView1.DataBind();
        }
    }
}