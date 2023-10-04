using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmicroserviceone.Models
{
    public class Airport
    {
        public int AirportID {get;set;}
        public string AirportName {get;set;}
        public string Location {get;set;}
        public string Country {get;set;}
        public string Website {get;set;}
        public string ContactNumber {get;set;}
        public string Email {get;set;}
        public string Description {get;set;}
    }
}