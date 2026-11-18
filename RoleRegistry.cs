using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class RoleRegistry
    {
        private static readonly List<string> roles =
            new List<string>();

        public static void RegisterRole(string roleName)
        {
            if (!roles.Contains(roleName))
            {
                roles.Add(roleName);
            }
        }

        public static bool HasRole(string roleName)
        {
            return roles.Contains(roleName);
        }

        public static List<string> GetAllRoles()
        {
            return new List<string>(roles);
        }

        public static void Clear()
        {
            roles.Clear();
        }
    }
}