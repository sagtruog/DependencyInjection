namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBusinessLogic testBN = new EmployeeBusinessLogic();

            Console.WriteLine("What is your id?");
            int id = Convert.ToInt32(Console.ReadLine());
            var result = testBN.GetEmployeeDetails(id);
            Console.WriteLine($"{result.Department}-{result.Department}-{result.Name}-{result.ID}-{result.Salary}");
            Console.ReadKey(true);
        }
    }
}
