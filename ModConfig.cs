namespace AnyAnyAnyRoles
{
    public class ModConfig
    {
        // Rol tahmin sistemi
        public bool RoleGuessingEnabled { get; set; } = true;

        // Tahmin yalnızca toplantıda yapılır
        public bool MeetingOnly { get; set; } = true;

        // Her Impostor ve Neutral için 5 hak
        public int GuessesPerPlayer { get; set; } = 5;

        // Tahmin yapabilen roller
        public bool ImpostorCanGuess { get; set; } = true;
        public bool NeutralCanGuess { get; set; } = true;

        // Crewmate tahmin yapamaz
        public bool CrewmateCanGuess { get; set; } = false;
    }
}