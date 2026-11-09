using System;
using System.Data.SqlClient;
using JOAMAPOS.Domain;

namespace JOAMAPOS.Services
{
    internal static class SqlGuard
    {
        public static T Query<T>(Func<T> action)
        {
            try { return action(); }
            catch (SqlException ex) { throw Translate(ex); }
        }

        public static void Execute(Action action)
        {
            try { action(); }
            catch (SqlException ex) { throw Translate(ex); }
        }

        private static BusinessException Translate(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
                return new BusinessException("Duplicate SKU or Barcode. Use a unique value.");
            if (ex.Number == 547)
                return new BusinessException("The data conflicts with a database rule (check the values).");
            if (ex.Number >= 50000)   // THROW 500xx from the stored procedures
                return new BusinessException(ex.Message);
            return new BusinessException("Database error: " + ex.Message);
        }
    }
}