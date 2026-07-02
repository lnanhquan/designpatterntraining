namespace DIDemo.Services
{
    public class MySingletonService
    {
        private readonly MyScopedService _scoped;

        public MySingletonService(MyScopedService scoped)
        {
            _scoped = scoped;
        }

        public string GetName()
        {
            return _scoped.GetName();
        }
    }
}
