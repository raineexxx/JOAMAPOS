using System.Configuration;

namespace JOAMAPOS.Data
{
    internal static class DbFactory
    {
        // reads <connectionStrings name="PosDb"> from the WinForms App.config
        public static PosDataContext Create()
        {
            var cs = ConfigurationManager.ConnectionStrings["PosDb"];
            if (cs == null)
                throw new ConfigurationErrorsException(
                    "Connection string 'PosDb' was not found in the WinForms App.config.");
            return new PosDataContext(cs.ConnectionString);
        }
    }
}