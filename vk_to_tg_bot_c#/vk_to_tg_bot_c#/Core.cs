using Telegram.Bot;
using VkNet;
using VkNet.Model;
using VkNetLongpoll;

namespace Program

{
    static internal class Core
    {
        static private Longpoll? longpoll { get; set; }
        static private VkApi? api { get; set; }
        static private TelegramBotClient? bot { get; set; }
        static private CancellationTokenSource? cts { get; set; }

        static private void InitializeResources()
        {
            ResourceManager.Initialize();
        }

        static private void InitializeTgBot()
        {
            cts = new CancellationTokenSource();
            bot = new TelegramBotClient(ResourceManager.TG_BOT_TOKEN, cancellationToken: cts.Token);
        }

        static private void InitializeVkApi()
        {
            api = new VkApi();

            api.Authorize(new ApiAuthParams
            {
                AccessToken = ResourceManager.VK_TOKEN
            });

            longpoll = new Longpoll(api, groupId:2000000205);
        }

        static public async Task MainInitialize()
        {
            InitializeResources();
            InitializeVkApi();
            InitializeTgBot();
        }
    }
}