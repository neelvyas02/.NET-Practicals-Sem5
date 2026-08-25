using System;
using System.Web.UI;

namespace Practical_5
{
    public partial class LeaveApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["empname"] != null)
                {
                    txtEmployeeName.Text = Request.Cookies["empname"].Value;
                }

                if (Session["leavedate"] != null)
                {
                    DateTime sltd = (DateTime)Session["leavedate"];

                    lblLeaveDate.Text = sltd.ToString("dd-MM-yyyy");
                }
                else
                {
                    lblLeaveDate.Text = "No leave date selected.";
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string ename = txtEmployeeName.Text;
            string leavetp = ddlLeaveType.SelectedValue;
            string reason = txtReason.Text;

            Session["empname"] = ename;
            Session["leavetype"] = leavetp;
            Session["Reason"] = reason;

            if (chkRememberName.Checked)
            {
                Response.Cookies["empname"].Value = ename;
                Response.Cookies["empname"].Expires = DateTime.Now.AddDays(7);
            }

            lblMessage.Text = "Employee Name: " + ename +
                              "<br/>Leave Type: " + leavetp +
                              "<br/>Reason: " + reason +
                              "<br/><br/>You have submitted your leave application.";
        }
    }
}