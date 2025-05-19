using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCenter
{
    internal class BlockageTeam : EmergencyTeam
    {
        public BlockageTeam(string teamName, string location) : base(teamName, location)
        {
        }
        public override bool CanHandle(EmergencyReport report)
        {
            if (report.zone == location && isAvailable &&  report.incidentType.Contains("Blockage"))
            {
                return true;
            }
            return false;
        }
        public override void Handle(EmergencyReport report)
        {
            Console.WriteLine("Blockage Team sent to " + report.zone);


        }
    }
}
