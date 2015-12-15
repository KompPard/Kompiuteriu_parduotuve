using System;

namespace Kompiuteriu_parduotuve
{
    static class Helper
    {
        public static string getNewCartGUID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
