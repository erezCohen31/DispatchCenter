using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCenter
{
    internal class FloodTeam : EmergencyTeam
    {
        public FloodTeam(string teamName, string location) : base(teamName, location)
        {
        }

        public override bool CanHandle(EmergencyReport report)
        {
            if (report.zone == location && isAvailable&& report.incidentType.Contains("Flood"))
            {
                return true;
            }
            return false;
        }
        public override void Handle(EmergencyReport report)
        {
            Console.WriteLine("Flood Team sent to " + report.zone);


        }

    }
}
