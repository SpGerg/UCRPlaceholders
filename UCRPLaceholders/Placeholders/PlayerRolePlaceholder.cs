using Exiled.API.Features;
using PlaceholdersAPI.Interfaces;
using UncomplicatedCustomRoles.API.Features;

namespace UCRPLaceholders.Placeholders
{
    public class PlayerRolePlaceholder : IPlaceholder, IPlaceholderHookPlayer
    {
        public string Name => "Player role placeholder";

        public string Identifier => "player-ucr-role";

        public string Author => "SpGerg & FoxWorn";

        public string Description => "All player ucr role information";

        public string OnPlaceholderRequest(Player player, string identifier)
        {
            var id = GetId(identifier);

            if (identifier.Contains("role_name"))
            {
                return Manager.Get(id).Name;
            }
            else if (identifier.Contains("custom_info"))
            {
                return Manager.Get(id).CustomInfo;
            }

            return string.Empty;
        }

        private int GetId(string identifier)
        {
            string result = string.Empty;

            foreach (var letter in identifier)
            {
                if (int.TryParse(letter.ToString(), out int digit))
                {
                    result += digit.ToString();
                }
            }

            return int.Parse(result);
        }
    }
}
