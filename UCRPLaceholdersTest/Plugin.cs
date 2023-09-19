using Exiled.API.Features;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCRPLaceholdersTest
{
    public class Plugin : Plugin<Config>
    {
        public override void OnEnabled()
        {
            Timing.CallDelayed(20f, () =>
            {
                Log.Info(Config.SomeCoolText);
            });

            base.OnEnabled();
        }
    }
}
