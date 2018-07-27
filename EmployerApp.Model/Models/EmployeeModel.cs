using System;
using System.Collections.Generic;
using System.Text;

namespace EmployerApp.Model.Models
{
    public class EmployeeModel
    {
        public string IdentificationNumber { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public decimal WageMonthly { get; set; }

        public decimal WageDaily { get; set; }

        public decimal WageShift { get; set; }
    }
}
