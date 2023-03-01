var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


string[] Words = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
Random rnd = new Random();
int num = rnd.Next(1, 10);

string random = Words[num]; 

app.MapGet("All", (Func<string>)(() => "10 9 8 7 6 5 4 3 2 1"));
app.MapGet("Single", (Func<string>)(() => random));
app.MapGet("Sorted", (Func<string>)(() => "1 2 3 4 5 6 7 8 9 10"));




app.Run();


