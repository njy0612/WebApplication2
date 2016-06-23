using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace WebApplication2.webPages
{
    public partial class myFirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Request.Params.ToString());
            string str = Request.Params["time"];
            Response.Write("success");
            // .net 的机制是整个生成html代码作为回传
            // 所以在pageload中没有实现ajax的意义
            ////string action = Request.QueryString["action"];
            Response.Clear(); //清除所有之前生成的Response内容
            //if (!string.IsNullOrEmpty(action))
            //{
            //    switch (action)
            //    {
            //        case "getTime":
            //            Response.Write(GetTime());
            //            break;
            //        case "getDate":
            //            Response.Write(GetDate());
            //            break;
            //    }
            //}
            Response.Write(DateTime.Now.ToString()+"   "+str);
            Response.End(); //停止Response后续写入动作，保证Response内只有我们写入内容
            
        }


        private string GetDate()
        {
            return DateTime.Now.ToShortDateString();
        }

        private string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}