using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

// namespace ToDoList;
// To use as implicit statmenet, make the toDoList Namespace a statment by following up with a semi-colon; see above. 
//Comment out lines 8 and 9 of program.cs or completely remove brackets encapsulating class Program.
//Comment in line 5 in csproj.
namespace ToDoList 
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();

      WebApplication app = builder.Build();

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );

      app.Run();
    }
  }
}