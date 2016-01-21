using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace StudentsAndCourses
{
    public partial class Index : System.Web.UI.Page
    {
        protected void OnRegisterStudentButtonClicked(object sender, EventArgs e)
        {
            this.registrationForm.Visible = false;

            var nameHeader = new HtmlGenericControl("h1");
            nameHeader.InnerText = string.Format("Name: {0} {1}", this.firstNameInput.Text, this.lastNameInput.Text);

            var facultyNumberParagraph = new HtmlGenericControl("p");
            facultyNumberParagraph.InnerText = string.Format("Faculty number: {0}", this.facultyNumberInput.Text);

            var universityHeader = new HtmlGenericControl("h2");
            universityHeader.InnerText = string.Format("University: {0}", this.universityDropdown.SelectedValue);

            var specialtyHeader = new HtmlGenericControl("h3");
            specialtyHeader.InnerText = string.Format("Specialty: {0}", this.specialtyDropDown.SelectedValue);

            var courseHeader = new HtmlGenericControl("h4");
            courseHeader.InnerText = string.Format("Course: {0}", this.courseUniversity.SelectedValue);

            this.registrationInfo.Controls.Add(nameHeader);
            this.registrationInfo.Controls.Add(facultyNumberParagraph);
            this.registrationInfo.Controls.Add(universityHeader);
            this.registrationInfo.Controls.Add(specialtyHeader);
            this.registrationInfo.Controls.Add(courseHeader);
        }
    }
}