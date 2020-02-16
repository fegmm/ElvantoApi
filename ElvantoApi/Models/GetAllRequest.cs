using System;
using System.Collections.Generic;
using System.Text;

namespace ElvantoApi.Models
{
    public class GetAllRequest
    {
        public int? Page { get; set; }
        public int? Page_size { get; set; }
        public string Category_id { get; set; }
        public string[] Fields { get; set; }
    }
}
