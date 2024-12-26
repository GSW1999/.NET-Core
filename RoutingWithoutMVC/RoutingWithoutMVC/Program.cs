var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //this service is required to perform routing
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapDefaultControllerRoute();   // this is default route having convension {conroller=Home}/{action=Index}/{id?}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run(); 
