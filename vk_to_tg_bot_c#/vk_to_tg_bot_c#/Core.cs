using VkNetLongpoll;
using VkNet;
using VkNet.Model;

namespace Program

{
    static internal class Core
    {

        static async private void InitializeVkApi()
        {
            var api = new VkApi();

            // Авторизация только через токен сообщества
            await api.AuthorizeAsync(new ApiAuthParams
            {
                AccessToken = ResourceManager.VK_TOKEN
            });

            var longpoll = new Longpoll(api, );




        }
    }
}