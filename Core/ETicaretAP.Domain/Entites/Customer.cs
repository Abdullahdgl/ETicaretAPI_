﻿using ETicaretAP.Domain.Entites.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAP.Domain.Entites
{
	public class Customer :BaseEntity
	{

        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
