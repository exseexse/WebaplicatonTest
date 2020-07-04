using System;
using System.Collections.Generic;

namespace ClassLibraryUsed
{
    public class EmployeeDetails
    {
        public int id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public double salary
        {
            get;
            set;
        }
        public string Geneder
        {
            get;
            set;
        }
    }
    public class EmployeeTest
    {
        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Userid or password could not be Empty.";
            }
            else
            {
                if (UserId == "Admin" && Password == "Admin")
                {
                    return "Welcome Admin.";
                }
                return "Incorrect UserId or Password.";
            }
        }
        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails
            {
                id = 100,
                Name = "Bharat",
                Geneder = "male",
                salary = 40000
            });
            li.Add(new EmployeeDetails
            {
                id = 101,
                Name = "sunita",
                Geneder = "Female",
                salary = 50000
            });
            li.Add(new EmployeeDetails
            {
                id = 103,
                Name = "Karan",
                Geneder = "male",
                salary = 40000
            });
            li.Add(new EmployeeDetails
            {
                id = 104,
                Name = "Jeetu",
                Geneder = "male",
                salary = 23000
            });
            li.Add(new EmployeeDetails
            {
                id = 105,
                Name = "Manasi",
                Geneder = "Female",
                salary = 80000
            });
            li.Add(new EmployeeDetails
            {
                id = 106,
                Name = "Ranjit",
                Geneder = "male",
                salary = 670000
            });
            return li;
        }

    }
}
