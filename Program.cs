using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// use dependency injection to get a MySqlConnection in minimal APIs or in controllers
// app.MapGet("/", async (MySqlConnection connection) =>
// {
//     // open and use the connection here
//     await connection.OpenAsync();
//     await using var command = connection.CreateCommand();
//     command.CommandText = "SELECT name FROM users LIMIT 1";
//     return "Hello World: " + await command.ExecuteScalarAsync();
// });



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
