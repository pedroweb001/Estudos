using Microsoft.EntityFrameworkCore;
using TodoProject.Data;
using TodoProject.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TodoContext>();
builder.Services.AddControllers();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.MapGet("/v1/todos", async (TodoContext context) =>
{
    var todos = await context.Todos.ToListAsync();
    return todos is not null ? Results.Ok(todos) : Results.NotFound();
});

app.MapPost("/v1/todos", async (Todo todo, TodoContext context) =>
{
    todo.Id = Guid.NewGuid();
    context.Todos.Add(todo);
    await context.SaveChangesAsync();
    return Results.Created($"/v1/todos/{todo.Id}", todo);
});

app.MapDelete("/v1/todos/{id}", async (Guid id, TodoContext context) =>
{
    var todo = await context.Todos.FindAsync(id);
    if (todo is null)
    {
        return Results.NotFound("Id não encontrado!");
    }
    context.Todos.Remove(todo);
    await context.SaveChangesAsync();
    return Results.Ok(todo);
});

app.MapPut("/v1/todos", async (Guid id, Todo updatedTodo, TodoContext context) =>
{
    var existingTodo = await context.Todos.FindAsync(id);
    if (existingTodo is null){
        return Results.NotFound("Id não encontrado.");
    }
    context.Todos.Update(updatedTodo);
    await context.SaveChangesAsync();
    return Results.Ok(updatedTodo);
});

app.Run();