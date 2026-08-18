using System;
using System.Web.UI;

namespace Practical_04
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode =
                System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            string department = RadioButtonList1.SelectedValue;

            string gender = RadioButtonList2.SelectedValue;

            string skills = "";

            if (CheckBox1.Checked)
            {
                skills += "C# ";
            }

            if (CheckBox2.Checked)
            {
                skills += "Python ";
            }

            if (CheckBox3.Checked)
            {
                skills += "AI ";
            }

            string terms = "Accepted";

            Label11.Text =
                "<b>Submitted Details</b><br/><br/>" +
                "Full Name: " + TextBox1.Text + "<br/>" +
                "Email Id: " + TextBox2.Text + "<br/>" +
                "Contact No: " + TextBox3.Text + "<br/>" +
                "College: " + TextBox4.Text + "<br/>" +
                "Department: " + department + "<br/>" +
                "Event: " + DropDownList1.SelectedValue + "<br/>" +
                "Gender: " + gender + "<br/>" +
                "Skills: " + skills + "<br/>" +
                "Address: " + TextBox5.Text + "<br/>" +
                "Terms: " + terms;
        }
    }
}