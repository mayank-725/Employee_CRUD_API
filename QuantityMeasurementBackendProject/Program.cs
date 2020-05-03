using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace QuantityMeasurementBackendProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();

            MessagingQueue queue = new MessagingQueue();
            queue.ReceiveMessage();

            /*MessageQueue messagingQueue = null;
            string path = @".\Private$\messageStore";
            try
            {
                messagingQueue = new MessageQueue(path);
                Message[] message = messagingQueue.GetAllMessages();
                if (message.Length > 0)
                {
                    foreach (Message msg in message)
                    {
                        msg.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
                        string result = msg.Body.ToString();
                        messagingQueue.Receive();
                        File.WriteAllText(@"C:\Users\Sagar\source\repos\work\QuantityMeasurementBackend\QuantityMeasurementBackendProject\QuantityMeasurementBackendProject\TextRecieved.txt", result);
                    }
                    messagingQueue.Refresh();
                }
                else
                {
                    Console.WriteLine("No Message");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

        }

        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();
    }
}
