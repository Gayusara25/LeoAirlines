//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeoAirlines.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class airportinfo
    {
        public string IATACODE { get; set; }
        public string AIRPORTNAME { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string COUNTRY { get; set; }
        public double LAT { get; set; }
        public double LONG { get; set; }
    
        public virtual cityinfo cityinfo { get; set; }
    }
}
