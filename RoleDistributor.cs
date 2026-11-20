using System;
using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class RoleDistributor
    {
        private static readonly Random random = new Random();

        public static RoleAssignment AssignRandomRoles(
            List<int> playerIds,
            RoleSettings settings)
        {
            RoleAssignment assignment = new RoleAssignment();

            if (playerIds == null || settings == null)
                return assignment;

            if (!settings.EnableCustomRoles)
                return assignment;

            List<RoleInfo> availableRoles =
                RoleDatabase.GetAllRoles();

            availableRoles.RemoveAll(role =>
                !IsAllowed(role, settings));

            int count = Math.Min(
                settings.MaximumRolesPerGame,
                Math.Min(playerIds.Count, availableRoles.Count));

            if (count <= 0)
                return assignment;

            for (int i = 0; i < count; i++)
            {
                int roleIndex = random.Next(availableRoles.Count);

                RoleInfo selectedRole = availableRoles[roleIndex];

                assignment.AssignRole(playerIds[i], selectedRole);

                availableRoles.RemoveAt(roleIndex);
            }

            return assignment;
        }

        private static bool IsAllowed(
            RoleInfo role,
            RoleSettings settings)
        {
            if (role == null)
                return false;

            if (role.Team == RoleTeam.Crewmate &&
                !settings.AllowCrewmateRoles)
                return false;

            if (role.Team == RoleTeam.Impostor &&
                !settings.AllowImpostorRoles)
                return false;

            if (role.Team == RoleTeam.Neutral &&
                !settings.AllowNeutralRoles)
                return false;

            return true;
        }
    }
}