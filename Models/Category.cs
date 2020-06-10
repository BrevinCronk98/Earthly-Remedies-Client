using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EarthlyRemediesClient.Models
{
    public static class EnvironmentVariables
    {
        public static List<string> Categories = new List<string> { "GI", "respiratory", "skin", "eyes", "hair", "musculoskeletal", "endocrine", "chakra", "pineal", "lymphatic", "cardiovascular", "digestive", "nervous", "reproductive" };

        // public static List<EnvironmentVariables> GetVariables(string apiKey)
        // {
        //   var apiCallTask = ApiHelper.ApiCall(apiKey);
        //   var result = apiCallTask.Result;

        //   JObject jsonResponse = JsonConvert.DeserializedObject<JObject>(result);
        //   List<EnvironmentVariables> variableList = JsonConvert.DeserializedObject<List<EnvironmentVariables>>(jsonResponse["results"].ToString());

        //   return variableList;
        // }

    }
}