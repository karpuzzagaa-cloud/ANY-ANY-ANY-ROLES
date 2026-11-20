using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class AbilitySearch
    {
        public static List<RoleAbility> Search(string keyword)
        {
            List<RoleAbility> results =
                new List<RoleAbility>();

            if (string.IsNullOrWhiteSpace(keyword))
                return results;

            foreach (RoleAbility ability in
                RoleAbilityRegistry.GetAllAbilities())
            {
                if (ability.Name.Contains(keyword) ||
                    ability.Description.Contains(keyword))
                {
                    results.Add(ability);
                }
            }

            return results;
        }
    }
}