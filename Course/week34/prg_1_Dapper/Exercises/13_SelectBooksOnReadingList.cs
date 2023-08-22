using Dapper;
using FluentAssertions;
using NUnit.Framework;

namespace gettingstarted.week34.prg_1_Dapper.Exercises;

public class SelectBooksOnReadingList
{
    public IEnumerable<Book> SelectBooks(int userId)
    {
        var sql = @$"SELECT 
            books.book_id AS {nameof(Book.BookId)},
            title  AS {nameof(Book.Title)},
            publisher AS {nameof(Book.Publisher)},
            cover_img_url AS {nameof(Book.CoverImgUrl)}
        FROM library.books 
        JOIN library.reading_list_items ON (books.book_id = reading_list_items.book_id)
        WHERE user_id = @userId;";
        
        using (var conn = Helper.DataSource.OpenConnection())
        {
            return conn.Query<Book>(sql, new { userId });
        }
    }

    [Test]
    public void SelectBooksTest()
    {
        //Arrange
        Helper.TriggerRebuild();
        var user = Helper.MakeRandomUserWithId(1);
        var books = new List<Book>();
        for (int i = 1; i <= 5; i++)
        {
            books.Add(Helper.MakeRandomBookWithId(i));
        }
        
        var insertBooks =
            "INSERT INTO library.books (title, publisher, cover_img_url) VALUES (@title, @publisher, @coverImgUrl);";
        var insertUser = 
            @"INSERT INTO library.end_users (email, status, password_hash, salt, role, profile_img_url) 
                VALUES (@email, @status, @passwordHash, @salt, @role, @profileImgUrl);";
        var insertLink =
            "INSERT INTO library.reading_list_items(user_id, book_id) VALUES (@userId, @bookId);";

        using (var conn = Helper.DataSource.OpenConnection())
        {
            conn.Execute(insertUser, user);
            conn.Execute(insertBooks, books);

            foreach (var book in books)
            {
                conn.Execute(insertLink, new {userId = user.EndUserId, book.BookId});
            }
        }
        
        //Act
        var actual = SelectBooks(1);
        
        //Assert
        actual.Should().BeEquivalentTo(books);
    }
}