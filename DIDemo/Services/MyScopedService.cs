namespace DIDemo.Services
{
    public class MyScopedService
    {
        private readonly MyTransientService _transient;

        public MyScopedService(MyTransientService transient)
        {
            _transient = transient;
        }

        public string GetName()
        {
            return $"Scoped: {Guid.NewGuid()}";
        }

        public string GetTransientName()
        {
            return _transient.GetName();
        }
    }
}
