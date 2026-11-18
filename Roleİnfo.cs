namespace AnyAnyAnyRoles
{
    public class RoleInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleCategory Category { get; set; }
        public RoleTeam Team { get; set; }
        public string Description { get; set; }

        public RoleInfo(
            int id,
            string name,
            RoleCategory category,
            RoleTeam team,
            string description)
        {
            Id = id;
            Name = name;
            Category = category;
            Team = team;
            Description = description;
        }
    }
}