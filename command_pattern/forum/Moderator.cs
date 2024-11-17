using System;
using System.Collections.Generic;

namespace Forum_Comments_CommandPattern
{
    public class Moderator
    {

        public bool ModerateComment(string comment)
        {

                if (comment.Contains("pomidor"))
                {
                    // Console.WriteLine("Komentarz odrzucony: zawiera niedozwolone słowo!");
                    return false;
                }

            // Console.WriteLine("Komentarz zatwierdzony przez moderatora.");
            return true;
        }
    }
}
