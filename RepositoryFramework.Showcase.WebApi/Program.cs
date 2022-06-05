using RepositoryFramework.Showcase.Domain;
using RepositoryFramework.Showcase.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRepositoryInMemoryStorage<User>()
    .PopulateWithRandomData(x => x.Email, 120, 5)
    .WithAutoIncrement(x => x.Id, 1)
    .WithPattern(x => x.Email, "[a-z]{4,10}@gmail.com")
    .WithPattern(x => x.Age, "(?:22|23|24)");
//builder.Services.AddUserStorage();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.Services.Populate();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.AddApiForRepositoryFramework();

app.Run();


//THANKS FOR WATCHING AND USING 😁