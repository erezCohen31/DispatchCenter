using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispatchCenter
{
    internal class EmergencyTeam
    {
        public string teamName { get; set; }
        public string location { get; set; }
        public bool isAvailable { get; set; }

        public EmergencyTeam(string teamName, string location)
        {
            this.teamName = teamName;
            this.location = location;
            this.isAvailable = true;
        }
        public virtual bool CanHandle(EmergencyReport report)
        {
            
            return false;
        }
        public virtual void Handle(EmergencyReport report)
        {
            Console.WriteLine("cannot respond");
        }
    }
}
