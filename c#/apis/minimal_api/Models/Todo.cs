public class Todo
{
    public Todo(Guid Id, bool done, string Title)
    {
        this.Id = Id;
        this.Done = done;
        this.Title = Title;
    }

    public Guid Id { get; set; }
    public bool Done { get; set; }
    public string Title { get; set; }

}