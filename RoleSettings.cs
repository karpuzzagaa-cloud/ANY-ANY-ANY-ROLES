namespace AnyAnyAnyRoles
{
    public class RoleSettings
    {
        public bool EnableCustomRoles { get; set; } = true;

        public int MaximumRolesPerGame { get; set; } = 3;

        public bool AllowNeutralRoles { get; set; } = true;

        public bool AllowImpostorRoles { get; set; } = true;

        public bool AllowCrewmateRoles { get; set; } = true;

        public void Reset()
        {
            EnableCustomRoles = true;
            MaximumRolesPerGame = 3;
            AllowNeutralRoles = true;
            AllowImpostorRoles = true;
            AllowCrewmateRoles = true;
        }
    }
}