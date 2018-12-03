namespace create_queue
{
    using Azure.Data.Wrappers;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Creating Queue: {args[0]}");
            
            var q = new StorageQueue(args[0]);
            var result = q.Create().Result;

            Console.WriteLine($"Queue ({args[0]}) create: {result}.");
        }
    }
}