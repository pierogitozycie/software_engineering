using System;
using System.Security.Authentication;

namespace Forum_Comments_CommandPattern
{

    public class Forum
    {
        public void WriteComment(string UserID, string message)
        {

            Console.WriteLine("Komenatrz użytkowanika {0}: {1}", UserID, message);

        }
    }
    
}


