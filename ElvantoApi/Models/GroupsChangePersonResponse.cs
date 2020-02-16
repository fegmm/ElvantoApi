using System;
using System.Collections.Generic;
using System.Text;

namespace ElvantoApi.Models
{
    public class GroupsChangePersonResponse : Response
    {
        public AffectedGroupPerson Group { get; set; }
    }

    public class AffectedGroupPerson
    {
        public string Id { get; set; }
        public string Person_id { get; set; }
    }
}
