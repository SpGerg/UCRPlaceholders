using Exiled.API.Features;
using PlaceholdersAPI.Interfaces;
using UncomplicatedCustomRoles.API.Features;

namespace UCRPLaceholders.Placeholders
{
    public class RolePlaceholder : IPlaceholder, IPlaceholderHook
    {
        public string Name => "Role placeholder";

        public string Identifier => "ucr-role";

        public string Author => "SpGerg & FoxWorn";

        public string Description => "All ucr roles information";

        public string OnPlaceholderRequest(string identifier)
        {
            var id = GetId(identifier);

            if (identifier.Contains("count"))
            {
                int result = 0;

                foreach (var player in Player.List)
                {
                    var role_id = Manager.Get(player);

                    if (role_id == null)
                    {
                        continue;
                    }

                    var role = Manager.Get(id);

                    if (role.Id == id)
                    {
                        result++;
                    }
                }

                return result.ToString();
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
