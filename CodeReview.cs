namespace TestConsoleApplication
{
    class FileWorker
    {
        System.IO.StreamWriter sw = null;

        public FileWorker(string filePath)
        {
            this.sw = new System.IO.StreamWriter(filePath);
        }

        public void WriteLine(string line)
        {
            this.sw.WriteLine(line);
        }

        public void Close()
        {
            if (sw != null)
            {
                sw.Close();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой файл откроем?");
            FileWorker fw = new FileWorker(Console.ReadLine());
            Console.WriteLine("Что пишем?");
            fw.WriteLine(Console.ReadLine());
            fw.Close();
        }
    }
}