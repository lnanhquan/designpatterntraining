namespace DIDemo.Services
{
    public class MySingletonService
    {
        private readonly MyScopedService _scoped;
        private readonly MyTransientService _transient;

        public MySingletonService(MyTransientService transient/*, MyScopedService scoped*/)
        {
            _transient = transient;
        }

        public string GetName()
        {
            return _transient.GetName();
        }
    }
}
