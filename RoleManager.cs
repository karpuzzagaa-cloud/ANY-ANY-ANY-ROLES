using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public class RoleManager
    {
        private readonly Dictionary<int, PlayerRole> roles =
            new Dictionary<int, PlayerRole>();

        public void SetRole(int playerId, PlayerRole role)
        {
            roles[playerId] = role;
        }

        public bool TryGetRole(int playerId, out PlayerRole role)
        {
            return roles.TryGetValue(playerId, out role);
        }

        public void ClearRoles()
        {
            roles.Clear();
        }

        public int GetPlayerCount()
        {
            return roles.Count;
        }
    }
}