using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp; //Installar el paquete nuget


/// <summary>
/// Ejemplos adaptados de la siguiente página:
/// https://code-maze.com/different-ways-consume-restful-api-csharp/
/// 
/// </summary>
namespace consumeAPI
{
    class Program
    {
       private static string token1 = "Wch7grL6QHkIg3rJZkMseOXasrQTHW60FUJO0wNE";
       private static string token2 = "GLfgzX7Fbh7Dfb4WCgmurBc2UiDnEugkH3NvkGRE";
       private static string url = "http://api.beepquest.com/v1/question-module-answers";
       private static string initialDate = "2018-01-01T15:53:00";
       private static string limit = "100";
       private static string users = "ivan@beepquest.com,fernando@hellodave.mx";
       private static string urlParameters = "?initialDate=2018-01-01T15:53:00&limit=100";
        static void Main(string[] args)
        {
            GET_EXAMPLE_HttpWebRequest();
            GET_EXAMPLE_WebClient();
            GET_EXAMPLE_HttpClient();
            GET_EXAMPLE_RestSharp();

            Console.ReadLine();
        }
        
     
        /// <summary>
        /// HttpWebRequest/Response Class
        /// </summary>
        static void GET_EXAMPLE_HttpWebRequest()
        {
            Console.WriteLine("GET_EXAMPLE_HttpWebRequest: question-module-answers \r\n");
            
            try
            {
                
                var request = (HttpWebRequest)WebRequest.Create(url + urlParameters);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Headers.Add("BQAPPTOK", token1);
                request.Headers.Add("BQMODTOK", token2);
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;


                var response = (HttpWebResponse)request.GetResponse();

                string jsonContent = string.Empty;
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        jsonContent = sr.ReadToEnd();
                    }
                }

                Console.WriteLine("Response: " + jsonContent);

            }

            catch (Exception e)
            {
                Console.Out.WriteLine("--------ERROR---------");
                Console.Out.WriteLine(e.Message);
            }
        }
        
        /// <summary>
        /// WebClient Class
        /// </summary>
        static void GET_EXAMPLE_WebClient()
        {

            Console.WriteLine("\r\n\r\nGET_EXAMPLE_WebClient: question-module-answers\r\n");

            try
            {
                var webClient = new WebClient();
                webClient.QueryString.Add("initialDate", initialDate);
                webClient.QueryString.Add("limit", limit);
                webClient.Headers.Add("Content-Type", "application/json");
                webClient.Headers.Add("BQAPPTOK", token1);
                webClient.Headers.Add("BQMODTOK", token2);

                var response = webClient.DownloadString(url);
                Console.WriteLine("Response: " + response);
            }

            catch (Exception e)
            {
                Console.Out.WriteLine("--------ERROR---------");
                Console.Out.WriteLine(e.Message);
            }
        }

        
        ///// <summary>
        ///// HttpClient Class
        ///// </summary>
        static void GET_EXAMPLE_HttpClient()
        {

            Console.WriteLine("\r\n\r\nGET_EXAMPLE_HttpClient: question-module-answers\r\n");
            try
            {

                using (var httpClient = new HttpClient())
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    httpClient.DefaultRequestHeaders.Add("BQAPPTOK", token1);
                    httpClient.DefaultRequestHeaders.Add("BQMODTOK", token2);
                    var response = httpClient.GetStringAsync(new Uri(url + urlParameters)).Result;

                    Console.Out.WriteLine("Response: " + response);
                }

            }

            catch (Exception e)
            {
                Console.Out.WriteLine("--------ERROR---------");
                Console.Out.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// RestSharp
        /// </summary>
        static void GET_EXAMPLE_RestSharp()
        {

            try
            {

                Console.WriteLine("\r\n\r\nGET_EXAMPLE_RestSharp: question-module-answers \r\n");
                var client = new RestClient(url);
                var requestAPI = new RestRequest();

                requestAPI.AddParameter("initialDate", initialDate);
                requestAPI.AddParameter("limit", limit);
                requestAPI.AddHeader("BQAPPTOK", token1);
                requestAPI.AddHeader("BQMODTOK", token2);
                IRestResponse response = client.Execute(requestAPI);

                var jsonContent = response.Content;

                Console.WriteLine("Response: " + jsonContent);

            }

            catch (Exception e)
            {
                Console.Out.WriteLine("--------ERROR---------");
                Console.Out.WriteLine(e.Message);
            }
        }

    }
}