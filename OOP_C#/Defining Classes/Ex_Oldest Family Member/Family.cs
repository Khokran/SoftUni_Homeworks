﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            familyMembers = new List<Person>();
        }
        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            Person olderPerson = familyMembers.OrderByDescending(p => p.Age).FirstOrDefault();
            return olderPerson;
        }
    }
}
