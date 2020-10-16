using System;

namespace MundiCupWEB.Models
{
    public class Team
    {
        //prop
        public string name { get; private set; }

        public int key { get; private set; }
        //ctor        
        public Team(string name, int key)
        {
            this.name = name;
            this.key = key;
            
        }

        public bool Fight(Team team){

            Random rnd = new Random();
            
            return Convert.ToBoolean(rnd.Next(0,1));

        }
        
    }
}