namespace FirstApi.Models
{
    public interface iApiLogger
    {
        void Log(string message);
    }

    public class ApiLogger: iApiLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}:{message}");
        }

    }

    public class FileApiLogger : iApiLogger 
    {
        private string _fileName;
        public FileApiLogger()
        {
            _fileName = $"Log_{DateTime.Now.ToFileTime()}.log";
            File.WriteAllText("Log.log", "This is a log file" + Environment.NewLine);
        }
        public void Log(string message) 
        {
            File.AppendAllText(_fileName,$"{DateTime.Now}: {message}");
            File.AppendAllText(_fileName, Environment.NewLine);


        }
    }
}
