using System.IO;
using static System.Console;
using static System.IO.Directory;

IEnumerable<string> ListDirectory(string path)
{
  foreach(string file in Directory.GetDirectories(path))
  {
    // WriteLine(file);
    yield return file;
  }
  foreach(string file in Directory.GetFiles(path))
  {
    // WriteLine(file);
    yield return file;
  }
}

public string cd
{
  set { System.Environment.CurrentDirectory = value; }
}

public string pwd
{
  get { return System.Environment.CurrentDirectory; }
}
