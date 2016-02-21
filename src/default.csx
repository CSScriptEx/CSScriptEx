public static class CsiAliases
{
    public static string[] dir(string directory = null)
    {

        return System.IO.Directory.GetFiles(directory ?? System.Environment.CurrentDirectory);
    }
    public static void type(params string texts) => System.Console.WriteLine(text);
    public static string cd(string directory) => System.Environment.CurrentDirectory = directory;

}
