using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culbertson_MagicPCApp
{
    class MagicPCApp
    {
        static void Main(string[] args)
        {
            MagicPCUI view = new MagicPCUI();
            Display info = new Display();
            info.DisplayInfo("Magic PC App");
            view.Start();
        }
    }
}
