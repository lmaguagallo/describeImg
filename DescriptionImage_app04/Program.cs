using System;

namespace DescriptionImage_app04
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new System.Net.WebClient();
            var url = "https://southcentralus.api.cognitive.microsoft.com/";

            api.Headers.Add("Content-Type", "application/json");
            api.Headers.Add("Ocp-Apim-Subscription-key", "your-key");

            var qry = "maxCandidates=1&language=es";

            var img = "https://www.caracteristicas.co/wp-content/uploads/2018/08/bosque-1-e1577589217640.jpg";

            var json = "{'url':'" + img + "'}";

            url = $"{url}/vision/v3.0/describe?{qry}";

            var res = api.UploadString(url, "POST", json);
            Console.WriteLine(res);


        }
    }
}
