using Bogus;
using Bogus.DataSets;
using Dapper;
using FluentAssertions;
using NUnit.Framework;

namespace gettingstarted.week34.prg_1_Dapper.Exercises;

[TestFixture]
public class AddAuthorToAuthors
{
    public bool AddAuthorToBook(int authorId, int bookId)
    {
        var sql = @$"INSERT INTO library.author_wrote_book_items (book_id, author_id) VALUES (@bookId, @authorId)";
        
        using (var conn = Helper.DataSource.OpenConnection())
        {
            return conn.Execute(sql, new {bookId, authorId}) == 1;
        }
    }


    [Test]
    public void AddAuthorToBookTest()
    {
        // Arrange
        Helper.TriggerRebuild();
        var author = Helper.MakeRandomAuthorWithId(1);
        var book = Helper.MakeRandomBookWithId(1);
        
        var insertBook =
            "INSERT INTO library.books (title, publisher, cover_img_url) VALUES (@title, @publisher, @coverImgUrl);";
        var insertAuthor = 
            "INSERT INTO library.authors(name, birthday, nationality) VALUES (@name, @birthday, @nationality);";

        using (var conn = Helper.DataSource.OpenConnection())
        {
            conn.Execute(insertAuthor, author);
            conn.Execute(insertBook, book);
        }
        
        // Act
        AddAuthorToBook(1, 1);
        
        // Assert
        using (var conn = Helper.DataSource.OpenConnection())
        {
            var booksByAuthor =
                conn.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM library.author_wrote_book_items WHERE book_id = @bookId AND author_id = @authorId;",
                    new { authorId = author.AuthorId, bookId = book.BookId });
            (booksByAuthor).Should().Be(1);
        }
    }
}