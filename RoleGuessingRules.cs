namespace AnyAnyAnyRoles
{
    public enum PlayerRole
    {
        Crewmate,
        Impostor,
        Neutral
    }

    public class Player
    {
        public PlayerRole Role;
        public int GuessesRemaining = 5;
        public bool IsAlive = true;
    }

    public static class RoleGuessingRules
    {
        public static bool CanGuess(
            Player player,
            bool featureEnabled,
            bool isMeeting)
        {
            return featureEnabled
                && isMeeting
                && player.IsAlive
                && player.GuessesRemaining > 0
                && (player.Role == PlayerRole.Impostor
                    || player.Role == PlayerRole.Neutral);
        }

        public static bool WrongGuess(Player player)
        {
            if (!CanGuess(player, true, true))
                return false;

            player.GuessesRemaining--;
            player.IsAlive = false;
            return true;
        }
    }
}