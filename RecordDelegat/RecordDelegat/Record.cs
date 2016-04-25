using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordDelegat
{
    class Record
    {


        private string name;
        private string lastName;
        private string phone;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Record(string name, string lastName, string phone)
        {
            Name = name;
            LastName = lastName;
            Phone = phone;
        }

        public Record()
        { }


        
    }
}
