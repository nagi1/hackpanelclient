using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace API
{
    class ApiHandler
    {
        public string apiToken = "";
        public string appToken = "";
        public string apiUrl = "";

        public ApiHandler(string apiToken, string appToken, string apiUrl)
        {
            this.apiToken = apiToken;
            this.appToken = appToken;
            this.apiUrl = apiUrl;
        }

        public dynamic post(string url, Dictionary<string, object> data)
        {
            var restclient = new RestClient(this.apiUrl);
            RestRequest request = new RestRequest(url) { Method = Method.POST };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", this.apiToken);
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(JsonConvert.SerializeObject(data, Formatting.Indented));

            var tResponse = restclient.Execute(request);
            var responseJson = tResponse.Content;

            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson);

            var obj = JsonConvert.SerializeObject(json);

            return JObject.Parse(obj);
        }


        public dynamic get(string url)
        {
            var restclient = new RestClient(this.apiUrl);
            RestRequest request = new RestRequest(url) { Method = Method.GET };
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", this.apiToken);
            request.AddHeader("Content-type", "application/json");

            var tResponse = restclient.Execute(request);
            var responseJson = tResponse.Content;

            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseJson);

            var obj = JsonConvert.SerializeObject(json);

            return JObject.Parse(obj);
        }


     


        public dynamic getAppInfo()
        {
            return this.get("apps/" + this.appToken).data;
        }

        public Dictionary<string, object> pairAppInfo()
        {
            Dictionary<string, object> data = WindowsFormsApp2.JsonHelper.DeserializeAndFlatten(this.getAppInfo().ToString());

            data.Keys
              .Where(p => p.Contains("meta"))
              .ToList()
              .ForEach(p => data.Remove(p));
            return data;
        }

        public Dictionary<string, object> pairAllMeta()
        {
            return WindowsFormsApp2.JsonHelper.DeserializeAndFlatten(this.getAllMeta().ToString());
        }

        public JObject getAllMeta()
        {
            JArray array = this.getAppInfo().meta;

            JObject result = new JObject(
                array.Select(jt => new JProperty((string)jt["key"], jt["value"]))
            );

            return result;
        }

        public Dictionary<string, object> Login(string key, string hwid, string token)
        {
            var data = new Dictionary<string, object> 
                                              {
                                              {"hwid", hwid},
                                              {"key", key},
                                              {"access_token", token}
                                              };


           return WindowsFormsApp2.JsonHelper.DeserializeAndFlatten(this.post("keyLogin", data).ToString());


        }

        public string getMeta(JToken key)
        {
            return this.getAllMeta()[key.ToString()].ToString();
        }

        public bool checkForMeta(string key)
        {
            foreach (var meta in this.getAllMeta())
            {
                if (String.Equals(meta.Key, key))
                    return true;
            }

            return false;
        }




    }
}
