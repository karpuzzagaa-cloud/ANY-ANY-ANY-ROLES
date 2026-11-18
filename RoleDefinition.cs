namespace AnyAnyAnyRoles
{
    public class RoleDefinition
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string Description { get; set; }
        public bool IsEnabled { get; set; }

        public RoleDefinition(
            string name,
            string team,
            string description)
        {
            Name = name;
            Team = team;
            Description = description;
            IsEnabled = true;
        }
    }
}