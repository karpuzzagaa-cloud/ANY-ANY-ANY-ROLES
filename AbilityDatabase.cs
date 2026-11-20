using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class AbilityDatabase
    {
        private static readonly List<RoleAbility> abilities =
            new List<RoleAbility>();

        public static void Add(RoleAbility ability)
        {
            if (ability == null)
                return;

            if (GetById(ability.Id) == null)
                abilities.Add(ability);
        }

        public static RoleAbility GetById(int id)
        {
            return abilities.Find(a => a.Id == id);
        }

        public static List<RoleAbility> GetAll()
        {
            return new List<RoleAbility>(abilities);
        }

        public static void Clear()
        {
            abilities.Clear();
        }
    }
}