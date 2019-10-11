using API;
using Newtonsoft.Json.Linq;
using Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public static class JsonHelper
    {
        public static Dictionary<string, object> DeserializeAndFlatten(string json)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            JToken token = JToken.Parse(json);
            FillDictionaryFromJToken(dict, token, "");
            return dict;
        }

        private static void FillDictionaryFromJToken(Dictionary<string, object> dict, JToken token, string prefix)
        {
            switch (token.Type)
            {
                case JTokenType.Object:
                    foreach (JProperty prop in token.Children<JProperty>())
                    {
                        FillDictionaryFromJToken(dict, prop.Value, Join(prefix, prop.Name));
                    }
                    break;

                case JTokenType.Array:
                    int index = 0;
                    foreach (JToken value in token.Children())
                    {
                        FillDictionaryFromJToken(dict, value, Join(prefix, index.ToString()));
                        index++;
                    }
                    break;

                default:
                    dict.Add(prefix, ((JValue)token).Value);
                    break;
            }
        }

        private static string Join(string prefix, string name)
        {
            return (string.IsNullOrEmpty(prefix) ? name : prefix + "." + name);
        }

    }

    static class Program
    {
        public static string apiToken = "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjVhYWRhZTEzMGFlNDBkZDFjOWM3NTk3MjZhYzA2NGI2MDk5MGYxYjA0YzZlNDQwNmRhZjk1MjNlMjE0OTcwYTU2ZThkMGVkMzU5ZDYwZmFiIn0.eyJhdWQiOiIyIiwianRpIjoiNWFhZGFlMTMwYWU0MGRkMWM5Yzc1OTcyNmFjMDY0YjYwOTkwZjFiMDRjNmU0NDA2ZGFmOTUyM2UyMTQ5NzBhNTZlOGQwZWQzNTlkNjBmYWIiLCJpYXQiOjE1NzAwMzgzMzIsIm5iZiI6MTU3MDAzODMzMiwiZXhwIjoxNjAxNjYwNzMxLCJzdWIiOiIxIiwic2NvcGVzIjpbXX0.stoNU7VanFhAd2UUfEeKw81pF9BhjbeEI3r5iG9DrvRIqyO1XG63C3GjT5xkY8wziL90h9KKeseUZHgfFcxxkpzfvW-FE7-GBdt7aaqjhCFcDn7aqiikkESjOU9k-H0C_5r5eTnAa8oVJugUGpZOJwPN_dhO2FO4tVFEnAzcrwgUrx8d7pJlrVKhGrIpxNQhQVtAo8fxRgqX7zhE1R1fiu_0lU5DJUFb88_rNJmpG3Mj7nrXUfiX_jlTuniFpHmevZNu4-ktgbXp88uYip2cRE0Ko55Gqvx6Mn6HtCTixchat9Ir_KrJ-uq9Ni60fcMijlFD07BPELL5VwY-JxpWbBmalLoXfj0O9t35hsdXew0L3-hZZDqDR2au2srY3J8MeIa2awVgoLYceCM0rn9-3XxyWeRsFPa0Pml3y1nYb3jNwzYaKLGsKTB8BVz4M0z8Nkk7KzJxxk-WA1cqTrOT8PQX_rGNoUc9zG9XXfL0luSNrDgK2Jj5WCjufcrfGOYBJRXtGYOSzuomIuYgrWGF9eW4M9ly7SdZNdM0vAwm5v5CqwJhIKJ7C32Egd4ZiPNWkwEbSKc_7NBHTiF2g9Zy8srvtAc3nUQ2AB-NphjLpopbemLC8xJTHlKh8tXLDcPvfhzo2dQqGInr98JohQrMSF6uCYH5-_D5KO2fD2aGcJc";
        public static string appToken = "wBXMGfw1GSsgzpUdTSBaW55ttp7vVCZ9QVmWis6xXiVbYBEPkOILLS3zrPeU";
        public static string url = "http://localhost:8000/api";

        public static ApiHandler api = new ApiHandler(apiToken, appToken, url);

        public static IniFile config = new IniFile("config.ini");

        public static void syncConfig()
        {
            //sync all settings except meta
            Dictionary<string, object> app = api.pairAppInfo();
            Dictionary<string, object> meta = api.pairAllMeta();

            foreach (var info in app)
            {
                config.Write(Convert.ToString(info.Key), Convert.ToString(info.Value), "App");
            }

            //sync all meta
            foreach (var m in meta)
            {
                config.Write(Convert.ToString(m.Key), Convert.ToString(m.Value), "Meta");
            }

        }

        public static void syncKeyConfig(Dictionary<string, object> data)
        {
            List<string> except = new List<string> { "message", "success" };

            foreach (var info in data)
            {
                if (!except.Contains(Convert.ToString(info.Key)))
                config.Write(Convert.ToString(info.Key), Convert.ToString(info.Value), "API");
            }

        }

        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            syncConfig();
            Application.Run(new Login());
        }

        public static string getVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            return version;
        }
    }
}
