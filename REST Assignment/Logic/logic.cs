using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace REST_Assignment.Logic
{
    class logic
    {

        public static RestClient client;
        public static RestRequest request;
        public static IRestResponse response;
        public static RestRequest GETrequest;
        public static IRestResponse GETresponse;

        public bool invoke()
        {
            try
            {
                client = new RestClient("https://reqres.in/api/");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Register(string id, string pword)
        {
            try
            {
                request.RequestFormat = DataFormat.Json;
                request.AddParameter("email", id);
                request.AddParameter("password", pword);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Valid()
        {
            try
            {
                response = client.Execute(request);
                var obj = JObject.Parse(response.Content);
                var token = (string)obj.SelectToken("token");
                var message = response.ErrorMessage;
                int token_id = (int)response.StatusCode;
                if (token_id == 200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;

            }
        }
        public RestRequest Post_request()
        {
            request = new RestRequest("register", Method.POST);
            return request;
        }
        public RestRequest Get_request()
        {
            GETrequest = new RestRequest("users", Method.GET);
            return GETrequest;
        }
        public bool UserList()
        {
            try
            {
                GETresponse = client.Execute(GETrequest);
                var obj1 = JObject.Parse(GETresponse.Content);
                var list = obj1.SelectToken("data");
                String response = GETresponse.Content;
                if (response != " ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
