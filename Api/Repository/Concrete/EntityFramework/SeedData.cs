using Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {


        public static void Seed(this ModelBuilder modelBuilder)
        {

            



            //modelBuilder.Entity<User>().HasData(
            //    new User() { Id=1,Name="Jean",Email="Jean@gmail.com",Password="Jean123"},
            //    new User() { Id = 2, Name = "Anna", Email = "Anna@gmail.com", Password = "Anna123" },
            //    new User() { Id = 3, Name = "Jon", Email = "Jon@gmail.com", Password = "Jon123" },
            //    new User() { Id = 4, Name = "Alison", Email = "Alison@gmail.com", Password = "Alison123" },
            //    new User() { Id = 5, Name = "Mike", Email = "Mike@gmail.com", Password = "Mike123" },
            //    new User() { Id = 6, Name = "Jony", Email = "Jony@gmail.com", Password = "Jony123" },
            //    new User() { Id = 7, Name = "Anastasiya", Email = "Anastasiya@gmail.com", Password = "Anastasiya123" },
            //    new User() { Id = 8, Name = "Coni", Email = "Coni@gmail.com", Password = "Coni123" }
            //    );

            //modelBuilder.Entity<Category>().HasData(
            //    new Category() { Id=1,Name="Tech"},
            //    new Category() { Id = 2, Name = "Animals" },
            //    new Category() { Id = 3, Name = "World" },
            //    new Category() { Id = 4, Name = "Politics" }
            //    );

            //modelBuilder.Entity<Post>().HasData(
            //    new Post() { Id=1, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text ="Post1 Cateogry1 Text asdasdasdasd",Content="Post1",Show=8,CategoryId=1},
            //    new Post() { Id = 2, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post2 Category1 Text dfgfdgfgfgfdgfd", Content = "Post2", Show = 8, CategoryId = 1 },
            //    new Post() { Id = 3, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post3 Category1 Text dfgdfgfdgfdgdf", Content = "Post3", Show = 34, CategoryId = 1 },
            //    new Post() { Id = 4, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post4 Category2 Text l,glmtomgormf", Content = "Post4", Show = 5, CategoryId = 2 },
            //    new Post() { Id = 5, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post5 Category2 Text msdfmsl;dfm", Content = "Post5", Show = 234, CategoryId = 2 },
            //    new Post() { Id = 6, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post6 Category3 Text pppp,asd, aas,s", Content = "Post6", Show = 45, CategoryId = 3 },
            //    new Post() { Id = 7, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post7 Category3 Text sadfgkusdstujhhtjh", Content = "Post7", Show = 11, CategoryId = 3 },
            //    new Post() { Id = 8, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post8 Category3 Text jhgmxdnsbdjurt jtg jgf", Content = "Post8", Show = 34, CategoryId = 3 },
            //    new Post() { Id = 9, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post9 Category3 Text scrw356v5e7v6ruvuv", Content = "Post9", Show = 55, CategoryId = 3 },
            //    new Post() { Id = 10, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post10 Category3 Textk9mkuj262626fhfh hfdh", Content = "Post10", Show = 67, CategoryId = 3 },
            //    new Post() { Id = 11, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post11 Category4 Text wweqqwweqqqwe", Content = "Post11", Show = 1, CategoryId = 4 },
            //    new Post() { Id = 12, Time = new DateTime(2008, 3, 1, 14, 0, 0), Text = "Post12 Category4 Text aaaaaagggggggrrrrrrreeeeeeeeeg 343434", Content = "Post12", Show = 90, CategoryId = 4 }
            //    );

            //modelBuilder.Entity<Comment>().HasData(
            //    new Comment() { Id=1,Text="Gozel Post1",UserId=1, Time= new DateTime(2008, 3, 1, 7, 0, 0),PostId=1 },
            //    new Comment() { Id = 2, Text = "Gozel Post1", UserId = 2, Time = new DateTime(2008, 3, 1, 8, 0, 0), PostId = 1 },
            //    new Comment() { Id = 3, Text = "Gozel Post2", UserId = 2, Time = new DateTime(2008, 3, 1, 9, 0, 0), PostId = 2 },
            //    new Comment() { Id = 4, Text = "Gozel Post2", UserId = 3, Time = new DateTime(2008, 3, 1, 10, 0, 0), PostId = 2 },
            //    new Comment() { Id = 5, Text = "Gozel Post2", UserId = 4, Time = new DateTime(2008, 3, 1, 11, 0, 0), PostId = 2 },
            //    new Comment() { Id = 6, Text = "Gozel Post3", UserId = 5, Time = new DateTime(2008, 3, 1, 12, 0, 0), PostId = 3 },
            //    new Comment() { Id = 7, Text = "Gozel Post4", UserId = 1, Time = new DateTime(2008, 3, 1, 13, 0, 0), PostId = 4 },
            //    new Comment() { Id = 8, Text = "Gozel Post4", UserId = 3, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 4 },

            //    new Comment() { Id = 9, Text = "Gozel Post5", UserId = 6, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 5 },
            //    new Comment() { Id = 10, Text = "Gozel Post5", UserId = 7, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 5 },
            //    new Comment() { Id = 11, Text = "Gozel Post5", UserId = 8, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 5 },
            //    new Comment() { Id = 12, Text = "Gozel Post5", UserId = 2, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 5 },
            //    new Comment() { Id = 13, Text = "Gozel Post5", UserId = 1, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 5 },
            //    new Comment() { Id = 14, Text = "Gozel Post5", UserId = 3, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 5 },
            //    new Comment() { Id = 15, Text = "Gozel Post5", UserId = 4, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 5 },
            //    new Comment() { Id = 16, Text = "Gozel Post5", UserId = 5, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 5 },

            //    new Comment() { Id = 17, Text = "Gozel Post6", UserId = 1, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 18, Text = "Gozel Post6", UserId = 3, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 19, Text = "Gozel Post6", UserId = 5, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 20, Text = "Gozel Post6", UserId = 3, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 21, Text = "Gozel Post6", UserId = 8, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 22, Text = "Gozel Post6", UserId = 5, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 23, Text = "Gozel Post6", UserId = 7, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 24, Text = "Gozel Post6", UserId = 4, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 25, Text = "Gozel Post6", UserId = 3, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 26, Text = "Gozel Post6", UserId = 2, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 27, Text = "Gozel Post6", UserId = 4, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 28, Text = "Gozel Post6", UserId = 5, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 29, Text = "Gozel Post6", UserId = 6, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 30, Text = "Gozel Post6", UserId = 1, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 31, Text = "Gozel Post6", UserId = 3, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 },
            //    new Comment() { Id = 32, Text = "Gozel Post6", UserId = 6, Time = new DateTime(2008, 3, 1, 14, 0, 0), PostId = 6 }
            //    );


        }

    }
}
