namespace AnyAnyAnyRoles
{
    public class AbilityTarget
    {
        public int PlayerId { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public bool IsValid { get; set; }

        public AbilityTarget(int playerId, float x, float y)
        {
            PlayerId = playerId;
            X = x;
            Y = y;
            IsValid = true;
        }

        public void Invalidate()
        {
            IsValid = false;
        }
    }
}