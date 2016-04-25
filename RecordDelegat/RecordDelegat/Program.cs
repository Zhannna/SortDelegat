using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordDelegat
{
    class Program
    {

        static int CompareByName(Record r, Record y)
        {
            return r.Name.CompareTo(y.Name);
        }

        static int CompareByPhone(Record r, Record y)
        {
            return r.Phone.CompareTo(y.Phone);
        }


        static void Main(string[] args)
        {

            Record[] recs =
                 new Record[] {
                     new Record() { Name = "aramazd", LastName = "Smith", Phone="54656654" },
                     new Record() { Name = "jakhsfhsjd", LastName = "Smith", Phone="54656654" },
                     new Record() { Name = "John", LastName = "Smith", Phone="54656654" },
                     new Record() { Name = "Aramazd", LastName = "Smith", Phone="54656654" }
                     
                     
                 };

            recs.sort(CompareByName);

            foreach (Record item in recs)
            {
                Console.WriteLine("{0}  {1} {2}", item.Name, item.LastName, item.Phone);
            }
        }
    }
}
