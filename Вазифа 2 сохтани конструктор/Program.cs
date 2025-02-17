Car car1 = new Car("Toyota", "Corolla", 2020);
car1.displayDetails();

Car car2 = new Car("Honda", "Civic", 2018);
car2.displayDetails();
public class Car
{
    private string Make; //IVAZ KARDAM BA 'PRIVATE'
    private string Model; //...
    private int Year; //...
    public Car(string name, string model, int year)
    {
        Make = name;
        Model = model;
        Year = year;
    }
    public void displayDetails()
    {
        System.Console.WriteLine($"{Make} {Model}, {Year}");
    }
}
