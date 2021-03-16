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
        //не зависят от формулы:
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

        //зависят от формулы:
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
            var expected = 2;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountRating_ins_a_a_ret_2()
        {
            //количество слов равно количеству букв
            // arrange
            var post = new Post();
            post.Message = "a a";
            var expected = 2;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountRating_ins_a_a_a_ret_3()
        {
            //количество слов равно количеству букв
            // arrange
            var post = new Post();
            post.Message = "a a a";
            double expected = 3;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountRating_ins_numbs_ten_letters_ret_5_5()
        {
            // arrange
            var post = new Post();
            post.Message = "abcdeabcde";
            var expected = 5.5;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountRating_ins_numbs_1to10_ret_10()
        {
            // arrange
            var post = new Post();
            post.Message = "1 2 3 4 5 6 7 8 9 10";
            var expected = 5;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountRating_ins_semicolon_split_1_1_ret_1()
        {
            // arrange
            var post = new Post();
            post.Message = "1;1";
            var expected = 1;

            // act
            var actual = post.CountRating();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}