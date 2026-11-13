using Microsoft.Data.SqlClient;

namespace MariamTchubabriaMidterm
{
    public class AlbumRepository
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MusicCatalogueDb;" +
            "Integrated Security=True;TrustServerCertificate=True";

        // An empty text or genre means "do not narrow the list by this value".
        public List<Album> Search(string text, string genre)
        {
            List<Album> albums = new List<Album>();
            string sql =
                "SELECT Id, Title, Artist, Genre, ReleaseYear, TrackCount, DurationMinutes " +
                "FROM Albums " +
                "WHERE (@text = N'' OR Title LIKE @pattern OR Artist LIKE @pattern) " +
                "  AND (@genre = N'' OR Genre = @genre) " +
                "ORDER BY Title";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@text", text);
                command.Parameters.AddWithValue("@pattern", "%" + text + "%");
                command.Parameters.AddWithValue("@genre", genre);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Album album = new Album();
                        album.Id = (int)reader["Id"];
                        album.Title = (string)reader["Title"];
                        album.Artist = (string)reader["Artist"];
                        album.Genre = (string)reader["Genre"];
                        album.ReleaseYear = (int)reader["ReleaseYear"];
                        album.TrackCount = (int)reader["TrackCount"];
                        album.DurationMinutes = (int)reader["DurationMinutes"];
                        albums.Add(album);
                    }
                }
            }
            return albums;
        }

        public int CountAll()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Albums", connection))
            {
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public void Add(Album album)
        {
            string sql =
                "INSERT INTO Albums (Title, Artist, Genre, ReleaseYear, TrackCount, DurationMinutes) " +
                "VALUES (@title, @artist, @genre, @releaseYear, @trackCount, @durationMinutes)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                AddAlbumValues(command, album);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Album album)
        {
            string sql =
                "UPDATE Albums " +
                "SET Title = @title, Artist = @artist, Genre = @genre, ReleaseYear = @releaseYear, " +
                "    TrackCount = @trackCount, DurationMinutes = @durationMinutes " +
                "WHERE Id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                AddAlbumValues(command, album);
                command.Parameters.AddWithValue("@id", album.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM Albums WHERE Id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Add and Update send the same six values, so they share this method.
        private void AddAlbumValues(SqlCommand command, Album album)
        {
            command.Parameters.AddWithValue("@title", album.Title);
            command.Parameters.AddWithValue("@artist", album.Artist);
            command.Parameters.AddWithValue("@genre", album.Genre);
            command.Parameters.AddWithValue("@releaseYear", album.ReleaseYear);
            command.Parameters.AddWithValue("@trackCount", album.TrackCount);
            command.Parameters.AddWithValue("@durationMinutes", album.DurationMinutes);
        }
    }
}
