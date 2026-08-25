using System;
using System.Web.UI;

namespace Practical_5
{
    public partial class Calender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateTime sltd = Calendar1.SelectedDate;

                lblselectedDt.Text = "Selected Date: " +
                                     sltd.ToString("dd-MM-yyyy");
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime sltd = Calendar1.SelectedDate;

            lblselectedDt.Text = "Selected Date: " +
                                 sltd.ToString("dd-MM-yyyy");
        }

        protected void btnApplyLeave_Click(object sender, EventArgs e)
        {
            DateTime sltd = Calendar1.SelectedDate;

            Session["leavedate"] = sltd;

            Response.Redirect("LeaveApply.aspx");
        }
    }
}