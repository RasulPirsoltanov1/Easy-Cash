﻿using EasyCashIdentityProject.EntityLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount:BaseEntity
    {
        public string AccountNumber { get; set; }
        public string Currency { get; set; }
        public decimal Balance{ get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
