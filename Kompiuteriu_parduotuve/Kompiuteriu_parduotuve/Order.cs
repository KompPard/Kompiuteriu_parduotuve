using System;
using System.Data;

namespace Kompiuteriu_parduotuve
{
    class Order : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
