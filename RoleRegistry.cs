public static void RegisterRole(string roleName)
{
    if (!string.IsNullOrWhiteSpace(roleName)
        && !roles.Contains(roleName))
    {
        roles.Add(roleName);
    }
}