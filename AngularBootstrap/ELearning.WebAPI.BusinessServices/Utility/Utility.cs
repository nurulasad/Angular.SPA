namespace PCS.ELearning.BusinessServices.Utility
{
    public static class Utility
    {
        public static string GenerateKey<T>() {

            var key = typeof(T).ToString();
            return key;
        }
    }
}
