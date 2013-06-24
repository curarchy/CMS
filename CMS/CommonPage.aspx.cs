using System;
using CMS.Common;
using System.IO;
using System.Web.UI;

namespace CMS
{
    public partial class CommonPage : PageBase
    {
        protected PageInfo CurrentPage { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentPage = new PageInfo()
            {
                TemplatePath = @"Default/DetailPage.ascx"
            };
        }

        protected override void Initialize()
        {
            Control userControl = null;
            if (File.Exists(Context.Server.MapPath(CurrentPage.TemplatePath)))
            {
                userControl = TemplateControl.LoadControl(CurrentPage.TemplatePath);
            }

            this.Controls.Add(userControl);
            base.Initialize();
        }
    }



    public class PageInfo
    {
        public string TemplatePath { get; set; }
    }
}