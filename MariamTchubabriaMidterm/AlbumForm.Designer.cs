namespace MariamTchubabriaMidterm
{
    partial class AlbumForm
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
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblArtist = new Label();
            txtArtist = new TextBox();
            lblGenre = new Label();
            cmbGenre = new ComboBox();
            lblReleaseYear = new Label();
            numReleaseYear = new NumericUpDown();
            lblTrackCount = new Label();
            numTrackCount = new NumericUpDown();
            lblDurationMinutes = new Label();
            numDurationMinutes = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numReleaseYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTrackCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDurationMinutes).BeginInit();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(16, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            //
            // txtTitle
            //
            txtTitle.Location = new Point(130, 16);
            txtTitle.MaxLength = 150;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(290, 27);
            txtTitle.TabIndex = 1;
            //
            // lblArtist
            //
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(16, 59);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(44, 20);
            lblArtist.TabIndex = 2;
            lblArtist.Text = "Artist";
            //
            // txtArtist
            //
            txtArtist.Location = new Point(130, 56);
            txtArtist.MaxLength = 100;
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(290, 27);
            txtArtist.TabIndex = 3;
            //
            // lblGenre
            //
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(16, 99);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 4;
            lblGenre.Text = "Genre";
            //
            // cmbGenre
            //
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.Location = new Point(130, 96);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(160, 28);
            cmbGenre.TabIndex = 5;
            //
            // lblReleaseYear
            //
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Location = new Point(16, 139);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(91, 20);
            lblReleaseYear.TabIndex = 6;
            lblReleaseYear.Text = "Release year";
            //
            // numReleaseYear
            //
            numReleaseYear.Location = new Point(130, 136);
            numReleaseYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numReleaseYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numReleaseYear.Name = "numReleaseYear";
            numReleaseYear.Size = new Size(100, 27);
            numReleaseYear.TabIndex = 7;
            numReleaseYear.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            //
            // lblTrackCount
            //
            lblTrackCount.AutoSize = true;
            lblTrackCount.Location = new Point(16, 179);
            lblTrackCount.Name = "lblTrackCount";
            lblTrackCount.Size = new Size(50, 20);
            lblTrackCount.TabIndex = 8;
            lblTrackCount.Text = "Tracks";
            //
            // numTrackCount
            //
            numTrackCount.Location = new Point(130, 176);
            numTrackCount.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numTrackCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTrackCount.Name = "numTrackCount";
            numTrackCount.Size = new Size(100, 27);
            numTrackCount.TabIndex = 9;
            numTrackCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            //
            // lblDurationMinutes
            //
            lblDurationMinutes.AutoSize = true;
            lblDurationMinutes.Location = new Point(16, 219);
            lblDurationMinutes.Name = "lblDurationMinutes";
            lblDurationMinutes.Size = new Size(61, 20);
            lblDurationMinutes.TabIndex = 10;
            lblDurationMinutes.Text = "Minutes";
            //
            // numDurationMinutes
            //
            numDurationMinutes.Location = new Point(130, 216);
            numDurationMinutes.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDurationMinutes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDurationMinutes.Name = "numDurationMinutes";
            numDurationMinutes.Size = new Size(100, 27);
            numDurationMinutes.TabIndex = 11;
            numDurationMinutes.Value = new decimal(new int[] { 45, 0, 0, 0 });
            //
            // btnSave
            //
            btnSave.BackColor = Color.FromArgb(99, 82, 200);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(226, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 32);
            btnSave.TabIndex = 12;
            btnSave.Text = "✓ Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnCancel
            //
            btnCancel.BackColor = Color.White;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(190, 186, 215);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(326, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 32);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "✕ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            //
            // AlbumForm
            //
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 244, 250);
            CancelButton = btnCancel;
            ClientSize = new Size(436, 310);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblArtist);
            Controls.Add(txtArtist);
            Controls.Add(lblGenre);
            Controls.Add(cmbGenre);
            Controls.Add(lblReleaseYear);
            Controls.Add(numReleaseYear);
            Controls.Add(lblTrackCount);
            Controls.Add(numTrackCount);
            Controls.Add(lblDurationMinutes);
            Controls.Add(numDurationMinutes);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AlbumForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add album";
            ((System.ComponentModel.ISupportInitialize)numReleaseYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTrackCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDurationMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblArtist;
        private TextBox txtArtist;
        private Label lblGenre;
        private ComboBox cmbGenre;
        private Label lblReleaseYear;
        private NumericUpDown numReleaseYear;
        private Label lblTrackCount;
        private NumericUpDown numTrackCount;
        private Label lblDurationMinutes;
        private NumericUpDown numDurationMinutes;
        private Button btnSave;
        private Button btnCancel;
    }
}
