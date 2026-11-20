using System.Collections.Generic;

namespace AnyAnyAnyRoles
{
    public static class DefaultRoles
    {
        public static void RegisterAll()
        {
            RegisterCrewmateRoles();
            RegisterImpostorRoles();
            RegisterNeutralRoles();
        }

        private static void RegisterCrewmateRoles()
        {
            AddRole(1, "Sheriff", RoleCategory.Crewmate,
                RoleTeam.Crewmate, "Şüpheli oyuncuları araştırır.");

            AddRole(2, "Detective", RoleCategory.Crewmate,
                RoleTeam.Crewmate, "İpuçlarını takip eder.");

            AddRole(3, "Engineer", RoleCategory.Crewmate,
                RoleTeam.Crewmate, "Havalandırmaları kullanabilir.");

            AddRole(4, "Medic", RoleCategory.Crewmate,
                RoleTeam.Crewmate, "Oyuncuları koruyabilir.");
        }

        private static void RegisterImpostorRoles()
        {
            AddRole(5, "Viper", RoleCategory.Impostor,
                RoleTeam.Impostor, "Özel sabotaj yeteneklerine sahiptir.");

            AddRole(6, "Assassin", RoleCategory.Impostor,
                RoleTeam.Impostor, "Toplantılarda özel tahmin yeteneğine sahiptir.");

            AddRole(7, "Morphling", RoleCategory.Impostor,
                RoleTeam.Impostor, "Başka oyuncuların görünümünü taklit edebilir.");
        }

        private static void RegisterNeutralRoles()
        {
            AddRole(8, "Jester", RoleCategory.Neutral,
                RoleTeam.Neutral, "Kendine özgü bir kazanma şartı vardır.");

            AddRole(9, "Executioner", RoleCategory.Neutral,
                RoleTeam.Neutral, "Belirlenen hedefle ilgili görevini tamamlamaya çalışır.");

            AddRole(10, "Arsonist", RoleCategory.Neutral,
                RoleTeam.Neutral, "Kendine özgü bir kazanma şartı vardır.");
        }

        private static void AddRole(
            int id,
            string name,
            RoleCategory category,
            RoleTeam team,
            string description)
        {
            RoleInfo role = new RoleInfo(
                id, name, category, team, description);

            if (RoleValidator.IsValid(role))
            {
                RoleDatabase.AddRole(role);
                RoleRegistry.RegisterRole(name);
            }
        }
    }
}