namespace MariamTchubabriaMidterm
{
    public partial class AlbumForm : Form
    {
        // The values from the dialog. MainForm reads this after Save.
        public Album CurrentAlbum { get; } = new Album();

        // Add: an empty dialog.
        public AlbumForm()
        {
            InitializeComponent();
            cmbGenre.Items.AddRange(Album.Genres);
            numReleaseYear.Value = DateTime.Today.Year;
        }

        // Edit: the same dialog, filled in. : this() runs the constructor above first,
        // which creates the controls.
        public AlbumForm(Album album) : this()
        {
            Text = "Edit album";
            CurrentAlbum.Id = album.Id;
            txtTitle.Text = album.Title;
            txtArtist.Text = album.Artist;
            cmbGenre.SelectedItem = album.Genre;
            numReleaseYear.Value = album.ReleaseYear;
            numTrackCount.Value = album.TrackCount;
            numDurationMinutes.Value = album.DurationMinutes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter the album title.", "Check the album");
                txtTitle.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtArtist.Text))
            {
                MessageBox.Show("Please enter the artist.", "Check the album");
                txtArtist.Focus();
                return;
            }
            if (cmbGenre.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a genre.", "Check the album");
                cmbGenre.Focus();
                return;
            }
            // Our own rule: an album cannot come from the future.
            if ((int)numReleaseYear.Value > DateTime.Today.Year)
            {
                MessageBox.Show("The release year cannot be in the future.", "Check the album");
                numReleaseYear.Focus();
                return;
            }

            CurrentAlbum.Title = txtTitle.Text.Trim();
            CurrentAlbum.Artist = txtArtist.Text.Trim();
            CurrentAlbum.Genre = cmbGenre.Text;
            CurrentAlbum.ReleaseYear = (int)numReleaseYear.Value;
            CurrentAlbum.TrackCount = (int)numTrackCount.Value;
            CurrentAlbum.DurationMinutes = (int)numDurationMinutes.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
