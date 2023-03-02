using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ6
{
    internal class PatientsDateOfBirth
    {
        public string Name;
        public Date date;

        public PatientsDateOfBirth(string Name, Date date)
        {
            this.Name = Name;
            this.date = date;
        }


        struct Date
        {
            public Date(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }

            public int day;
            public int year;
            public int month;
        }
    }
}
