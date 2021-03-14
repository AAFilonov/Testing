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
        public void CountRating_ins_emptystring_ret_0()
        {
            // arrange
            var post = new Post();
            post.Message = "";
            var expected = 0;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountRating_ins_123abc_ret_2()
        {
            // arrange
            var post = new Post();
            post.Message = "123abc";
            var expected = 2;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountRating_ins_123_ret_0_5()
        {
            // arrange
            var post = new Post();
            post.Message = "123";
            var expected = 0.5;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountRating_ins_1_1_1_1_ret_0()
        {
            // arrange
            var post = new Post();
            post.Message = "1 1 1 1";
            var expected = 0;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountRating_ins_a_a_ret_2()
        {
            // arrange
            var post = new Post();
            post.Message = "a a";
            var expected = 0;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}