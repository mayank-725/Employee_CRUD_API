//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
//     Copyright © 2020
// </copyright>
// <creator name="Mayank Sachdeva"/>
//-----------------------------------------------------------------------

namespace Repository
{
    using Model;
    using Serilog;
    using System;

    /// <summary>
    /// main program class
    /// </summary>
    public class Program
    {
        /// <summary> 
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File(@"C:\Users\Dolphin\source\repos\EmployeeCRUDApp\Repository\logfile.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
            Console.WriteLine("Hello World!");
        }
    }
}
