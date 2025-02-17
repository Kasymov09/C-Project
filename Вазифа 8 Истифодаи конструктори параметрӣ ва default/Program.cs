Library lib1 = new Library();
Library lib2 = new Library("City Library", "Downtown");
lib1.DisplayInfo();
lib2.DisplayInfo();
public class Library
{
    string lib;
    string location;
    public Library()
    {
        lib = "Default Library";  
        location = "Default Location"; 
    }
    public Library(string nameofLibrary, string place)
    {
        lib = nameofLibrary;
        location = place;
    }
    public void DisplayInfo()
    {
        System.Console.WriteLine($"{lib}, {location}");
    }
}
//Hej chiz ivaz nakardam
