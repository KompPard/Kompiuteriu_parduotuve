using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompiuteriu_parduotuve
{
   abstract class Commenting
    {
        int id;
        string author, message;
        public abstract void save(string author, string message, int id, int product_id);
        public abstract void delete(int id);
    }
}
