public static void Initialize()
{
    if (IsInitialized)
        return;

    RoleDatabase.Clear();
    RoleRegistry.Clear();

    DefaultRoles.RegisterAll();

    IsInitialized = true;
}