
using System;

namespace AnyAnyAnyRoles
{
    public static class RoleGuessingTests
    {
        public static void RunAll()
        {
            TestImpostorCanGuess();
            TestNeutralCanGuess();
            TestCrewmateCannotGuess();
            TestGuessOnlyDuringMeeting();
            TestFiveGuessLimit();
            TestWrongGuessEliminatesGuesser();
            TestCorrectGuessDoesNotEliminateGuesser();
        }

        private static void TestImpostorCanGuess()
        {
            var player = new Player { Role = PlayerRole.Impostor };
            Check(RoleGuessingRules.CanGuess(player, true, true),
                "Impostor tahmin yapabilmeli.");
        }

        private static void TestNeutralCanGuess()
        {
            var player = new Player { Role = PlayerRole.Neutral };
            Check(RoleGuessingRules.CanGuess(player, true, true),
                "Neutral tahmin yapabilmeli.");
        }

        private static void TestCrewmateCannotGuess()
        {
            var player = new Player { Role = PlayerRole.Crewmate };
            Check(!RoleGuessingRules.CanGuess(player, true, true),
                "Crewmate tahmin yapamamali.");
        }

        private static void TestGuessOnlyDuringMeeting()
        {
            var player = new Player { Role = PlayerRole.Impostor };
            Check(!RoleGuessingRules.CanGuess(player, true, false),
                "Tahmin sadece toplantida yapilmali.");
        }

        private static void TestFiveGuessLimit()
        {
            var player = new Player
            {
                Role = PlayerRole.Neutral,
                GuessesRemaining = 0
            };

            Check(!RoleGuessingRules.CanGuess(player, true, true),
                "Hak bitince tahmin yapilamamali.");
        }

        private static void TestWrongGuessEliminatesGuesser()
        {
            var guesser = new Player { Role = PlayerRole.Impostor };
            var target = new Player { Role = PlayerRole.Crewmate };

            RoleGuessingRules.CheckGuess(
                guesser, target, PlayerRole.Neutral, true, true);

            Check(!guesser.IsAlive,
                "Yanlis tahminde tahmin yapan elenmeli.");
        }

        private static void TestCorrectGuessDoesNotEliminateGuesser()
        {
            var guesser = new Player { Role = PlayerRole.Neutral };
            var target = new Player { Role = PlayerRole.Impostor };

            RoleGuessingRules.CheckGuess(
                guesser, target, PlayerRole.Impostor, true, true);

            Check(guesser.IsAlive,
                "Dogru tahminde tahmin yapan elenmemeli.");
        }

        private static void Check(bool condition, string message)
        {
            if (!condition)
                throw new Exception(message);
        }
    }
}
