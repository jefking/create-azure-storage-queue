namespace Creation
{
    using System;
    using Azure.Data.Wrappers;

    public class Program
    {
        public static void Main()
        {
            var queueName = System.Environment.GetEnvironmentVariable("queue");
            var connectionString = System.Environment.GetEnvironmentVariable("connection");

            if (string.IsNullOrWhiteSpace(queueName))
            {
                Console.WriteLine("Please specify Queue Name: 'queue'.");
                return;
            }
            if (string.IsNullOrWhiteSpace(queueName))
            {
                Console.WriteLine("Please specify Connection String: 'connection'.");
                return;
            }

            Console.WriteLine($"Creating Queue: {queueName}");

            var q = new StorageQueue(queueName, connectionString);
            var result = q.CreateIfNotExists().Result;

            Console.WriteLine($"Queue ({queueName}) create: {result}.");
        }
    }
}