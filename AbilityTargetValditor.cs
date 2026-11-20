namespace AnyAnyAnyRoles
{
    public static class AbilityTargetValidator
    {
        public static bool IsValid(AbilityTarget target)
        {
            if (target == null)
                return false;

            if (!target.IsValid)
                return false;

            if (target.PlayerId < 0)
                return false;

            return true;
        }

        public static bool IsInRange(
            float sourceX,
            float sourceY,
            AbilityTarget target,
            float maxDistance)
        {
            if (!IsValid(target) || maxDistance < 0)
                return false;

            float dx = sourceX - target.X;
            float dy = sourceY - target.Y;

            float distanceSquared = dx * dx + dy * dy;

            return distanceSquared <= maxDistance * maxDistance;
        }
    }
}