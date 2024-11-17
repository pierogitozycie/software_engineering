using System;
using System.Linq;
using System.Text;


namespace Forum_Comments_CommandPattern
{

    class Program
    {
        static void Main(string[] args)
        {

            Forum forum = new Forum();
            Moderator moderator = new Moderator();
            User user = new User();

            WriteComment comment1 = new WriteComment(forum, moderator, "Ania21", "Hej! Nazywam się Ania, witam Was wszytskich!");
            WriteComment comment2 = new WriteComment(forum, moderator, "Ania21", "Lubie pomidor");
            WriteComment comment3 = new WriteComment(forum, moderator, "Ania21", "Lubie też sport");

            user.PlaceCommand(comment1);
            user.PlaceCommand(comment2);
            user.PlaceCommand(comment3);

            user.ExecuteAllCommands();
        }
    }
}
