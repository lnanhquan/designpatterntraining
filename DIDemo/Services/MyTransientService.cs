namespace DIDemo.Services
{
    public class MyTransientService
    {
        public string GetName()
        {
            return $"Trasient: {Guid.NewGuid()}";
        }
    }
}
