using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var Patient = new List<PatientsDateOfBirth>
            {
                new PatientsDateOfBirth("Ivan", new Date(01,01,1998)),
                new PatientsDateOfBirth("Nikita", new Date(01,05,1998)),
                new PatientsDateOfBirth("Roman", new Date(01,08,1998)),
                new PatientsDateOfBirth("Maks", new Date(01,07,1998)),
                new PatientsDateOfBirth("Churka", new Date(01,04,1998))
            };

            var List = Patient.Where(u => u.date.year > 1990 && u.date.year < 2005 && u.date.month > 02 && u.date.month < 6).ToList();
            List.ForEach(u => label1.Text +=" "+u.Name + u.date.year.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var Patient = new List<PatientsDateOfBirth>
            {
                new PatientsDateOfBirth("Ivan", new Date(01,01,1998)),
                new PatientsDateOfBirth("Nikita", new Date(01,05,1998)),
                new PatientsDateOfBirth("Roman", new Date(01,08,1998)),
                new PatientsDateOfBirth("Maks", new Date(01,07,1998)),
                new PatientsDateOfBirth("Churka", new Date(01,04,1998))
            };
            var List = Patient.Where(u => u.date.month > 05 && u.date.month < 9).ToList();
            List.ForEach(u => label2.Text +=" "+u.Name + u.date.day.ToString()+ "." + u.date.month.ToString()+ "." + u.date.year.ToString());
        }
    }
}
