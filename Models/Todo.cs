namespace TWTodoList.Models;

public class Todo
{
    public int Id {get; set;}
    public string Title {get; set;} 
    public DateTime Date {get; set;}
    public bool isCompleted {get; set;}

    public Todo(string title, DateTime date, bool isCompleted = false)
    {
        Title = title;
        Date = date;
        this.isCompleted = isCompleted;
    }

    public Todo(int id, string title, DateTime date, bool isCompleted = false)
    {
        Id = id;
        Title = title;
        Date = date;
        this.isCompleted = isCompleted;
    }


 }
