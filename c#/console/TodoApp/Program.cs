using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TodoApp.data;
using TodoApp.models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoContext>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<TodoContext>();
    context.Database.EnsureCreated();
}

app.MapGet("/todos", async (TodoContext context) =>
{
    var todos = await context.Todos.ToListAsync();
    await context.Response.WriteAsJsonAsync(todos);
});

app.MapPost("/todos", async (Todo todo, TodoContext context) =>
{
    todo.Id = Guid.NewGuid();
    context.Todos.Add(todo);
    await context.SaveChangesAsync();
    context.Response.StatusCode = StatusCodes.Status201Created;
});

app.MapPut("/todos/{id}", async (Guid id, Todo todo, TodoContext context) =>
{
    var existingTodo = await context.Todos.FindAsync(id);
    if (existingTodo == null)
    {
        context.Response.StatusCode = StatusCodes.Status404NotFound;
        return;
    }
    existingTodo.Título = todo.Título;
    existingTodo.Concluído = todo.Concluído;
    await context.SaveChangesAsync();
});

app.MapDelete("/todos/{id}", async (Guid id, TodoContext context) =>
{
    var todo = await context.Todos.FindAsync(id);
    if (todo == null)
    {
        context.Response.StatusCode = StatusCodes.Status404NotFound;
        return;
    }
    context.Todos.Remove(todo);
    await context.SaveChangesAsync();
});

app.Run();