using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurementBackendProject
{
    public class MessagingQueue
    {
       

        public void SendMessage(string measurementType, decimal retrievedValue)
        {
            MessageQueue messageQueue = null;
            string type = measurementType;
            string path = @".\Private$\messageStore";

            try
            {
                if (MessageQueue.Exists(path))
                {
                    messageQueue = new MessageQueue(path);
                }
                else
                {
                    MessageQueue.Create(path);
                    messageQueue = new MessageQueue(path);
                }
                string result = measurementType +":" +retrievedValue;
                messageQueue.Send(result, type);
                
            }
            catch
            {
                throw;
            }
        }

        public void ReceiveMessage()
        {
           
            MessageQueue MyQueue = null;
            string path = @".\Private$\messageStore";
            try
            {
                MyQueue = new MessageQueue(path);
                Message[] message = MyQueue.GetAllMessages();
                if (message.Length > 0)
                {
                    foreach (Message newMessage in message)
                    {
                        newMessage.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
                        string result = newMessage.Body.ToString();
                        Console.WriteLine(result);
                        File.WriteAllText(@"C:\Users\Sagar\source\repos\work\QuantityMeasurementBackend\QuantityMeasurementBackendProject\QuantityMeasurementBackendProject\TextRecieved.txt",result);
                        MyQueue.Receive();
                    }
                }
                else
                {
                    Console.WriteLine("nothing to display");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
