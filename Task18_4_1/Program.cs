namespace Task18_4_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на видео YouTube для скачивания");
            string url = Convert.ToString(Console.ReadLine());

            string path = @"C:\Users\Владимир\source\repos\Task18_4_1\Task18_4_1\bin\Debug\net6.0";

            var sender = new Sender();

            var receiver = new Receiver();

            var command = new CommandOne(receiver);

            sender.SetCommand(command);

            sender.Info(url);

            sender.Download(url, path);

            Console.ReadKey();
        }
    }
}

