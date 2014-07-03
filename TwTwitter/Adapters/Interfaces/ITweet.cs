using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwTwitter.Data.Models;
using TwTwitter.Models;

namespace TwTwitter.Adapters.Interfaces
{
    public interface ITweet
    {
        TweetVM GetTweet(int id);
        List<TweetVM> GetTweets(int author);
        int CreateTweet(Tweet tweet);
        void DeleteTweet(int id);
    }
}
