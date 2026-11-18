
namespace AnyAnyAnyRoles
{
    public class ModConfig
    {
        public bool RoleGuessingEnabled { get; set; } = true;

        public bool MeetingOnly { get; set; } = true;

        public int GuessesPerPlayer { get; set; } = 5;

        public bool ImpostorCanGuess { get; set; } = true;

        public bool NeutralCanGuess { get; set; } = true;

        public bool CrewmateCanGuess { get; set; } = false;

        public void Reset()
        {
            RoleGuessingEnabled = true;
            MeetingOnly = true;
            GuessesPerPlayer = 5;
            ImpostorCanGuess = true;
            NeutralCanGuess = true;
            CrewmateCanGuess = false;
        }
    }
}
