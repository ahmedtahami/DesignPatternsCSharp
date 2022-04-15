using DesignPatterns.Helpers;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string FirstName = "", LastName = "Keenedy";
            EmployeeProcessor employeeProcessor = new EmployeeProcessor(FirstName, LastName);
            if (!String.IsNullOrWhiteSpace(employeeProcessor.EmployeeId))
                Console.WriteLine("Your Employee Id is : {0}", employeeProcessor.EmployeeId);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}