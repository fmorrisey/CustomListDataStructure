using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class EngineType : RocketEngines, IComparable
    {
        public EngineType(string name)
        {
            this.Name = name;
            this._thrust = 110.1; //kN
            this._mass = 301.5; //kg
            this._cycle = "Expander Cycle";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
