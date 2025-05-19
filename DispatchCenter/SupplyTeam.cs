using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCenter
{
    internal class SupplyTeam : EmergencyTeam
    {
        public SupplyTeam(string teamName, string location) : base(teamName, location)
        {
        }
        public override bool CanHandle(EmergencyReport report)
        {
            if (report.zone == location && isAvailable && report.incidentType.Contains( "Shortage"))
            {
                return true;
            }
            return false;
        }
        public override void Handle(EmergencyReport report)
        {
            Console.WriteLine("Supply Team sent to " + report.zone);
        }
    }
}
