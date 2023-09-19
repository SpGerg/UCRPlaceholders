using Exiled.API.Features;
using PlaceholdersAPI.Features;
using UCRPLaceholders.Placeholders;

namespace UCRPLaceholders
{
    public class Plugin : Plugin<Config>
    {
        public override void OnEnabled()
        {
            PLAPI.Register(new PlayerRolePlaceholder());
            PLAPI.Register(new RolePlaceholder());

            base.OnEnabled();
        }
    }
}
