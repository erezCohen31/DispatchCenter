using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCenter
{
    internal class EmergencyReport
    {
        public string incidentType { get; set; }
        public string zone { get; set; }
        public int severity { get; set; }
        public int duration { get; set; }
        public string description { get; set; }

        public EmergencyReport(string incidentType, string zone, int severity, int duration, string descripion)
        {
            this.incidentType = incidentType;
            this.zone = zone;
            this.severity = severity;
            this.duration = duration;
            this.description = descripion;
        }
    }
}
