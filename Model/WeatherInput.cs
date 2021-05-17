using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWS_Service.Model
{
//    public class WeatherInput
//    {
//        public string CityName { get; set; }
//        //public string AppId { get; set; }
//        //public string APIKey { get; set; }
//    }

    public class Data
    {
        public string CityName { get; set; }
    }

    public class WeatherInput
{
        public int id { get; set; }
        public Data data { get; set; }
    }
}
