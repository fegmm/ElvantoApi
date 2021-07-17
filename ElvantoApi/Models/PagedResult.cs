using System;
using System.Collections.Generic;
using System.Text;

namespace ElvantoSync.ElvantoApi.Models
{
    public class PagedResult
    {
        public int On_this_page { get; set; }
        public int Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
    }
}
