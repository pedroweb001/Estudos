using System;

namespace TodoProject.Models;

public class Todo
{

    public Guid Id { get; set; }
    public bool Done { get; set; }
    public string Title { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }

}