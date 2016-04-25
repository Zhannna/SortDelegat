using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordDelegat
{
    static class Extension
    {
        static public void ToString(this Record r)
        {
            Console.WriteLine(r.Name + " " + r.LastName + " " + r.Phone);
        }
        
        
        
        static public void  sort(this Record[] recs, Compareby compare)
        {    
            for (int i = 0; i < recs.Length; i++)
            {
                for (int j = 0; j < recs.Length; j++)
                {
                    if (compare(recs[i], recs[j]) < 0)
                    {
                       Record  temp = recs[i];
                        recs[i] = recs[j];
                        recs[j] = temp;
                    }
                   
                    
                }

                
            }
        }
    }
}
