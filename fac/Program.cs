using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{
    internal class Program
    {
        static void Main()
        {
            Replicator create1 = new CreatorPeacekeeper();
            Item pk1 = create1.Craft();

            Replicator create2 = new CreatorSpeedfire();
            Item spdf1 = create2.Craft();

            /////////////////////////////////////////////
            


        }
    }

}
