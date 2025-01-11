

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //this service is required to perform routing required in both routing types
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute();   // this is default route having convension {conroller=Home}/{action=Index}/{id?}

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=About}/{id?}"
//    );

//This middeleware is must to implement attribute-based routing in application
app.MapControllers();



/*

// Map Methods
using System.Net.Security;

var builder = WebApplication.CreateBuilder(args);
var app=builder.Build();

//When we want to implement logic that is of multiple lines then we don't prefer this way 

//app.Map("/", () => "Hello World");
//app.MapGet("/", () => "Hello World - GET");
//app.MapPost("/", () => "Hello World - POST");
//app.MapPut("/", () => "Hello World - PUT");
//app.MapDelete("/", () => "Hello World - DELETE");

//Best Approach
*/
app.Run(); 
