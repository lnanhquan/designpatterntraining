namespace DIDemo.Services
{
    public class MyTransientTestService
    {
        private readonly MyScopedService _scoped;

        public MyTransientTestService(MyScopedService scoped)
        {
            _scoped = scoped;
        }

        public string GetScopedName()
        {
            return _scoped.GetName();
        }
    }
}
