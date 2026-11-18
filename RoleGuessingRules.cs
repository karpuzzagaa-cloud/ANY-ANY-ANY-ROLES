
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
            return player != null
                && featureEnabled
                && isMeeting
                && player.IsAlive
                && player.GuessesRemaining > 0
                && (player.Role == PlayerRole.Impostor
                    || player.Role == PlayerRole.Neutral);
        }

        public static bool CheckGuess(
            Player guesser,
            Player target,
            PlayerRole guessedRole,
            bool featureEnabled,
            bool isMeeting)
        {
            if (!CanGuess(guesser, featureEnabled, isMeeting))
                return false;

            if (target == null || !target.IsAlive)
                return false;

            guesser.GuessesRemaining--;

            if (guessedRole != target.Role)
            {
                guesser.IsAlive = false;
            }
            else
            {
                target.IsAlive = false;
            }

            return true;
        }
    }
}
