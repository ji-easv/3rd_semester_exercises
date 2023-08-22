using System.ComponentModel.DataAnnotations;
using Dapper;
using FluentAssertions;
using NUnit.Framework;

namespace gettingstarted.week34.prg_1_Dapper.Exercises;

[TestFixture]
public class UserWithMostBooks {
    public EndUser GetUserWithMostBooksInReadingList()
    {
        var sql = @$"SELECT
            email AS {nameof(EndUser.Email)},
            status  AS {nameof(EndUser.Status)},
            end_user_id AS {nameof(EndUser.EndUserId)},
            password_hash AS {nameof(EndUser.PasswordHash)},
            salt AS {nameof(EndUser.Salt)},
            role AS {nameof(EndUser.Role)},
            profile_img_url AS {nameof(EndUser.ProfileImgUrl)}
        FROM library.end_users
        JOIN library.reading_list_items ON (end_users.end_user_id = reading_list_items.user_id)
        GROUP BY user_id, email, status, end_user_id, password_hash, salt, role, profile_img_url
        ORDER BY COUNT(book_id) DESC
        LIMIT 1;";
        
        using (var conn = Helper.DataSource.OpenConnection())
        {
            return conn.QueryFirst<EndUser>(sql);
        }
    }

    [Test]
    public void GetUserWithMostBooksInReadingListTest()
    {
        //Arrange
        Helper.TriggerRebuild();
        var users = new List<EndUser>();
        var books = new List<Book>();
        
        for (int i = 1; i <= 10; i++)
        {
            books.Add(Helper.MakeRandomBookWithId(i));
            users.Add(Helper.MakeRandomUserWithId(i));
        }
        
        var insertBooks =
            "INSERT INTO library.books (title, publisher, cover_img_url) VALUES (@title, @publisher, @coverImgUrl);";
        var insertUsers = 
            @"INSERT INTO library.end_users (email, status, password_hash, salt, role, profile_img_url) 
                VALUES (@email, @status, @passwordHash, @salt, @role, @profileImgUrl);";
        var insertLink =
            "INSERT INTO library.reading_list_items(user_id, book_id) VALUES (@userId, @bookId);";

        using (var conn = Helper.DataSource.OpenConnection())
        {
            conn.Execute(insertUsers, users);
            conn.Execute(insertBooks, books);

            // books & users [1, 2, 3...8, 9, 10]
            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < users.Count - i ; j++)
                {
                    conn.Execute(insertLink, new {userId = users[i].EndUserId, bookId = books[j].BookId});
                }
            }
        }
        
        //Act
        var actual = GetUserWithMostBooksInReadingList();
        
        //Assert
        actual.Should().BeEquivalentTo(users[0]);
    }
}