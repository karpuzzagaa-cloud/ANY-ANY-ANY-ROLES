using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class AbilityCategoryManager
    {
        public static List<RoleAbility> GetByCategory(
            AbilityCategory category)
        {
            return RoleAbilityRegistry.GetAllAbilities()
                .FindAll(ability =>
                    ability.Category == category);
        }

        public static int GetCount(AbilityCategory category)
        {
            return GetByCategory(category).Count;
        }

        public static bool HasAbilities(AbilityCategory category)
        {
            return GetCount(category) > 0;
        }
    }
}