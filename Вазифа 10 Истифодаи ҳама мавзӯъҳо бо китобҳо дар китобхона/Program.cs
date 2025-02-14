using System.Runtime.InteropServices.Marshalling;

Library library = new Library();

Book book = new Book { Title = "Тоҷикон", Author = "Бобоҷон Ғафуров", Pages = 900, Quantity = 2 };
// Илова кардани китобҳо
library.AddBook(book);
library.AddBook(new Book { Title = "Адабиёти тоҷик", Author = "Садриддин Айнӣ", Pages = 400, Quantity = 3 });
library.AddBook(new Book { Title = "Тоҷикон", Author = "Бобоҷон Ғафуров", Pages = 900, Quantity = 1 }); // Иловаи нусхаи иловагӣ

// Чопи рӯйхати китобҳо
library.ListBooks();

// Хориҷ кардани нусхаи китоб
library.RemoveBook("Тоҷикон");
// Ҳисоб кардани миқдори умумии нусхаҳои китоб
library.CountBooksByTitle("Тоҷикон");

System.Console.WriteLine("-----------------------Searched-----------------------");
library.SearchBook("Адабиёти тоҷик"); //Quantity = 3



library.RemoveBook("Адабиёти тоҷик");
library.RemoveBook("Адабиёти тоҷик");
library.RemoveBook("Адабиёти тоҷик");

System.Console.WriteLine("-----------------------Searched-----------------------");
library.SearchBook("Адабиёти тоҷик");
public class Book
{
    public string Title;
    public string Author;
    public int Pages;
    public int Quantity;
}