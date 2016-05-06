using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Model
{
    public class Emitent : Entity
    {
        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string person;
        public virtual string Person
        {
            get { return person; }
            set { person = value; }
        }
        private string address;
        public virtual string Address
        {
            get { return address; }
            set { address = value; }
        }

        private Aktsii aktsii_id;
        public virtual Aktsii Aktsii_id
        {
            get { return aktsii_id; }
            set { aktsii_id = value; }
        }

    }
}
