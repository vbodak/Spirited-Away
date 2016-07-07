using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace web.Helper
{
    public class Helper
    {
        readonly string uri = ConfigurationManager.AppSettings["API"];

        public async Task<MovieDetails> GetMovieAsync(string name)
        {

            using (HttpClient httpClient = new HttpClient())
            {
                JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                var res = await httpClient.GetStringAsync(uri + "?name=" + name);
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var jsonString = serializer.Deserialize<string>(res);
                MovieDetails data = JsonConvert.DeserializeObject<MovieDetails>(jsonString);

                return data;
            }
        }
    }
}