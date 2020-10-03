namespace BilgeAdam.HR.Common
{
    internal static class IdentityManager
    {
        private static object lockObject = new object();
        private static int id;
        public static int GetNext()
        {
            lock (lockObject)
            {
                ++id;
            }
            return id;
        }
    }
}
