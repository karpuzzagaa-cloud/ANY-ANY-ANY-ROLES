namespace AnyAnyAnyRoles
{
    public class RoleAbility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CooldownSeconds { get; set; }
        public bool IsEnabled { get; set; }
        public AbilityType Type { get; set; }
        public AbilityCategory Category { get; set; }

        public RoleAbility(
            int id,
            string name,
            string description,
            int cooldownSeconds,
            AbilityType type = AbilityType.Active,
            AbilityCategory category = AbilityCategory.Basic)
        {
            Id = id;
            Name = name;
            Description = description;
            CooldownSeconds = cooldownSeconds;
            Type = type;
            Category = category;
            IsEnabled = true;
        }

        public void Enable()
        {
            IsEnabled = true;
        }

        public void Disable()
        {
            IsEnabled = false;
        }
    }
}