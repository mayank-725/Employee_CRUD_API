using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurementBackendProject
{
    public class MessagingQueue
    {
       

        public void SendMessage(string measurementType, decimal value)
        {
            MessageQueue messageQueue = null;
            string description = measurementType;
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
                string result = measurementType + value;
                messageQueue.Send(result, description);
                //return result;
            }
            catch
            {
                throw;
            }
        }

        public void ReceiveMessage()
        {
            MessagingQueue queue = new MessagingQueue();
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
                        MyQueue.Receive();
                    }
                }
                else
                {
                    Console.WriteLine("No Message");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
