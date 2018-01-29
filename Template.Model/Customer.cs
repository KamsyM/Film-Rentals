﻿using NakedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Model
{
    public class Customer
    {
        [NakedObjectsIgnore]
        virtual public int CustomerId { get; set; }

        [Title]
        virtual public string F_name { get; set; }
        virtual public string L_name { get; set; }
        virtual public DateTime DOB { get; set; }
 

    }
}
