using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceDeveloperTeam
{
    public class DeveloperRepo 
    {
        protected readonly List<Developer> _contentDirectory = new List<Developer>();
        //Create
        public bool AddContentToDirectory(Developer newContent)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(newContent);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Read
        public List<Developer> GetContents()
        {
            return _contentDirectory;
        }
        public Developer GetContentByID(string id)
        {
            foreach (Developer content in _contentDirectory)
            {
                if (content.Id == id)
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
        public bool UpdateExistingContent(string originalId, Developer newContent)
        {
            Developer oldContent = GetContentByID(originalId);
            if (oldContent != null)
            {
                oldContent.Id= newContent.Id;
                oldContent.PluralSightAccess = newContent.PluralSightAccess;
                oldContent.Name = newContent.Name;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
        public bool DeleteExistingContent(Developer existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}


