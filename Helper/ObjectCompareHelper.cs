using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace WebApplication2.Helper
{
    public class ObjectCompareHelper
    {
        public static bool compareObject(object obj1, object obj2)
        {
           
            if((obj1 == null && obj2 != null)||(obj1 != null && obj2 == null))
            {
                return false;
            }
            else if (obj1.GetType() != obj2.GetType())
            {
                return false;
            }
            else
            {
                return SerializeObject(obj1).Equals(SerializeObject(obj2));
            }
        }


        public static string SerializeObject(object obj)
        {
            if (null == obj)
                return string.Empty;
            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            StringBuilder objString = new StringBuilder();
            foreach (FieldInfo field in fields)
            {
                object value = field.GetValue(obj);     //取得字段的值
                objString.Append(field.Name + ":" + value + ";");
            }
            return objString.ToString();
        }
    }
}