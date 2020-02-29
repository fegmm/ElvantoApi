using System;
using System.Collections.Generic;
using System.Text;

namespace ElvantoApi.Models
{

    public class ServicesGetAllResponse
    {
        public string generated_in { get; set; }
        public string status { get; set; }
        public Services services { get; set; }
    }

    public class ServiceGetDetailsResponse
    {
        public string generated_in { get; set; }
        public string status { get; set; }
        public Service[] service { get; set; }
    }

    public class Services
    {
        public int on_this_page { get; set; }
        public string page { get; set; }
        public string per_page { get; set; }
        public int total { get; set; }
        public Service[] service { get; set; }
    }

    public class Service
    {
        public string id { get; set; }
        public int status { get; set; }
        public string date_added { get; set; }
        public string date_modified { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string series_name { get; set; }
        public Service_Type service_type { get; set; }
        public string picture { get; set; }
        public Location location { get; set; }
        public Service_Times service_times { get; set; }
        public Plans plans { get; set; }
        public Volunteers volunteers { get; set; }
        public Notes notes { get; set; }
        public Songs songs { get; set; }
        public Files files { get; set; }
    }

    public class Location
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Service_Times
    {
        public Service_Time[] service_time { get; set; }
    }

    public class Service_Time
    {
        public string id { get; set; }
        public string date_added { get; set; }
        public string date_modified { get; set; }
        public string name { get; set; }
        public string starts { get; set; }
        public string ends { get; set; }
    }

    public class Plans
    {
        public Plan[] plan { get; set; }
    }

    public class Plan
    {
        public string time_id { get; set; }
        public int service_length { get; set; }
        public string service_length_formatted { get; set; }
        public int total_length { get; set; }
        public string total_length_formatted { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public Item[] item { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public int heading { get; set; }
        public string duration { get; set; }
        public string title { get; set; }
        public object song { get; set; }
        public string description { get; set; }
    }

    public class Volunteers
    {
        public Plan1[] plan { get; set; }
    }

    public class Plan1
    {
        public string time_id { get; set; }
        public Service_Positions positions { get; set; }
    }

    public class Service_Positions
    {
        public Service_Position[] position { get; set; }
    }

    public class Service_Position
    {
        public string department_name { get; set; }
        public string sub_department_name { get; set; }
        public string position_name { get; set; }
        public Volunteers1 volunteers { get; set; }
        public string department_id { get; set; }
        public string sub_department_id { get; set; }
        public string position_id { get; set; }
    }

    public class Volunteers1
    {
        public Volunteer[] volunteer { get; set; }
    }

    public class Volunteer
    {
        public Service_Person person { get; set; }
        public string status { get; set; }
    }

    public class Service_Person
    {
        public string id { get; set; }
        public string firstname { get; set; }
        public string preferred_name { get; set; }
        public string middle_name { get; set; }
        public string lastname { get; set; }
    }

    public class Notes
    {
        public Note[] note { get; set; }
    }

    public class Note
    {
        public string id { get; set; }
        public string date_added { get; set; }
        public string date_modified { get; set; }
        public string note { get; set; }
    }

    public class Songs
    {
        public Song[] song { get; set; }
    }

    public class Song
    {
        public string id { get; set; }
        public string ccli_number { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string album { get; set; }
        public Arrangement arrangement { get; set; }
    }

    public class Arrangement
    {
        public string id { get; set; }
        public string title { get; set; }
        public string bpm { get; set; }
        public string duration { get; set; }
        public string[] sequence { get; set; }
        public string key_id { get; set; }
        public string key_name { get; set; }
        public string key { get; set; }
    }

    public class Files
    {
        public File[] file { get; set; }
    }

    public class File
    {
        public string id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public int html { get; set; }
        public string content { get; set; }
    }

}
