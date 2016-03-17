using ELearning.BusinessServices.Utility;

namespace PCS.ELearningWebAPI.BusinessServices.Utility
{
    public class NullCacheProvider : ICacheProvider
    {
        
        public void Clear(string key)
        {

        }

        public object Get(string key)
        {
            return null;
        }
        
        public void Set(string key, object value)
        {

        }

        public bool Contains(string key)
        {
            return false;
        }

        public object Invalidate(string key)
        {
            return null;
        }

        public void InvalidateAll()
        {

        }
    }
}
