using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDeveloperTeam
{
    public class Developer
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public bool PluralSightAccess { get; set; }

        public Developer() { }
        public Developer(string name, string id, bool pluralSightAccess)
        {
            Name = name;
            Id = id;
            PluralSightAccess = pluralSightAccess;
        }
    }
}
