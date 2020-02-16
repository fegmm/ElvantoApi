using System;
using System.Collections.Generic;
using System.Text;

namespace ElvantoApi.Models
{
    public class Response
    {
        public string Generated_in { get; set; }
        public string Status { get; set; }
        public Error Error { get; set; }
    }
}
