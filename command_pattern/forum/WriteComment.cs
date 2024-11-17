namespace Forum_Comments_CommandPattern
{

    public class WriteComment : ICommand
    {

        private Moderator _moderator;
        private Forum _forum;
        private string _userID;
        private string _message;

        public WriteComment(Forum forum, Moderator moderator, string userID, string message)
        {
            this._forum = forum;
            this._moderator = moderator;
            this._userID = userID;
            this._message = message;
        }

        public void Execute()
        {
            if(_moderator.ModerateComment(this._message))
            {
                this._forum.WriteComment(this._userID, this._message);
            }
            else
            {
                Console.WriteLine("Komentarz zawiera niedozwolone slowo! Nie zostanie opublikowany");
            }
            
        }
    }
}
