using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDeveloperTeam
{
    public class DevTeamRepo
    {
        protected readonly List<Developer> _contentDirectory = new List<Developer>();

        protected readonly List<DevTeam> _DevTeam = new List<DevTeam>();
        //Create
        public bool AddContentToDirectory(DevTeam newContent)
        {
            int startingCount = _DevTeam.Count;
            _DevTeam.Add(newContent);
            bool wasAdded = (_DevTeam.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Read
        public List<DevTeam> GetContents()
        {
            return _DevTeam;
        }
        public DevTeam GetContentByID(string id)
        {
            foreach (DevTeam content in _DevTeam)
            {
                if (content.DeveloperId == id)
                {
                    return content;
                }
                else
                {
                    Console.WriteLine("I am sorry but no results could be found for that ID number");
                }
            }
            return null;
        }
        //Update
        public bool UpdateTeams(string originalId, DevTeam newContent)
        {
            DevTeam oldContent = GetContentByID(originalId);
            if (oldContent != null)
            {
                oldContent.DeveloperId = newContent.DeveloperId;
                //oldContent.PluralSightAccess = newContent.PluralSightAccess;
                oldContent.DeveloperName = newContent.DeveloperName;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Developer GetDeveloperByID(string id)
        {
            foreach(Developer member in _contentDirectory)
            {
                if (member.Id == id)
                {
                    return member;
                }
            }
            return null;
        }
        //Delete
        public bool RemoveDeveloper(string developerId)
        {
            Developer oldMember = GetDeveloperByID(developerId);
            bool result = _contentDirectory.Remove(oldMember);
            return result;
        }
    }
}

