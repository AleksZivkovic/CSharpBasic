using SEDC.oop.Class07.Enumerations.Enums;
using SEDC.oop.Class07.Enumerations.Models;
using System;

namespace SEDC.oop.Class07.Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator("Bob");

            admin.Role = Roles.SuperGuest;

            bool isValid = Enum.TryParse("2", out Roles role);


            Console.ReadLine();
        }
    }
}
