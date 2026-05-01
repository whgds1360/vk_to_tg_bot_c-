using dotenv.net;

namespace Program
{
    static internal class ResourceManager
    {
        static public string? TG_BOT_TOKEN { set; get; }
        static public Array? LIST_OF_LISTEN { set; get; }
        static public string? VK_TOKEN { set; get; }
        static public string? VK_COMMUNITY_TOKEN { set; get; }
        static public string? CHAT_ID { set; get; }

        static public void Initialize()
        {
            //Подгружаем переменные процесса
            DotEnv.Load();
            Console.WriteLine($"Ищу .env в папке: {Environment.CurrentDirectory}");

            //Подгружаем их в код
            LIST_OF_LISTEN = Environment.GetEnvironmentVariable("LIST_OF_LISTEN")
                ?.ToString()
                .Split(",");

            TG_BOT_TOKEN = Environment.GetEnvironmentVariable("TG_BOT_TOKEN");
            VK_TOKEN = Environment.GetEnvironmentVariable("VK_TOKEN");
            VK_COMMUNITY_TOKEN = Environment.GetEnvironmentVariable("VK_COMMUNITY_TOKEN");
            CHAT_ID = Environment.GetEnvironmentVariable("CHAT_ID");
        }
    }
}
