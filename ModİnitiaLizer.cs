namespace AnyAnyAnyRoles
{
    public static class ModInitializer
    {
        public static bool IsInitialized { get; private set; }

        public static void Initialize()
        {
            if (IsInitialized) return;

            RoleDatabase.Clear();
            RoleRegistry.Clear();
            RoleAbilityRegistry.Clear();

            DefaultRoles.RegisterAll();
            DefaultAbilities.RegisterAll();

            IsInitialized = true;
        }

        public static void Reset()
        {
            RoleDatabase.Clear();
            RoleRegistry.Clear();
            RoleAbilityRegistry.Clear();

            IsInitialized = false;
        }
    }
}