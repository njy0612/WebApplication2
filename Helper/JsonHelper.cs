using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace WebApplication2.Helper
{
    
    public class JsonHelper
    {
        //>>>> datetime would have problem with json
        //>>>> transform the date time type to string of certain formate

        /// <summary>
        /// JSON序列化
        /// </summary>
        public static string JsonSeriallizer<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            // using memoryStream to avoid the leak of memory
            // >>>> to check if it could get error of out of memory
            MemoryStream ms = new MemoryStream();
            string jsonString = "";
            try
            {
                ser.WriteObject(ms, t);
                jsonString = Encoding.UTF8.GetString(ms.ToArray());
            }
            catch (Exception e)
            {

            }
            finally
            {
                ms.Close();
            }
            return jsonString;

        }


        /// <summary>
        /// JSON反序列化
        /// </summary>
        public static T JsonDeserialize<T>(string jsonString)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T obj = (T)ser.ReadObject(ms);
            return obj;
        }


    }
}