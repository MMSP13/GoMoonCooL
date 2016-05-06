using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBase.Model
{
    public class Aktsii: Entity
    {
        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string cost;
        public virtual string Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        private string count;
        public virtual string Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
