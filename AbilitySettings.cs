namespace AnyAnyAnyRoles
{
    public static class AbilitySettings
    {
        public static bool AbilitiesEnabled { get; set; } = true;

        public static int MinimumCooldown { get; set; } = 5;

        public static int MaximumCooldown { get; set; } = 120;

        public static void Reset()
        {
            AbilitiesEnabled = true;
            MinimumCooldown = 5;
            MaximumCooldown = 120;
        }

        public static bool IsCooldownValid(int seconds)
        {
            return seconds >= MinimumCooldown &&
                   seconds <= MaximumCooldown;
        }
    }
}