namespace FirstApi.Models
{
    public class CarEngine
    {
        public class Car 
        {
            private IEngine engine;
            public Car(IEngine e)
            {
                engine = e;
            }
        }
        public interface IEngine { }
        public class SuzukiEngine : IEngine { }
        public class ToyotaEngine : IEngine { }
    }
}
