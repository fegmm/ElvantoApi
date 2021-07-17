namespace ElvantoSync.ElvantoApi.Models
{
    public class PeopleGetAllResponse : Response
    {
        public People People { get; set; }
    }

    public class People : PagedResult
    {
        public Person[] Person { get; set; }
    }

    public class Person
    {
        public string Date_added { get; set; }
        public string Date_modified { get; set; }
        public string Firstname { get; set; }
        public string Preferred_name { get; set; }
        public string Middle_name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Status { get; set; }
        public string Username { get; set; }
        public string Last_login { get; set; }
        public string Country { get; set; }
        public string Timezone { get; set; }
        public string Picture { get; set; }
        public string Family_relationship { get; set; }
        public string Id { get; set; }
        public string Category_id { get; set; }
        public int Admin { get; set; }
        public int Contact { get; set; }
        public int Archived { get; set; }
        public int Deceased { get; set; }
        public int Volunteer { get; set; }
        public string Family_id { get; set; }
        public Access_Permissions Access_permissions { get; set; }
        public Departments Departments { get; set; }
        public Service_Types Service_types { get; set; }
        public Demographics Demographics { get; set; }
        public Locations Locations { get; set; }
        public Family Family { get; set; }
        public string Anniversary { get; set; }
        public string Birthday { get; set; }
        public string Development_child { get; set; }
        public string Gender { get; set; }
        public string Giving_number { get; set; }
        public string Home_address { get; set; }
        public string Home_address2 { get; set; }
        public string Home_city { get; set; }
        public string Home_country { get; set; }
        public string Home_postcode { get; set; }
        public string Home_state { get; set; }
        public string Mailing_address { get; set; }
        public string Mailing_address2 { get; set; }
        public string Mailing_city { get; set; }
        public string Mailing_country { get; set; }
        public string Mailing_postcode { get; set; }
        public string Mailing_state { get; set; }
        public string Marital_status { get; set; }
        public string Receipt_name { get; set; }
        public PersonReference Reports_to { get; set; }
        public string School_grade { get; set; }
        public string Security_code { get; set; }
        public string Special_needs_child { get; set; }
    }

    public class PersonReference
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Access_Permissions
    {
        public Access_Permission[] Access_permission { get; set; }
    }

    public class Access_Permission
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Departments
    {
        public Department[] Department { get; set; }
    }

    public class Department
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Sub_Departments Sub_departments { get; set; }
    }

    public class Sub_Departments
    {
        public Sub_Department[] Sub_department { get; set; }
    }

    public class Sub_Department
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Positions Positions { get; set; }
    }

    public class Positions
    {
        public Position[] Position { get; set; }
    }

    public class Position
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Service_Types
    {
        public Service_Type[] Service_type { get; set; }
    }

    public class Service_Type
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Demographics
    {
        public Demographic[] Demographic { get; set; }
    }

    public class Demographic
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Sub_Demographics Sub_demographics { get; set; }
    }

    public class Sub_Demographics
    {
        public Sub_Demographic[] Sub_demographic { get; set; }
    }

    public class Sub_Demographic
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Locations
    {
    }

    public class Family
    {
        public string Family_id { get; set; }
        public Family_Member[] Family_member { get; set; }
    }

    public class Family_Member
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Relationship { get; set; }
    }
}