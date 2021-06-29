using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDeveloperTeam
{
    public class DevTeam
    {
        public string DeveloperName { get; set; }
        public string DeveloperId { get; set; }
        public bool PluralSightAccess { get; set; }
        public string TeamName { get; set; }
        public string TeamId { get; set; }

        public DevTeam() { }
        public DevTeam(string name, string id, bool pluralSightAccess, string teamName, string teamId)
        {
            DeveloperName = name;
            DeveloperId = id;
            PluralSightAccess = pluralSightAccess;
            TeamName = teamName;
            TeamId = teamId;
        }
    }
}