using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class AbilityFilter
    {
        public static List<RoleAbility> GetEnabledAbilities()
        {
            return RoleAbilityRegistry.GetAllAbilities()
                .FindAll(ability => ability.IsEnabled);
        }

        public static List<RoleAbility> GetDisabledAbilities()
        {
            return RoleAbilityRegistry.GetAllAbilities()
                .FindAll(ability => !ability.IsEnabled);
        }

        public static List<RoleAbility> GetByType(AbilityType type)
        {
            return RoleAbilityRegistry.GetAllAbilities()
                .FindAll(ability => ability.Type == type);
        }

        public static List<RoleAbility> GetByCategory(
            AbilityCategory category)
        {
            return RoleAbilityRegistry.GetAllAbilities()
                .FindAll(ability => ability.Category == category);
        }
    }
}