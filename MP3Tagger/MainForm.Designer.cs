namespace MP3Tagger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxTakeFilesFrom = new System.Windows.Forms.TextBox();
            this.lblTakeFilesFrom = new System.Windows.Forms.Label();
            this.lstvwTracks = new System.Windows.Forms.ListView();
            this.hdrFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrTrackTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblChange = new System.Windows.Forms.Label();
            this.chkbxArtist = new System.Windows.Forms.CheckBox();
            this.txtbxArtist = new System.Windows.Forms.TextBox();
            this.chkbxAlbum = new System.Windows.Forms.CheckBox();
            this.txtbxAlbum = new System.Windows.Forms.TextBox();
            this.chkbxGenre = new System.Windows.Forms.CheckBox();
            this.txtbxGenre = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxTakeFilesFrom
            // 
            this.txtbxTakeFilesFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTakeFilesFrom.Location = new System.Drawing.Point(149, 27);
            this.txtbxTakeFilesFrom.Name = "txtbxTakeFilesFrom";
            this.txtbxTakeFilesFrom.Size = new System.Drawing.Size(557, 24);
            this.txtbxTakeFilesFrom.TabIndex = 0;
            // 
            // lblTakeFilesFrom
            // 
            this.lblTakeFilesFrom.AutoSize = true;
            this.lblTakeFilesFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTakeFilesFrom.Location = new System.Drawing.Point(21, 30);
            this.lblTakeFilesFrom.Name = "lblTakeFilesFrom";
            this.lblTakeFilesFrom.Size = new System.Drawing.Size(96, 16);
            this.lblTakeFilesFrom.TabIndex = 1;
            this.lblTakeFilesFrom.Text = "Take files from";
            // 
            // lstvwTracks
            // 
            this.lstvwTracks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrFileName,
            this.hdrTrackTitle,
            this.hdrArtist,
            this.hdrAlbum,
            this.hdrGenre});
            this.lstvwTracks.FullRowSelect = true;
            this.lstvwTracks.GridLines = true;
            this.lstvwTracks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvwTracks.Location = new System.Drawing.Point(24, 69);
            this.lstvwTracks.Name = "lstvwTracks";
            this.lstvwTracks.Size = new System.Drawing.Size(845, 415);
            this.lstvwTracks.TabIndex = 4;
            this.lstvwTracks.UseCompatibleStateImageBehavior = false;
            this.lstvwTracks.View = System.Windows.Forms.View.Details;
            // 
            // hdrFileName
            // 
            this.hdrFileName.Text = "File name";
            this.hdrFileName.Width = 200;
            // 
            // hdrTrackTitle
            // 
            this.hdrTrackTitle.Text = "Track title";
            this.hdrTrackTitle.Width = 150;
            // 
            // hdrArtist
            // 
            this.hdrArtist.Text = "Artist";
            this.hdrArtist.Width = 150;
            // 
            // hdrAlbum
            // 
            this.hdrAlbum.Text = "Album";
            this.hdrAlbum.Width = 150;
            // 
            // hdrGenre
            // 
            this.hdrGenre.Text = "Genre";
            this.hdrGenre.Width = 150;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChange.Location = new System.Drawing.Point(21, 500);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(58, 16);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "Change:";
            // 
            // chkbxArtist
            // 
            this.chkbxArtist.AutoSize = true;
            this.chkbxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkbxArtist.Location = new System.Drawing.Point(35, 535);
            this.chkbxArtist.Name = "chkbxArtist";
            this.chkbxArtist.Size = new System.Drawing.Size(70, 20);
            this.chkbxArtist.TabIndex = 18;
            this.chkbxArtist.Text = "Artist to";
            this.chkbxArtist.UseVisualStyleBackColor = true;
            // 
            // txtbxArtist
            // 
            this.txtbxArtist.Enabled = false;
            this.txtbxArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxArtist.Location = new System.Drawing.Point(149, 533);
            this.txtbxArtist.Name = "txtbxArtist";
            this.txtbxArtist.Size = new System.Drawing.Size(291, 22);
            this.txtbxArtist.TabIndex = 17;
            // 
            // chkbxAlbum
            // 
            this.chkbxAlbum.AutoSize = true;
            this.chkbxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkbxAlbum.Location = new System.Drawing.Point(35, 565);
            this.chkbxAlbum.Name = "chkbxAlbum";
            this.chkbxAlbum.Size = new System.Drawing.Size(79, 20);
            this.chkbxAlbum.TabIndex = 20;
            this.chkbxAlbum.Text = "Album to";
            this.chkbxAlbum.UseVisualStyleBackColor = true;
            // 
            // txtbxAlbum
            // 
            this.txtbxAlbum.Enabled = false;
            this.txtbxAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxAlbum.Location = new System.Drawing.Point(149, 563);
            this.txtbxAlbum.Name = "txtbxAlbum";
            this.txtbxAlbum.Size = new System.Drawing.Size(291, 22);
            this.txtbxAlbum.TabIndex = 19;
            // 
            // chkbxGenre
            // 
            this.chkbxGenre.AutoSize = true;
            this.chkbxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkbxGenre.Location = new System.Drawing.Point(35, 595);
            this.chkbxGenre.Name = "chkbxGenre";
            this.chkbxGenre.Size = new System.Drawing.Size(78, 20);
            this.chkbxGenre.TabIndex = 22;
            this.chkbxGenre.Text = "Genre to";
            this.chkbxGenre.UseVisualStyleBackColor = true;
            // 
            // txtbxGenre
            // 
            this.txtbxGenre.Enabled = false;
            this.txtbxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxGenre.Location = new System.Drawing.Point(149, 593);
            this.txtbxGenre.Name = "txtbxGenre";
            this.txtbxGenre.Size = new System.Drawing.Size(291, 22);
            this.txtbxGenre.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(482, 593);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 24);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update!";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowse.Location = new System.Drawing.Point(730, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 24);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 646);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkbxGenre);
            this.Controls.Add(this.txtbxGenre);
            this.Controls.Add(this.chkbxAlbum);
            this.Controls.Add(this.txtbxAlbum);
            this.Controls.Add(this.chkbxArtist);
            this.Controls.Add(this.txtbxArtist);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lstvwTracks);
            this.Controls.Add(this.lblTakeFilesFrom);
            this.Controls.Add(this.txtbxTakeFilesFrom);
            this.MaximumSize = new System.Drawing.Size(911, 685);
            this.MinimumSize = new System.Drawing.Size(911, 685);
            this.Name = "MainForm";
            this.Text = "Natu\'s MP3 Tagger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxTakeFilesFrom;
        private System.Windows.Forms.Label lblTakeFilesFrom;
        private System.Windows.Forms.ListView lstvwTracks;
        private System.Windows.Forms.ColumnHeader hdrFileName;
        private System.Windows.Forms.ColumnHeader hdrTrackTitle;
        private System.Windows.Forms.ColumnHeader hdrArtist;
        private System.Windows.Forms.ColumnHeader hdrAlbum;
        private System.Windows.Forms.ColumnHeader hdrGenre;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.CheckBox chkbxArtist;
        private System.Windows.Forms.TextBox txtbxArtist;
        private System.Windows.Forms.CheckBox chkbxAlbum;
        private System.Windows.Forms.TextBox txtbxAlbum;
        private System.Windows.Forms.CheckBox chkbxGenre;
        private System.Windows.Forms.TextBox txtbxGenre;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBrowse;
    }
}

