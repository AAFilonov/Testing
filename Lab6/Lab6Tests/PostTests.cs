using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Tests
{
    [TestClass()]
    public class PostTests
    {
        [TestMethod()]
        public void CountRatingTCountRatingTest()
        {
            var post = new Post()
            {
                Author = "Auth",
                Date = DateTime.Now,
                Message = "123abc"
            };

            var rez = post.CountRating();
            Assert.AreEqual(2 ,rez);


            post.Message = "123";
            rez = post.CountRating();
            Assert.AreEqual(0.5, rez );


            post.Message = "abc";
            rez = post.CountRating();
            Assert.AreEqual(2, rez);

            post.Message = "";
            rez = post.CountRating();
            Assert.AreEqual(0, rez);


            post.Message = "a a";
            rez = post.CountRating();
            Assert.AreEqual(2, rez);

            post.Message = "aa aa";
            rez = post.CountRating();
            Assert.AreEqual(3, rez);
        }

        

    }
}