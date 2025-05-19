using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCenter
{
    internal class Dispatch
    {
        List<EmergencyTeam> emergencyTeams = new List<EmergencyTeam>();

        public Dispatch(List<EmergencyTeam> teams)
        {
            emergencyTeams = teams;
        }

        public void AddEmergencyTeam(EmergencyTeam team)
        {
            emergencyTeams.Add(team);
        }
        public void RemoveEmergencyTeam(EmergencyTeam team)
        {
            emergencyTeams.Remove(team);
        }
        public void DispatchEmergencyTeam(EmergencyReport report)
        {
            foreach (EmergencyTeam team in emergencyTeams)
            {
                if (team.CanHandle(report))
                {
                    team.Handle(report);
                    team.isAvailable = false;
                    return;
                }
               
            }
        }

    }
}
