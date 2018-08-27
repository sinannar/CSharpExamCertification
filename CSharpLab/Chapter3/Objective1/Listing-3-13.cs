using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Data.Entity;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace CSharpLab.Chapter3.Objective1
{
    public static class Listing_3_13
    {
        // Valid zipcodes: 1234AB | 1234 AB | 1001 AB
        public static void RunMain()
        {
            var json = "{\"employees\":[{\"firstName\":\"John\", \"lastName\":\"Doe\"}, {\"firstName\":\"Anna\", \"lastName\":\"Smith\"},{\"firstName\":\"Peter\", \"lastName\":\"Jones\"}]}";
            Console.WriteLine("Testing with IsJson() if {0}", json);
            Console.WriteLine("");
            Console.WriteLine("Result: {0}", IsJson(json));

            var result = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            Console.WriteLine("JavaScriptSerializer.Deserialize was successful");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static bool IsJson(string input)
        {
            input = input.Trim();
            return (input.StartsWith("{") && input.EndsWith("}")) || (input.StartsWith("[") && input.EndsWith("]"));
        }
    }
}
