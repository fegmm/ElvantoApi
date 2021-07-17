using System;
using System.Collections.Generic;
using System.Text;

namespace ElvantoSync.ElvantoApi.Models
{
    public class GetAllPeopleRequest : GetAllRequest
    {
        public string Contact { get; set; }
        public string Archived { get; set; }
        public string Suspended { get; set; }

        public GetAllPeopleRequest()
        {
            Contact = Archived = Suspended = "no";
        }
    }
}
