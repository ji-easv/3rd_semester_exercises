using Dapper;
using FluentAssertions;
using NUnit.Framework;

namespace gettingstarted.week34.prg_1_Dapper.Exercises;

[TestFixture]
public class CountNumberOfBooksByAuthor
{
    public int CountBooksByAuthor(int authorId)
    {
        var sql = "SELECT COUNT(*) FROM library.author_wrote_book_items WHERE author_id = @authorId";

        using (var conn = Helper.DataSource.OpenConnection())
        {
            return conn.QueryFirst<int>(sql, new { authorId });
        }
    }

    [Test]
    public void CountBooksByAuthorTest()
    {
        //Arrange
        Helper.TriggerRebuild();
        var author = Helper.MakeRandomAuthorWithId(1);
        var books = new List<Book>();

        for (int i = 1; i <= 5; i++)
        {
            books.Add(Helper.MakeRandomBookWithId(i));
        }
        
        var insertBooks =
            "INSERT INTO library.books (title, publisher, cover_img_url) VALUES (@title, @publisher, @coverImgUrl);";
        var insertAuthor = 
            "INSERT INTO library.authors(name, birthday, nationality) VALUES (@name, @birthday, @nationality);";
        var insertLink =
            "INSERT INTO library.author_wrote_book_items(author_id, book_id) VALUES (@authorId, @bookId);";

        using (var conn = Helper.DataSource.OpenConnection())
        {
            conn.Execute(insertAuthor, author);
            conn.Execute(insertBooks, books);

            foreach (var book in books)
            {
                conn.Execute(insertLink, new {author.AuthorId, book.BookId});
            }
        }
        
        //Act
        int actual = CountBooksByAuthor(1);
        
        //Assert
        using (var conn = Helper.DataSource.OpenConnection())
        {
            var booksByAuthor =
                conn.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM library.author_wrote_book_items WHERE author_id = @authorId;",
                    new { authorId = author.AuthorId });
            (actual).Should().Be(5);
        }
    }
}