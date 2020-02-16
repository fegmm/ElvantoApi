using System;
using System.Collections.Generic;
using System.Text;

namespace ElvantoApi.Models
{

    public class Groups : PagedResult
    {
        public Group[] Group { get; set; }
    }

    public class Group
    {
        public string Date_added { get; set; }
        public string Date_modified { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Meeting_address { get; set; }
        public string Meeting_city { get; set; }
        public string Meeting_state { get; set; }
        public string Meeting_postcode { get; set; }
        public string Meeting_country { get; set; }
        public string Meeting_day { get; set; }
        public string Meeting_time { get; set; }
        public string Meeting_frequency { get; set; }
        public string Picture { get; set; }
        public string Id { get; set; }
        public GroupMembers People { get; set; }
        public Categories Categories { get; set; }
        public Departments Departments { get; set; }
        public Demographics Demographics { get; set; }
        public Locations Locations { get; set; }
    }

    public class GroupMembers
    {
        public GroupMember[] Person { get; set; }
    }

    public class GroupMember
    {
        public string Firstname { get; set; }
        public string Preferred_name { get; set; }
        public string Middle_name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        public string Position { get; set; }
        public string Id { get; set; }
    }


    public class Categories
    {
        public Category[] Category { get; set; }
    }

    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
