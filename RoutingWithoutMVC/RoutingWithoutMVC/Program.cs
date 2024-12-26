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

app.Run(); 
