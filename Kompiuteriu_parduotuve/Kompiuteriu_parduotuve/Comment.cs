using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompiuteriu_parduotuve
{
    class Comment : Commenting
    {
        int id;
        string author, message;
        
        public override void delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void save(string author, string message, int id, int product_id)
        {
           
        }
    }
}
