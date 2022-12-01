string path = "C:\\Users\\Admin\\Downloads\\Telegram Desktop";
string pathNew = "E:\\Files";

List<string> types = new List<string>() { ".jpg", ".mp3", ".mp4", ".ogg"};

DirectoryInfo DirectoryInfo = new DirectoryInfo(path);

foreach (var item in DirectoryInfo.GetFiles())
{
    string temp;
    try
    {
        if (types.Contains(item.Extension))
        {
            temp = $"{pathNew}\\{item.Extension}\\";
            Directory.CreateDirectory(temp);
            item.MoveTo(temp + item.Name);
        }
        else
        {
            temp = $"{pathNew}\\Misc\\";
            Directory.CreateDirectory(temp);
            item.MoveTo(temp + item.Name);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Run program as an admin");
        Console.ReadKey(true);
        break;
    }
}