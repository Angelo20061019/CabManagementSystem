using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB_1st.Class
{
    internal class Person
    {
        private string id;
        private string name;
        private string password;
        private string nic;
        private string tp;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Nic
        {
            get { return nic; }
            set { nic = value; }
        }
        public string TP
        {
            get { return tp; }
            set { tp = value; }
        }

        public Person(string id, string name , string password, string nic, string tp)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.nic = nic;
            this.tp = tp;
        }

      
    }
}
