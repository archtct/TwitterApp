using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwTwitter.Adapters.Interfaces;
using TwTwitter.Data;
using TwTwitter.Data.Models;
using TwTwitter.Models;

namespace TwTwitter.Adapters.Adapters
{
    public class TweetAdapter : ITweet
    {
        public TweetVM GetTweet(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            TweetVM tweet = db.Tweets.Where(t => t.Id == id)
                .Select(
                t => new TweetVM
                {
                    Id = t.Id,
                    Author = t.Author,
                    Message = t.Message
                })
                .FirstOrDefault();
            return tweet;
        }

        public List<TweetVM> GetTweets(int author)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (author == -1)
            {
                return db.Tweets.Select(
                    t => new TweetVM
                    {
                        Id = t.Id,
                        Author = t.Author,
                        Message = t.Message
                    })
                    .ToList();
            }
            else
            {
                List<TweetVM> Tweets = db.
            }
        }

        public int CreateTweet(Tweet tweet)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            db.Tweets.Add(tweet);
            db.SaveChanges();
            return tweet.Id;
        }

        public void DeleteTweet(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Tweet tweet = db.Tweets.Where(t => t.Id == id).FirstOrDefault();
            db.Tweets.Remove(tweet);
            db.SaveChanges();
        }
    }
}