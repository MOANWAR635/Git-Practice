using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anwar.Models
{
    public class GetApplicantsList
    {
        public int count { get; set; }
        public int num_pages { get; set; }
        public int limit { get; set; }
        public int page_number { get; set; }
        public int page_count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public string host { get; set; }
        public List<Results> results { set; get; }

    }
    public class Count
    {
        public int count { get; set; }
    }

    public class Results
    {
        public string id { get; set; }
        public string applicant_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string consultant_name { get; set; }
        public string email { get; set; }
        public string email_address_1 { get; set; }
        public string other_phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string mobile_number { get; set; }
        public string created_at { get; set; }
        public string created_by { get; set; }
        public string applicant_status { get; set; }
        public string skills { get; set; }
        public string source { get; set; }
        public string resume_path { get; set; }
        public string home_phone_number { get; set; }
        public string work_phone_number { get; set; }
        public string job_title { get; set; }

    }


}


