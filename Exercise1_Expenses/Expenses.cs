using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Expenses
{
    class Expenses
    {

        public string Category { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateOccured { get; set; }

        public Expenses()
        {

        }

        public Expenses(string category, decimal cost, DateTime dateOccured)
        {
            Category = category;
            Cost = cost;
            DateOccured = dateOccured;
        }

        public override string ToString()
        {
            return $"{Category} for {Cost:C} on {DateOccured.ToShortDateString()} ";
        }

    }
}
