namespace MariamTchubabriaMidterm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblGenreFilter = new Label();
            cmbGenreFilter = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExport = new Button();
            dgvAlbums = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colArtist = new DataGridViewTextBoxColumn();
            colGenre = new DataGridViewTextBoxColumn();
            colReleaseYear = new DataGridViewTextBoxColumn();
            colTrackCount = new DataGridViewTextBoxColumn();
            colDurationMinutes = new DataGridViewTextBoxColumn();
            colLengthCategory = new DataGridViewTextBoxColumn();
            lblCount = new Label();
            lblStatus = new Label();
            lblLegend = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            SuspendLayout();
            //
            // lblSearch
            //
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "🔍";
            //
            // txtSearch
            //
            txtSearch.Location = new Point(44, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by title or artist";
            txtSearch.Size = new Size(258, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            //
            // lblGenreFilter
            //
            lblGenreFilter.AutoSize = true;
            lblGenreFilter.Location = new Point(318, 16);
            lblGenreFilter.Name = "lblGenreFilter";
            lblGenreFilter.Size = new Size(48, 20);
            lblGenreFilter.TabIndex = 2;
            lblGenreFilter.Text = "Genre";
            //
            // cmbGenreFilter
            //
            cmbGenreFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenreFilter.Location = new Point(372, 13);
            cmbGenreFilter.Name = "cmbGenreFilter";
            cmbGenreFilter.Size = new Size(130, 28);
            cmbGenreFilter.TabIndex = 3;
            cmbGenreFilter.SelectedIndexChanged += cmbGenreFilter_SelectedIndexChanged;
            //
            // btnAdd
            //
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(99, 82, 200);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(510, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+ Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnEdit
            //
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.White;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(190, 186, 215);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(606, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 30);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "✎ Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            //
            // btnDelete
            //
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(190, 186, 215);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(179, 38, 30);
            btnDelete.Location = new Point(702, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "🗑 Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnExport
            //
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.White;
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(190, 186, 215);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Location = new Point(798, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(90, 30);
            btnExport.TabIndex = 7;
            btnExport.Text = "↓ Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            //
            // dgvAlbums
            //
            dgvAlbums.AllowUserToAddRows = false;
            dgvAlbums.AllowUserToDeleteRows = false;
            dgvAlbums.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlbums.BackgroundColor = Color.White;
            dgvAlbums.BorderStyle = BorderStyle.None;
            dgvAlbums.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlbums.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 44, 110);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 44, 110);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlbums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlbums.ColumnHeadersHeight = 36;
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAlbums.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colArtist, colGenre, colReleaseYear, colTrackCount, colDurationMinutes, colLengthCategory });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(214, 208, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlbums.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlbums.EnableHeadersVisualStyles = false;
            dgvAlbums.GridColor = Color.FromArgb(230, 228, 240);
            dgvAlbums.Location = new Point(12, 52);
            dgvAlbums.MultiSelect = false;
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.ReadOnly = true;
            dgvAlbums.RowHeadersVisible = false;
            dgvAlbums.RowTemplate.Height = 30;
            dgvAlbums.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbums.Size = new Size(876, 454);
            dgvAlbums.TabIndex = 8;
            dgvAlbums.CellDoubleClick += dgvAlbums_CellDoubleClick;
            dgvAlbums.CellFormatting += dgvAlbums_CellFormatting;
            //
            // colId
            //
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            //
            // colTitle
            //
            colTitle.DataPropertyName = "Title";
            colTitle.FillWeight = 230F;
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            //
            // colArtist
            //
            colArtist.DataPropertyName = "Artist";
            colArtist.FillWeight = 170F;
            colArtist.HeaderText = "Artist";
            colArtist.Name = "colArtist";
            colArtist.ReadOnly = true;
            //
            // colGenre
            //
            colGenre.DataPropertyName = "Genre";
            colGenre.HeaderText = "Genre";
            colGenre.Name = "colGenre";
            colGenre.ReadOnly = true;
            //
            // colReleaseYear
            //
            colReleaseYear.DataPropertyName = "ReleaseYear";
            colReleaseYear.FillWeight = 65F;
            colReleaseYear.HeaderText = "Year";
            colReleaseYear.Name = "colReleaseYear";
            colReleaseYear.ReadOnly = true;
            //
            // colTrackCount
            //
            colTrackCount.DataPropertyName = "TrackCount";
            colTrackCount.FillWeight = 65F;
            colTrackCount.HeaderText = "Tracks";
            colTrackCount.Name = "colTrackCount";
            colTrackCount.ReadOnly = true;
            //
            // colDurationMinutes
            //
            colDurationMinutes.DataPropertyName = "DurationMinutes";
            colDurationMinutes.FillWeight = 75F;
            colDurationMinutes.HeaderText = "Minutes";
            colDurationMinutes.Name = "colDurationMinutes";
            colDurationMinutes.ReadOnly = true;
            //
            // colLengthCategory
            //
            colLengthCategory.DataPropertyName = "LengthCategory";
            colLengthCategory.FillWeight = 85F;
            colLengthCategory.HeaderText = "Length";
            colLengthCategory.Name = "colLengthCategory";
            colLengthCategory.ReadOnly = true;
            //
            // lblCount
            //
            lblCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 516);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 20);
            lblCount.TabIndex = 9;
            //
            // lblStatus
            //
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.DarkGreen;
            lblStatus.Location = new Point(260, 516);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 10;
            //
            // lblLegend
            //
            lblLegend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblLegend.BackColor = Color.FromArgb(255, 236, 200);
            lblLegend.Location = new Point(628, 514);
            lblLegend.Name = "lblLegend";
            lblLegend.Size = new Size(260, 24);
            lblLegend.TabIndex = 11;
            lblLegend.Text = "Coloured row: 60 minutes or longer";
            lblLegend.TextAlign = ContentAlignment.MiddleCenter;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 244, 250);
            ClientSize = new Size(900, 548);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblGenreFilter);
            Controls.Add(cmbGenreFilter);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnExport);
            Controls.Add(dgvAlbums);
            Controls.Add(lblCount);
            Controls.Add(lblStatus);
            Controls.Add(lblLegend);
            MinimumSize = new Size(918, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Album Catalogue";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblGenreFilter;
        private ComboBox cmbGenreFilter;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExport;
        private DataGridView dgvAlbums;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colArtist;
        private DataGridViewTextBoxColumn colGenre;
        private DataGridViewTextBoxColumn colReleaseYear;
        private DataGridViewTextBoxColumn colTrackCount;
        private DataGridViewTextBoxColumn colDurationMinutes;
        private DataGridViewTextBoxColumn colLengthCategory;
        private Label lblCount;
        private Label lblStatus;
        private Label lblLegend;
    }
}
