using System.Runtime.Caching;

namespace ELearning.BusinessServices.Utility
{
    public class DefaultCacheProvider : ICacheProvider
    {

        private static ObjectCache cache = new MemoryCache("CachingProvider");


        private CacheItemPolicy policy = new CacheItemPolicy
        {
            SlidingExpiration = new System.TimeSpan(0, 20, 0)
        };

        static readonly object padlock = new object();


        public DefaultCacheProvider()
        {
        }
        public object Get(string key)
        {
            if (cache.Contains(key))
                return cache.Get(key);
            return null;
        }


        public void Set(string key, object value)
        {
            lock (padlock)
            {
                cache.Set(key, value, policy);
            }


        }

        public bool Contains(string key)
        {
            return cache.Contains(key);
        }

        public object Invalidate(string key)
        {
            lock (padlock)
            {
                if (cache.Contains(key))
                {
                    return cache.Remove(key);
                }
            }

            return null;

        }

        public void InvalidateAll()
        {
            foreach (var element in cache)
            {
                Invalidate(element.Key);
            }
        }
    }
}
