namespace AnyAnyAnyRoles
{
    public static class RoleAbilityValidator
    {
        public static bool IsValid(RoleAbility ability)
        {
            if (ability == null)
                return false;

            if (ability.Id < 1)
                return false;

            if (string.IsNullOrWhiteSpace(ability.Name))
                return false;

            if (string.IsNullOrWhiteSpace(ability.Description))
                return false;

            if (ability.CooldownSeconds < 0)
                return false;

            return true;
        }
    }
}