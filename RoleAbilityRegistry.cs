using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class RoleAbilityRegistry
    {
        private static readonly Dictionary<int, RoleAbility> abilities =
            new Dictionary<int, RoleAbility>();

        public static void RegisterAbility(RoleAbility ability)
        {
            if (ability == null)
                return;

            if (abilities.ContainsKey(ability.Id))
                return;

            if (!RoleAbilityValidator.IsValid(ability))
                return;

            abilities.Add(ability.Id, ability);
            AbilityDatabase.Add(ability);
        }

        public static RoleAbility GetAbility(int id)
        {
            RoleAbility ability;

            if (abilities.TryGetValue(id, out ability))
                return ability;

            return null;
        }

        public static List<RoleAbility> GetAllAbilities()
        {
            return new List<RoleAbility>(abilities.Values);
        }

        public static void Clear()
        {
            abilities.Clear();
            AbilityDatabase.Clear();
        }
    }
}