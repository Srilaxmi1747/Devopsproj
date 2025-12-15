using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

namespace Devopsproj.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello from Devopsproj 🚀 Running on Render!");

            app.Run();
        }

        // Keeping your existing method – tests will still pass
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

