using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSurvivor.Source.World
{
    class StaticPlatform : Platform
    {

        public override void UpdateInternal()
        {
            // Note: As the platform name suggests, they are static and
            // nothing needs to be updated per frame.
        }
    }
}
