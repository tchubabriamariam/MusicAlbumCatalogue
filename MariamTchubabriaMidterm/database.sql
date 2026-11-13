IF DB_ID(N'MusicCatalogueDb') IS NULL
    CREATE DATABASE MusicCatalogueDb;
GO
USE MusicCatalogueDb;
GO
IF OBJECT_ID(N'dbo.Albums', N'U') IS NULL
CREATE TABLE Albums
(
    Id              INT IDENTITY(1,1) PRIMARY KEY,
    Title           NVARCHAR(150) NOT NULL,   -- searched
    Artist          NVARCHAR(100) NOT NULL,   -- searched
    Genre           NVARCHAR(50)  NOT NULL,   -- the column we filter by
    ReleaseYear     INT           NOT NULL,
    TrackCount      INT           NOT NULL,
    DurationMinutes INT           NOT NULL
);
GO
IF NOT EXISTS (SELECT 1 FROM Albums)
INSERT INTO Albums (Title, Artist, Genre, ReleaseYear, TrackCount, DurationMinutes)
VALUES
    (N'Slipknot',                           N'Slipknot',             N'Metal',          1999, 15, 60),
    (N'Iowa',                               N'Slipknot',             N'Metal',          2001, 14, 66),
    (N'Vol. 3: The Subliminal Verses',      N'Slipknot',             N'Metal',          2004, 14, 63),
    (N'Ride the Lightning',                 N'Metallica',            N'Metal',          1984,  8, 47),
    (N'Master of Puppets',                  N'Metallica',            N'Metal',          1986,  8, 55),
    (N'The Black Album',                    N'Metallica',            N'Metal',          1991, 12, 63),
    (N'The Number of the Beast',            N'Iron Maiden',          N'Metal',          1982,  8, 39),
    (N'Piece of Mind',                      N'Iron Maiden',          N'Metal',          1983,  9, 45),
    (N'Powerslave',                         N'Iron Maiden',          N'Metal',          1984,  8, 51),
    (N'A Night at the Opera',               N'Queen',                N'Rock',           1975, 12, 43),
    (N'News of the World',                  N'Queen',                N'Rock',           1977, 11, 39),
    (N'The Game',                           N'Queen',                N'Rock',           1980, 10, 35),
    (N'Slippery When Wet',                  N'Bon Jovi',             N'Rock',           1986, 10, 43),
    (N'New Jersey',                         N'Bon Jovi',             N'Rock',           1988, 12, 57),
    (N'Hybrid Theory',                      N'Linkin Park',          N'Alternative',    2000, 12, 38),
    (N'Meteora',                            N'Linkin Park',          N'Alternative',    2003, 13, 36),
    (N'I Love You.',                        N'The Neighbourhood',    N'Alternative',    2013, 11, 44),
    (N'Wiped Out!',                         N'The Neighbourhood',    N'Alternative',    2015, 12, 46),
    (N'The Flame in All of Us',             N'Thousand Foot Krutch', N'Christian Rock', 2007, 12, 44),
    (N'Welcome to the Masquerade',          N'Thousand Foot Krutch', N'Christian Rock', 2009, 13, 46),
    (N'Comatose',                           N'Skillet',              N'Christian Rock', 2006, 11, 40),
    (N'Awake',                              N'Skillet',              N'Christian Rock', 2009, 12, 44),
    (N'Thriller',                           N'Michael Jackson',      N'Pop',            1982,  9, 42),
    (N'Bad',                                N'Michael Jackson',      N'Pop',            1987, 11, 49),
    (N'Dangerous',                          N'Michael Jackson',      N'Pop',            1991, 14, 77),
    (N'ქეთო და კოტე — სიმღერების პოპური',   N'ვიქტორ დოლიძე',        N'Georgian',       1948,  1, 12),
    (N'ანსამბლი შვიდკაცა',                       N'უცნობი შემსრულებელი',  N'Georgian',       2000,  1,  4);
GO
