using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoes.Model
{
    class MenuItem
    {
        private string _meat;
        private string _condiment;
        private string _bread;

        public string Meat { get { return _meat; } set { _meat = value; } }

        public string Condiment { get { return _condiment; } set { _condiment = value; } }

        public string Bread { get { return _bread; } set { _bread = value; } }

        public MenuItem(string meat, string condiment, string bread)
        {
            Meat = meat;
            Condiment = condiment;
            Bread = bread;
        }

        public override string ToString()
        {
            return Meat + " with " + Condiment + " on " + Bread;
        }
    }
}
