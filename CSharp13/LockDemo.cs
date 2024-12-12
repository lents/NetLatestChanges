namespace CSharp13
{
    public class LockDemo
    {
        private readonly Lock _lock = new();

        public void RunSomething()
        {
            lock (_lock)
            {

            }
        }

    }
}
