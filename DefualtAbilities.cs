namespace AnyAnyAnyRoles
{
    public static class DefaultAbilities
    {
        public static void RegisterAll()
        {
            Register(1, "Sprint", "Kısa süreli hızlanma.", 25);
            Register(2, "Scan", "Oyuncu hakkında bilgi edinme.", 30);
            Register(3, "Shield", "Kendini korumaya alma.", 40);
            Register(4, "Track", "Bir oyuncunun konumunu takip etme.", 35);
            Register(5, "Invisibility", "Kısa süreli görünmez olma.", 45);
            Register(6, "Sabotage", "Bir sistemi geçici olarak bozma.", 30);
            Register(7, "Mimic", "Başka bir oyuncunun görünümünü taklit etme.", 50);
            Register(8, "Reveal", "Bir oyuncunun rolünü açığa çıkarma.", 60);
            Register(9, "Teleport", "Başka bir konuma ışınlanma.", 45);
            Register(10, "Decoy", "Sahte bir kopya oluşturma.", 50);
        }

        private static void Register(
            int id,
            string name,
            string description,
            int cooldown)
        {
            RoleAbility ability = new RoleAbility(
                id, name, description, cooldown
            );

            if (RoleAbilityValidator.IsValid(ability))
                RoleAbilityRegistry.RegisterAbility(ability);
        }
    }
}