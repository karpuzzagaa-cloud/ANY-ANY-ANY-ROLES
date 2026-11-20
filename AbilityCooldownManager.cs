using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public class AbilityCooldownManager
    {
        private readonly Dictionary<string, int> cooldowns =
            new Dictionary<string, int>();

        private string GetKey(int playerId, int abilityId)
        {
            return playerId + "_" + abilityId;
        }

        public bool CanUse(int playerId, int abilityId)
        {
            int remaining;

            if (cooldowns.TryGetValue(
                GetKey(playerId, abilityId), out remaining))
                return remaining <= 0;

            return true;
        }

        public void Start(int playerId, int abilityId, int seconds)
        {
            if (seconds < 0) return;

            cooldowns[GetKey(playerId, abilityId)] = seconds;
        }

        public void Update(int elapsedSeconds)
        {
            if (elapsedSeconds <= 0) return;

            List<string> keys = new List<string>(cooldowns.Keys);

            foreach (string key in keys)
            {
                cooldowns[key] -= elapsedSeconds;

                if (cooldowns[key] <= 0)
                    cooldowns.Remove(key);
            }
        }

        public int GetRemaining(int playerId, int abilityId)
        {
            int remaining;

            if (cooldowns.TryGetValue(
                GetKey(playerId, abilityId), out remaining))
                return remaining;

            return 0;
        }

        public void Reset()
        {
            cooldowns.Clear();
        }
    }
}