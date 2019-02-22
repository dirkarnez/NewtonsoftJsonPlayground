using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NewtonsoftJsonPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var strArr = JsonConvert.DeserializeObject<List<string>>("[\"243\", \"324\"]");
            Console.WriteLine(strArr[0]);
            Console.ReadLine();
        }
    }
}
