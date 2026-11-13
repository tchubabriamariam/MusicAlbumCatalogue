using System.Globalization;
using System.Text;
using Microsoft.Data.SqlClient;

namespace MariamTchubabriaMidterm
{
    public partial class MainForm : Form
    {
        private readonly AlbumRepository repository = new AlbumRepository();

        public MainForm()
        {
            InitializeComponent();
            dgvAlbums.AutoGenerateColumns = false;
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath); // the icon of the .exe
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Without the database the program cannot do anything, so say why and stop.
            try
            {
                repository.CountAll();
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot open the database. Run database.sql first (see README.md).",
                    "Music Album Catalogue");
                Close();
                return;
            }

            cmbGenreFilter.Items.Add("All");
            cmbGenreFilter.Items.AddRange(Album.Genres);
            cmbGenreFilter.SelectedIndex = 0; // fires SelectedIndexChanged, which loads the grid
        }

        // Search and filter both go to one query, so they always work together.
        private void LoadAlbums()
        {
            string searchText = txtSearch.Text.Trim();
            string genre = cmbGenreFilter.SelectedIndex == 0 ? "" : cmbGenreFilter.Text;

            List<Album> albums = repository.Search(searchText, genre);
            dgvAlbums.DataSource = albums;

            if (albums.Count == 0)
                lblCount.Text = "No albums match your search.";
            else
                lblCount.Text = "Showing " + albums.Count + " of " + repository.CountAll() + " albums";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAlbums();
        }

        private void cmbGenreFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAlbums();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AlbumForm form = new AlbumForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repository.Add(form.CurrentAlbum);

                    // Clear the search and filter so the new album is visible in the grid.
                    txtSearch.Text = "";
                    cmbGenreFilter.SelectedIndex = 0;
                    LoadAlbums();
                    lblStatus.Text = "Album added.";
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSelectedAlbum();
        }

        private void dgvAlbums_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // -1 means the double-click was on a column header
                EditSelectedAlbum();
        }

        private void EditSelectedAlbum()
        {
            if (dgvAlbums.CurrentRow == null)
            {
                MessageBox.Show("Please select an album first.", "Edit album");
                return;
            }
            Album selectedAlbum = (Album)dgvAlbums.CurrentRow.DataBoundItem;

            using (AlbumForm form = new AlbumForm(selectedAlbum))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repository.Update(form.CurrentAlbum);
                    LoadAlbums();
                    lblStatus.Text = "Album updated.";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAlbums.CurrentRow == null)
            {
                MessageBox.Show("Please select an album first.", "Delete album");
                return;
            }
            Album selectedAlbum = (Album)dgvAlbums.CurrentRow.DataBoundItem;

            DialogResult answer = MessageBox.Show(
                "Delete \"" + selectedAlbum.Title + "\" by " + selectedAlbum.Artist + "?",
                "Delete album", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (answer == DialogResult.Yes)
            {
                repository.Delete(selectedAlbum.Id);
                LoadAlbums();
                lblStatus.Text = "Album deleted.";
            }
        }

        // The visual rule: long albums get a coloured row.
        private void dgvAlbums_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Album album = dgvAlbums.Rows[e.RowIndex].DataBoundItem as Album;
            if (album != null && album.DurationMinutes >= Album.LongAlbumMinutes)
                e.CellStyle.BackColor = lblLegend.BackColor;
        }

        // Bonus: saves the rows currently shown in the grid.
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvAlbums.Rows.Count == 0)
            {
                MessageBox.Show("There are no albums to export.", "Export");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV file (*.csv)|*.csv";
                dialog.FileName = "albums.csv";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    File.WriteAllLines(dialog.FileName, BuildCsvLines(), Encoding.UTF8);
                    lblStatus.Text = "Exported " + dgvAlbums.Rows.Count + " albums.";
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot write the file. If it is open in Excel, close it and try again.",
                        "Export");
                }
            }
        }

        private List<string> BuildCsvLines()
        {
            // Excel splits columns by the separator of the Windows region settings.
            string separator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

            List<string> lines = new List<string>();
            lines.Add("Title" + separator + "Artist" + separator + "Genre" + separator + "Year" +
                separator + "Tracks" + separator + "Minutes" + separator + "Length");

            foreach (DataGridViewRow row in dgvAlbums.Rows)
            {
                Album album = (Album)row.DataBoundItem;
                lines.Add(CsvText(album.Title, separator) + separator +
                    CsvText(album.Artist, separator) + separator +
                    album.Genre + separator +
                    album.ReleaseYear + separator +
                    album.TrackCount + separator +
                    album.DurationMinutes + separator +
                    album.LengthCategory);
            }
            return lines;
        }

        // Text containing the separator or a quote must be wrapped in quotes,
        // and a quote inside it is written twice.
        private string CsvText(string text, string separator)
        {
            if (text.Contains(separator) || text.Contains('"'))
                return "\"" + text.Replace("\"", "\"\"") + "\"";
            return text;
        }
    }
}
