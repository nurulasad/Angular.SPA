namespace ELearning.BusinessServices.Utility
{
    public interface ICacheProvider
    {

        object Get(string key);
        void Set(string key, object value);

        bool Contains(string key);


        object Invalidate(string key);

        void InvalidateAll();
        

    }
}
