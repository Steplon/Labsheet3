using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Members
{
    class Member
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime DateJoined { get; set; }

        public Member(string name, string type, string dateJoined)
        {
            Name = name;
            Type = type;
            DateJoined = DateTime.Parse(dateJoined);
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", Name, Type, DateJoined.ToShortDateString());
        }

    }
}
