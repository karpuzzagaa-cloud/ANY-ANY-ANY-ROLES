using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class RoleDatabase
    {
        private static readonly List<RoleInfo> roles =
            new List<RoleInfo>();

        public static void AddRole(RoleInfo role)
        {
            if (role != null && GetRole(role.Id) == null)
            {
                roles.Add(role);
            }
        }

        public static RoleInfo GetRole(int id)
        {
            return roles.Find(role => role.Id == id);
        }

        public static List<RoleInfo> GetAllRoles()
        {
            return new List<RoleInfo>(roles);
        }

        public static void Clear()
        {
            roles.Clear();
        }
    }
}