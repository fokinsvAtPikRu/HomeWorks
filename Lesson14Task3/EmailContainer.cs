using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson14Task3
{
    internal class EmailContainer:IEnumerable
    {
        private HashSet<string> _emails;
        public EmailContainer()
        {
            _emails = new HashSet<string>();
        }
        public EmailContainer(HashSet<string> emails)
        {
            _emails = emails;
        }

        private bool EmailIsCorrect(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(email, pattern))
                return true;
            else return false;
        }
        public bool Add(string email)
        {
            if (EmailIsCorrect(email))
            {
                return _emails.Add(email);
            }
            return false;
        }
        public bool Contains(string email) => _emails.Contains(email);
        public void UnionWith(EmailContainer other)
        {
            _emails.UnionWith(other._emails);
        }
        public EmailContainer IntersectWith(EmailContainer other)
        {
            var result=new HashSet<string>(_emails);
            result.IntersectWith(other._emails);
            return new EmailContainer(result);
        }
        public int Count => _emails.Count;
        public bool Remove(string email)
        {
            if (EmailIsCorrect(email))
                return _emails.Remove(email);
            return false;
        }
        public bool IsSubsetOf(EmailContainer other) => _emails.IsProperSubsetOf(other._emails);
        public void Clear()
        { _emails.Clear(); }

        public IEnumerator GetEnumerator() => _emails.GetEnumerator();
    }
}
