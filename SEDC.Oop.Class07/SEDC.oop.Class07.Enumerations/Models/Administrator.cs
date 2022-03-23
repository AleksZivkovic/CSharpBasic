using SEDC.oop.Class07.Enumerations.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.oop.Class07.Enumerations.Models
{
    public class Administrator
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Roles Role { get; set; }


        public Administrator (string name)
        {
            id = 1;
            Name = name;
            Role = Roles.Admin;
        }




    }
}
