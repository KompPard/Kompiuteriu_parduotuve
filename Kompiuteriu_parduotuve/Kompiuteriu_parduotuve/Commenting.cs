using System;
using System.Data;

namespace Kompiuteriu_parduotuve
{
   abstract class Commenting : IDisposable
    {
        int id;
        string author, message;
        public abstract void save(string author, string message, int product_id);
        public abstract void delete(int id);
        public abstract DataTable get(DataTable dt, int product_id);
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
