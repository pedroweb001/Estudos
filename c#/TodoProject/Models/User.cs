using System;

namespace TodoProject.Models;
public class User       
{

 public Guid id{ get; set; }
public string name { get; set; }
 public string email { get; set; }
public string password { get; set; }
public List<Todo> Todos{ get; set; }

}