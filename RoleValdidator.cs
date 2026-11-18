namespace AnyAnyAnyRoles
{
    public static class RoleValidator
    {
        public static bool IsValid(RoleInfo role)
        {
            if (role == null)
                return false;

            if (string.IsNullOrWhiteSpace(role.Name))
                return false;

            if (string.IsNullOrWhiteSpace(role.Description))
                return false;

            if (role.Id < 1)
                return false;

            return true;
        }
    }
}