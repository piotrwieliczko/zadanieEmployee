using System.Reflection.Metadata;
using zadanieEmployee;

Employee employee1 = new Employee("Piotr", "Wieliczko", 38);
Employee employee2 = new Employee("Szymon", "Zwieliczki", 11);
Employee employee3 = new Employee("Magdalena", "Tomaszewska", 37);

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(3);
employee1.AddScore(3);

employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(3);

employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(5);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;




int firstPlace;
if ((result1 > result2) && (result1 > result3))
{
    firstPlace = result1;
    Console.WriteLine("Największą liczbę punktów zdobywa:");
    Console.WriteLine(employee1.Name + " " + employee1.Surname + ", wiek:" + employee1.Age + " lat. Uzyskany wynik: " + result1);
}
else if (result2 > result3)
{
    firstPlace = result2;
    Console.WriteLine("Największą liczbę punktów zdobywa:");
    Console.WriteLine(employee2.Name + " " + employee2.Surname + ", wiek:" + employee2.Age + " lat. Uzyskany wynik: " + result2);
}
else
{
    firstPlace = result3;
    Console.WriteLine("Największą liczbę punktów zdobywa:");
    Console.WriteLine(employee3.Name + " " + employee3.Surname + ", wiek:" + employee3.Age + " lat. Uzyskany wynik: " + result3);
}

//druga metoda - z użyciem listy

List<Employee> uemployeers = new List<Employee>()
{
    employee1, employee2, employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;


foreach(var employee in uemployeers)
{
    if(employee.Result > maxResult )
    {
        employeeWithMaxResult=employee;
    }
}

Console.WriteLine(employeeWithMaxResult.Name);


//dodatkowe (własne)
//metoda na zmianę imienia:
string oldName = employee3.Name;
employee3.changeName("Magda");
Console.WriteLine("Nastąpiła zmiana imienia z: " + oldName + ", na: " + employee3.Name + ".");