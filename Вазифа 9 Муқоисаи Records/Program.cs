//true
var emp1 = new Employee("Ahmad", 30);
var emp2 = new Employee("Ahmad", 30);
System.Console.WriteLine(emp1 == emp2);
public record Employee(string Name, int Age);