using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RdyGaming
{
    public class Team : IEnumerable
    {
        public List<Player> PlayerList = new List<Player>() 
        {
            new Player(){Name = "Karthik", RunsScored = 17721},
            new Player(){Name = "Neeraj", RunsScored = 15000},
            new Player(){Name = "Purush", RunsScored = 15555},
        };

        public IEnumerator GetEnumerator()
        {
            return PlayerList.GetEnumerator();
        }

        //public IEnumerable<Player> GetAllCustomer()
        //{
        //    return PlayerList;
        //}
    }
}
