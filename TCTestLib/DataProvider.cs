using System.Reflection;

namespace TCTestLib
{
    public class DataProvider
    {
        public static string Greeting()
        {
            return string.Format("Hei fadderuttan fra TCTestLib.DataProvider, versjon {0}!", Assembly.GetExecutingAssembly().GetName().Version);
        }
    }
}
