using System.Reflection;

namespace TCTestLib
{
    public class DataProvider
    {
        public static string Greeting()
        {
            return $"Hei fadderuttan fra TCTestLib.DataProvider, versjon {Assembly.GetExecutingAssembly().GetName().Version}!";
        }
    }
}
