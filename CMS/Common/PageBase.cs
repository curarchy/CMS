/**************************************************************
 * Copyright InfoSky Corporation. All rights reserved.
 * 
 * Author: chenhy(hychen@infosky.com.cn) 
 * Create Date: 2013 
***************************************************************/

using System.Web.UI;
namespace CMS.Common
{
    public class PageBase : Page
    {
        protected virtual void Initialize()
        {

        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            Initialize();
        }             
    }
}