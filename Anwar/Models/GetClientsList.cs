using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anwar.Models
{
    public class GetClientsList
    {
        public int count { get; set; }
        public int num_pages { get; set; }
        public int limit { get; set; }
        public int page_number { get; set; }
        public int page_count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public string host { get; set; }
        public List<Results1> results { set; get; }
    }

    public class Results1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public string website { get; set; }
        public string ownership { get; set; }
        public string status { get; set; }
        public string category { get; set; }
        public string created_by { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public int industry_exp { get; set; }
        public int primary_business_unit { get; set; }
        public string accessible_business_units { get; set; }

    }

}