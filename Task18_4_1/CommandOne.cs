using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task18_4_1
{
    public class CommandOne : Command
    {
        Receiver receiver;
        public CommandOne(Receiver receiver) 
        {
            this.receiver = receiver;
        }
        public async void Download(string url, string path)
        {
            receiver.Operarion();

            var youtube = new YoutubeClient();
            
            var video = youtube.Videos.GetAsync(url);
           
            var streamManifest = youtube.Videos.Streams.GetManifestAsync(video.Result.Id).Result;
          
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                     
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{path}/{video.Result.Id}.{streamInfo.Container}");
            Console.WriteLine("Загрузка завершена!");
            
        }

        public async void Info(string url)
        {
            var youtube = new YoutubeClient();
            var video = youtube.Videos.GetAsync(url).Result;
            Console.WriteLine($"Название: {video.Title}");
            Console.WriteLine($"Продолжительность: {video.Duration}");
            Console.WriteLine($"Автор: {video.Author}");
        }
    }
}
