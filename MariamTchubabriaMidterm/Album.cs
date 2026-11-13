namespace MariamTchubabriaMidterm
{
    public class Album
    {
        // Albums at least this long are highlighted in the grid.
        public const int LongAlbumMinutes = 60;

        // The categories offered by the genre filter and by the dialog.
        public static readonly string[] Genres =
        {
            "Metal", "Rock", "Alternative", "Christian Rock", "Pop", "Georgian"
        };

        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int TrackCount { get; set; }
        public int DurationMinutes { get; set; }

        // calculated: not a column, worked out from DurationMinutes
        public string LengthCategory
        {
            get
            {
                if (DurationMinutes >= LongAlbumMinutes)
                    return "Long";
                if (DurationMinutes >= 40)
                    return "Standard";
                return "Short";
            }
        }
    }
}
