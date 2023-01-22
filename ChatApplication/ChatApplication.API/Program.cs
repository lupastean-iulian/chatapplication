using ChatApplication.API.Extensions;
using ChatApplication.Application.Extensions;
using ChatApplication.Dal.Extensions;
using System.Reflection;
using WebApplication = Microsoft.AspNetCore.Builder.WebApplication;
var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureAuthentication(builder.Configuration);
// Add services to the container.
builder.Services.AddRouting(configuration => configuration.LowercaseUrls = true);

//Data Access Layer
builder.Services.AddDal(builder.Configuration);

builder.Services.ConfigureSwagger();

builder.Services.AddControllers();

//Add application
builder.Services.AddApplication();

//Add automapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseCors();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
