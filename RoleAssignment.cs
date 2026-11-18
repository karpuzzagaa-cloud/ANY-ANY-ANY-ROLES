using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public class RoleAssignment
    {
        private readonly Dictionary<int, RoleInfo> assignments =
            new Dictionary<int, RoleInfo>();

        public void AssignRole(int playerId, RoleInfo role)
        {
            if (role != null)
            {
                assignments[playerId] = role;
            }
        }

        public RoleInfo GetAssignedRole(int playerId)
        {
            RoleInfo role;

            if (assignments.TryGetValue(playerId, out role))
            {
                return role;
            }

            return null;
        }

        public void ClearAssignments()
        {
            assignments.Clear();
        }
    }
}