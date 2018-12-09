using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLite.Models.Entities
{
    public class Meal
    {
        public int ID { get; set; }
        public int MemberId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime MealDate { get; set; }
        public decimal MealUnit { get; set; }
        public string Date { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public int IsBillGenerate { get; set; }
    }
}
