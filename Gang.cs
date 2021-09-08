using System.Collections.Generic;

namespace plan_your_heist
{
    public class Gang
    {
        public string Name { get; set; }

        public int GangSkill { get; set; }

        public List<Member> Members { get; set; }

        public Gang(string name)
        {
            Name = name;
            Members = new List<Member>();
            GangSkill = 0;
        }
       
    }
}