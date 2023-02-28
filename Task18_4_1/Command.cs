namespace Task18_4_1
{
    interface Command
    {
        void Info(string url);
        void Download(string url, string path);
    }
}
