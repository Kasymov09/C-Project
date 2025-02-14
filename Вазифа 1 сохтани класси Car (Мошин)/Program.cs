//Класси Car созед, ки тағйирёбандаҳои public make, model ва year дошта бошад. Метод displayDetails() бояд маълумоти мошинро чоп кунад.
Car car1 = new Car();
car1.make = "Toyota";
car1.model = "Corolla";
car1.year = 2020;
car1.displayDetails();

Car car2 = new Car();
car2.make = "Honda";
car2.model = "Civic";
car2.year = 2018;
car2.displayDetails();
public class Car
{
    public string make;
    public string model;
    public int year;
    public void displayDetails(){
        System.Console.WriteLine($"{make} {model}, {year}");
    }
}