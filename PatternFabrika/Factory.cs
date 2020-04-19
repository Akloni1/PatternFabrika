using System;
using System.Collections.Generic;
using System.Text;

namespace PaternFabrika
{
    class Factory
    {
        public Arms create(String arms)
        {
            if (arms.Equals("Glock18"))
            {
                return new Glock18();
            }
            else if (arms.Equals("Brt92FS"))
            {
                return new Brt92FS();

            }
            else if (arms.Equals("Ak47"))
            {
                return new Ak47();

            }
            else return null;
        }
    }
}
