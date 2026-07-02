namespace DIDemo.Services
{
    public class MyScopedService
    {
        public string GetName()
        {
            return $"Scoped: {Guid.NewGuid()}";
        }
    }
}
