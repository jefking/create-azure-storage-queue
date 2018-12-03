namespace Creation
{
    using Azure.Data.Wrappers;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Creating Queue: {args[0]}");
            
            var q = new StorageQueue(args[0], args[1]);
            var result = q.CreateIfNotExists().Result;

            Console.WriteLine($"Queue ({args[0]}) create: {result}.");
        }
    }
}