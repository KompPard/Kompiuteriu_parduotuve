using System;
using System.Data;

namespace Kompiuteriu_parduotuve
{
    class Compare : IDisposable
    {
        int product1, product2;
        public Compare(int first_product, int second_product)
        {
            product1 = first_product;
            product2 = second_product;
        }
        public DataTable compare()
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            using (Search search = new Search())
            {
                dt1 = search.find_id(product1);
                dt2 = search.find_id(product2);
            }
            dt1.Merge(dt2);
            return dt1;
        }
        public DataTable change_sides()
        {
            int tmp = product1;
            product1 = product2;
            product2 = tmp;
            DataTable dt = compare();
            return dt;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
