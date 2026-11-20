using System;

namespace AnyAnyAnyRoles
{
    public static class AbilityExecutor
    {
        public static AbilityExecutionResult Execute(
            int playerId,
            RoleAbility ability,
            RoleAbilityManager manager)
        {
            if (ability == null)
                return AbilityExecutionResult.Failed("Yetenek bulunamadı.");

            if (manager == null)
                return AbilityExecutionResult.Failed("Yetenek yöneticisi bulunamadı.");

            if (!RoleAbilityValidator.IsValid(ability))
                return AbilityExecutionResult.Failed("Yetenek geçersiz.");

            if (!manager.CanUseAbility(playerId, ability))
                return AbilityExecutionResult.Failed("Yetenek henüz kullanılamıyor.");

            manager.StartCooldown(playerId, ability);

            return AbilityExecutionResult.Successful(
                ability.Name + " kullanıldı!"
            );
        }
    }
}