using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Helper;
using WebApplication2.Models;



namespace WebApplication2.DAO
{
    public class myObjDAO
    {
        public myObjDAO()
        {
            // make data connection

        }

        public string getMyobjJsonStr()
        {
            myModel mModel = new myModel();
            mModel.text = "hello, world";
            mModel.imgPath = "";
            return JsonHelper.JsonSeriallizer(mModel);
        }

    }
}