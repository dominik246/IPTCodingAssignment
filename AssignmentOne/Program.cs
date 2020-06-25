using AssignmentOne.Model;

using System;

namespace AssignmentOne
{
    class Program
    {
        /// <summary>
        /// Zadana je klasa Employee. Ako Employee ima bar jednog člana u TeamMembers to znači da je isti
        /// ujedno i voditelj.Potrebno je napisati funkciju koja će izračunati ukupnu sumu plaća voditelja i
        /// članova njegovog tima a kao ulazni parametar će uzimati voditelja, odnosno objekt tipa
        /// Employee.
        /// </summary>
        static void Main(string[] args)
        {

        }

        private decimal SalaryCalculator(Employee voditelj)
        {
            if (voditelj.TeamMembers.Count == 0)
            {
                Console.WriteLine("Nije Voditelj!");
                return 0;
            }

            decimal totalSalary = voditelj.Salary;

            foreach (Employee employee in voditelj.TeamMembers) // moze se isti rezultat dobiti s
            {                                                   // voditelj.TeamMembers.Sum(s => totalSalary += s.Salary)
                totalSalary += employee.Salary;                 // ali sporije.
            }

            return totalSalary;
        }
    }
}
