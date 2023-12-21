class Book{
    public string Title;
    public string Author;
    public int Year;

    public Book(string title, string author, int year){
        this.Title = title;
        this.Author = author;
        this.Year = year;
    }
    public string GetInfo(){
        return $"{Title} {Author} {Year}";
    }
    public bool IsPublishedRecently()
    {
       if(Year > 2010)
       System.Console.WriteLine(true);
       else System.Console.WriteLine(false);
    }
   
}