namespace FirstCoreWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //WebApplicationOptions options = new WebApplicationOptions {
            //    WebRootPath = "MyWebRoot",
            //    Args = args,
            //    EnvironmentName = "Production"
                
            //};

            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //builder.Services.AddControllersWithViews();
            //builder.Services.AddMvc();
            //builder.Services.AddLogging();

            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.UseRouting();
            //app.UseAuthorization();
            //app.UseEndpoints(endpoints => 
            //{
            //    endpoints.MapGet("/", async context => 
            //    {
            //        await context.Response.WriteAsync("Worker Process Name = " + System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            //    });
            //});

            //app.MapGet("/", () => "Worker Process Model : " + System.Diagnostics.Process.GetCurrentProcess().ProcessName);

            //ConfigurationManager configurationManager = builder.Configuration;

            //string myCustomKeyValue = configurationManager.GetValue<string>("MyCustomKey");

            //string myCustomKeyValue2 = configurationManager["MyCustomKey"];

            //app.MapGet("/", () =>  myCustomKeyValue2);

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Middle Ware 1: Incoming Request\n");
            //    await next();
            //    await context.Response.WriteAsync("Middle Ware 1 : Outgoing response\n");
            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Middle Ware 2: Incoming Request\n");
            //    await next();
            //    await context.Response.WriteAsync("Middle Ware 2: Outgoing response\n");
            //});

            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("Middle Ware 3: Incominng request handled and response generated.\n");
            //});

            DefaultFilesOptions filesOptions = new DefaultFilesOptions();

            filesOptions.DefaultFileNames.Clear();

            filesOptions.DefaultFileNames.Add("mycustompage1.html");

            app.UseDefaultFiles(filesOptions);

            app.UseStaticFiles();

            //app.MapGet("/", () => $"Environment Name : {app.Environment.EnvironmentName}\n" +
            //                      $"Application Name : {app.Environment.ApplicationName}\n" +
            //                      $"Web Root Path : {app.Environment.WebRootPath}\n" +
            //                      $"Application Root Path: {app.Environment.ContentRootPath}");

            app.Run();
        }
    }
}