using Dapper;
using FluentAssertions;
using NUnit.Framework;

namespace gettingstarted.week34.prg_1_Dapper.Exercises;

[TestFixture]
public class GetTopFiveBooks {
    public IEnumerable<Book> GetTopBooks()
    {
        var sql = @$"SELECT
            books.book_id AS {nameof(Book.BookId)},
            title  AS {nameof(Book.Title)},
            publisher AS {nameof(Book.Publisher)},
            cover_img_url AS {nameof(Book.CoverImgUrl)}
        FROM library.books
        JOIN library.reading_list_items ON (books.book_id = reading_list_items.book_id)
        GROUP BY books.book_id
        ORDER BY COUNT(user_id) DESC
        LIMIT 5;";
        
        using (var conn = Helper.DataSource.OpenConnection())
        {
            return conn.Query<Book>(sql);
        }
    }

    [Test]
    public void GetTopBooksTest()
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

        var topBooks = new List<Book>() { books[0], books[1], books[2], books[3], books[4]};
        
        //Act
        var actual = GetTopBooks();
        
        //Assert
        actual.Should().BeEquivalentTo(topBooks);
    }
}