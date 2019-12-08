﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotNetFrameworkMVC_MoshProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribed { get; set; }
        public Membership Membership { get; set; }
        public byte MembershipId { get; set; }
    }
}