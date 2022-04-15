using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Helpers
{
    public record EmployeeProcessor
    {
        public string EmployeeId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EmployeeProcessor(string firstName, string lastName)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
                    throw new Exception("Validation Error!");
                this.EmployeeId = GenerateEmployeeId(firstName, lastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static string GenerateEmployeeId(string firstName, string lastName)
        {
            return $@"{firstName?[..(firstName.Length/2)]}{lastName[..(lastName.Length / 2)]}{DateTime.Now.Ticks.ToString().Substring(0, 4)}";
        }
    }
}
