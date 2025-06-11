using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14Task1
{
    internal class TeammateList
    {
        private List<string> teammates;
        public int Count => teammates.Count;
        public TeammateList()
        { teammates = new List<string>(); }
        public void AddTeammate(string name)
        { teammates.Add(name); }
        public void AddTeammate(string name, int index)
        {
            if (index < teammates.Count && index >= 0)
                teammates.Insert(index, name);
            else
                throw new ArgumentOutOfRangeException();
        }
        public bool ContainsTeammate(string name) =>
            teammates.Contains(name);

        public bool RemoveTeammate(string name) =>
            teammates.Remove(name);
        public int IndexOf(string name) =>
             teammates.IndexOf(name);
        public void Sort()
        { teammates.Sort(); }
        public string[] ToArray() =>
            teammates.ToArray(); 
        public void Clear()
        { teammates.Clear(); }
        public bool IsEmpty() => 
            teammates.Count == 0;
        
    }
}
