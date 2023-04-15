using Challange_APP;

Employee employee1 = new Employee("Mateusz", "Nowak", 26);
Employee employee2 = new Employee("Kuba", "Lizak", 34);
Employee employee3 = new Employee("Dawid", "Cukierek", 29);

employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(1);
employee1.AddScore(6);
employee1.AddScore(9);

employee2.AddScore(1);
employee2.AddScore(4);
employee2.AddScore(7);
employee2.AddScore(9);
employee2.AddScore(8);

employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(9);
employee3.AddScore(6);
employee3.AddScore(7);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeswithmaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeswithmaxResult = employee;
    }

}
Console.WriteLine("Najwięcej punktów zdobył");
Console.WriteLine(employeeswithmaxResult.name + " " + employeeswithmaxResult.surname + " " + employeeswithmaxResult.age);
Console.WriteLine("równą " + employeeswithmaxResult.Result);





