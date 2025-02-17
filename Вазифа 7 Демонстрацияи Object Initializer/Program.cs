Book show = new Book();
show.ShowInfo();
public class Book
{
    public string Title = "C# Basics";
    public string Author = "John Doe";
    public int Pages = 300;
    public void ShowInfo()
    {
        System.Console.WriteLine($"{Title} by {Author}, {Pages} pages");
    }
}
//Hej chiz ivaz nakardam
