using ChallengeCompasso.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ChallengeCompasso.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CepController : ControllerBase
    {
        public List<CepModel> cepData { get; set; } = new List<CepModel>();

        [HttpGet]
        public List<CepModel> GetCep(string cep)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($"https://viacep.com.br/ws/{cep}/json/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "request";

                var responseString = "";

                using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseString = reader.ReadToEnd();
                }

                var jsonConvert = JsonConvert.DeserializeObject<CepModel>(responseString);
                cepData.Add(jsonConvert);

            }
            catch (Exception e)
            {

                throw e;
            }
            
            return cepData;
        }
    }
}
