using System;
using System.Collections.Generic;
using DispatchCenter;

namespace EmergencyDispatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Créer les équipes
            var teams = new List<EmergencyTeam>
            {
                new FloodTeam("FloodTeam Alpha", "North"),
                new InjurieTeam("InjuryTeam Bravo", "East"),
                new BlockageTeam("BlockageTeam Charlie", "North")
            };

            // Créer un rapport d'urgence
            var report = new EmergencyReport(
                incidentType: "Flood",
                zone: "North",
                severity: 6,
                duration: 120,
                descripion: "Heavy rain flooded the street"
            );

            // Lancer le centre de dispatch
            var center = new Dispatch(teams);
            center.DispatchEmergencyTeam(report);
        }
    }
}
