﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BikeStoresapp1.Models
{
    public partial class staffs
    {
        public staffs()
        {
            Inversemanager = new HashSet<staffs>();
            orders = new HashSet<orders>();
        }

        public int staff_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public byte active { get; set; }
        public int store_id { get; set; }
        public int? manager_id { get; set; }

        public virtual staffs manager { get; set; }
        public virtual stores store { get; set; }
        public virtual ICollection<staffs> Inversemanager { get; set; }
        public virtual ICollection<orders> orders { get; set; }
    }
}