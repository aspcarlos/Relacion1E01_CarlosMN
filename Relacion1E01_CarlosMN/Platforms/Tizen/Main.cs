using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Relacion1E01_CarlosMN
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
