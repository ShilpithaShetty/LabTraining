namespace FirstApi.Models
{
    public interface Accessories
    {
        void Log(string message);
    }

    public class CarAccessories : Accessories
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now}:{message}");
        }

    }
}
