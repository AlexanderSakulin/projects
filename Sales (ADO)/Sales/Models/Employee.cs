using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
        public int IdPosition { get; set; }
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name) &&
                    !string.IsNullOrWhiteSpace(Surname) &&
                    !string.IsNullOrWhiteSpace(Patronymic);
            }
        }
    }
}
