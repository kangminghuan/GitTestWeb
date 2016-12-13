using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitTestWeb
{
    public partial class TestProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Project project = new Project()
            {
                Id = 1,
                Name = "不凡帝"
            };

            ProjectForm form1 = new ProjectForm()
            {
                DisableDate = DateTime.Now.AddYears(5),
                EnableDate = DateTime.Now,
                Id = 1,
                Name = "必备分销品"
            };

            ProjectForm form2 = new ProjectForm()
            {
                DisableDate = DateTime.Now.AddYears(5),
                EnableDate = DateTime.Now,
                Id = 1,
                Name = "断缺货"
            };


            project.Forms = new ProjectForm[] { form1, form2 };

            var line1 = new FormLine()
            {
                Id = 1,
                Name = "比巴卜",
            };

            form1.FormLines = new FormLine[] { line1 };

            var control1 = new FormControl
            {
                Id = 1,
                Name = "数量"
            };

            var control2 = new FormControl
            {
                Id = 2,
                Name = "照片"
            };



            line1.Controls = new FormControl[] { control1, control2 };


         

        }
    }
}