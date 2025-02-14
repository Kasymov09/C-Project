class Library
{
    private List<Book> books = new List<Book>();    
    public void AddBook(Book book)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Title == book.Title && books[i].Author == book.Author)
            {
                books[i].Quantity += book.Quantity; // Increase quantity
                Console.WriteLine($"Increased quantity of {book.Title} to {books[i].Quantity}");
                return; // Exit after updating
            }
            
        }
        books.Add(book);
    }
    
    public void RemoveBook(string title)
    {
        for(int i = 0; i<books.Count; i++)
        {
            if(books[i].Title == title)
            {
                books[i].Quantity -= 1;  
                Console.WriteLine($"Decreased quantity of {title} to {books[i].Quantity}"); 
            }
  
            if(books[i].Quantity <= 0)
            {
                books.Remove(books[i]);
                break;
            }
            }
        }
    
    public void ListBooks()
    {
        System.Console.WriteLine("-----------------------Books in Library-----------------------");
        for(int i = books.Count-1; i>=0; i--)
        {
            for(int j = books.Count-1; j>=0; j--)
            {
                if(i == j)
                {
                    continue;
                }
                if(books[i] != books[j])
                {
                    System.Console.WriteLine($"{books[i].Title} by {books[i].Author}, {books[i].Pages} pages (Copies: {books[i].Quantity})");
                    break;
            }
        }
    }
    System.Console.WriteLine("-----------------------------------------------------");
    }

    public void CountBooksByTitle(string title)
    {
        for(int i = books.Count-1; i>=0; i--)
        {
                if(books[i].Title == title)
                {
                    System.Console.WriteLine($"'{title}' quantity is {books[i].Quantity}"); 
                }
        }
    }

    public void SearchBook(string keyword)
    {
        for(int i = 0; i < books.Count; i++)
        {
            if(keyword == books[i].Title || keyword == books[i].Author)
            {
                System.Console.WriteLine($"{books[i].Title} by {books[i].Author}, {books[i].Pages} pages (Copies: {books[i].Quantity})");
                    return;
            }
        }
        System.Console.WriteLine("No more in Library");
    }
}
