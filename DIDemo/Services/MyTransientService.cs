namespace DIDemo.Services
{
    public class MyTransientService
    {
        public string GetName()
        {
            return $"Transient: {Guid.NewGuid()}";
        }
    }
}
