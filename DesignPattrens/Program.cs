class Program
{
    static void Main(string[] args)
    {
        string FirstName = "John", LastName = "Kenedy";
        //var employeeId = $@"{FirstName[..4]}{LastName[..4]}
        //                    {DateTime.Now.Ticks.ToString().Substring(0, 4)}";
        var employeeId = GenerateEmployeeId(FirstName,LastName);
        Console.WriteLine("Your Employee Id is : {0}", employeeId);
        
    }
    // DRY - DON'T REPEAT YOURSELF
    // Created a discrete and independant method
    private static string GenerateEmployeeId(string FirstName, string LastName)
    {
        return $@"{FirstName[..4]}{LastName[..4]}{DateTime.Now.Ticks.ToString().Substring(0, 4)}"; 
    }
}