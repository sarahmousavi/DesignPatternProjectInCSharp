using System.ComponentModel.Design.Serialization;

namespace CompositeDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ساختار دایرکتوری اصلی
            Directory root = new Directory("Root");
            //فایل ها و دایرکتوری های سطح اول
            root.Add(new File("File1.txt"));
            root.Add(new File("File2.txt"));

            Directory subDir = new Directory("SubDirectory");
            subDir.Add(new File("File3.txt"));
            subDir.Add(new File("File4.txt"));

            root.Add(subDir);
            //فایل دیگر در سطح اصلی
            root.Add(new File("File5.txt"));
            //نمایش ساختار
            root.Display(1);

        }
    }
}