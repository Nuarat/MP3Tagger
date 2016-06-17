using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.ViewInterfaces;


namespace MP3Tagger{
    /// <summary>
    /// Main form of the MP3 Tagger app
    /// </summary>
    public partial class MainForm : Form, IMainView{
        /// <summary>
        /// Path to the folder with files which are to be updated
        /// </summary>
        public string GetFilesFrom{
            get { return txtbxTakeFilesFrom.Text; }
            private set { txtbxTakeFilesFrom.Text = value; }
        }

        /// <summary>
        /// New artist to set for the selected tracks
        /// </summary>
        public string NewArtist{
            get { return txtbxArtist.Text; }
        }


        /// <summary>
        /// New album to set for the selected tracks
        /// </summary>
        public string NewAlbum{
            get { return txtbxAlbum.Text; }
        }

        /// <summary>
        /// New genre to set for the selected tracks
        /// </summary>
        public string NewGenre{
            get { return txtbxGenre.Text; }
        }

        /// <summary>
        /// Indicates whether artist tag is to be updated or not
        /// </summary>
        public bool UpdateArtist{
            get { return chkbxArtist.Checked; }
        }

        /// <summary>
        /// Indicates whether album tag is to be updated or not
        /// </summary>
        public bool UpdateAlbum{
            get { return chkbxAlbum.Checked; }
        }

        /// <summary>
        /// Indicates whether genre tag is to be updated or not
        /// </summary>
        public bool UpdateGenre{
            get { return chkbxGenre.Checked; }
        }

        /// <summary>
        /// Last used file path
        /// </summary>
        public string LastFilePath { get; set; }


        /// <summary>
        /// Cover event for user's interaction with the Browse command
        /// </summary>
        public event EventHandler OnBrowse;

        /// <summary>
        /// Cover event for user's interaction with the Update command
        /// </summary>
        public event EventHandler OnUpdate;

        /// <summary>
        /// Cover event for user's interaction with the Artist checkbox
        /// </summary>
        public event EventHandler OnArtistChecked;

        /// <summary>
        /// Cover event for user's interaction with the Album checkbox
        /// </summary>
        public event EventHandler OnAlbumChecked;

        /// <summary>
        /// Cover event for user's interaction with the Genre checkbox
        /// </summary>
        public event EventHandler OnGenreChecked;


        /// <summary>
        /// Form's main constructor
        /// </summary>
        public MainForm(){
            InitializeComponent();

            chkbxArtist.Checked = false;
            chkbxAlbum.Checked = false;
            chkbxGenre.Checked = false;
            txtbxTakeFilesFrom.Enabled = false;
            LastFilePath = string.Empty;
            txtbxTakeFilesFrom.Text = LastFilePath;

            lstvwTracks.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);

            btnBrowse.Click += BtnBrowseClick;
            btnUpdate.Click += BtnUpdateClick;

            chkbxAlbum.CheckedChanged += ChkbxAlbumCheckedChanged;
            chkbxArtist.CheckedChanged += ChkbxArtistCheckedChanged;
            chkbxGenre.CheckedChanged += ChkbxGenreCheckedChanged;
        }

        /// <summary>
        /// Event which is fired when the user clicks Genre checkbox
        /// </summary>
        /// <param name="sender">Current form, which fired the event</param>
        /// <param name="e"></param>
        private void ChkbxGenreCheckedChanged(object sender, EventArgs e){
            if (OnGenreChecked != null) OnGenreChecked(this, EventArgs.Empty);
        }

        /// <summary>
        /// Event which is fired when the user clicks Artist checkbox
        /// </summary>
        /// <param name="sender">Current form, which fired the event</param>
        /// <param name="e"></param>
        private void ChkbxArtistCheckedChanged(object sender, EventArgs e){
            if (OnArtistChecked != null) OnArtistChecked(this, EventArgs.Empty);
        }

        /// <summary>
        /// Event which is fired when the user clicks Album checkbox
        /// </summary>
        /// <param name="sender">Current form, which fired the event</param>
        /// <param name="e"></param>
        private void ChkbxAlbumCheckedChanged(object sender, EventArgs e){
            if (OnAlbumChecked != null) OnAlbumChecked(this, EventArgs.Empty);
        }


        /// <summary>
        /// Event which is fired when the user presses the Browse button
        /// </summary>
        /// <param name="sender">Current form, which fired the event</param>
        /// <param name="e"></param>
        private void BtnBrowseClick(object sender, EventArgs e){
            if (OnBrowse != null) OnBrowse(this, EventArgs.Empty);
        }

        /// <summary>
        /// Event which is fired when the user presses the Update button
        /// </summary>
        /// <param name="sender">Current form, which fired the event</param>
        /// <param name="e"></param>
        private void BtnUpdateClick(object sender, EventArgs e){
            if (OnUpdate != null) OnUpdate(this, EventArgs.Empty);
        }

        /// <summary>
        /// Clears form's data
        /// </summary>
        public void ClearFormsFields(){
            lstvwTracks.Items.Clear();

            chkbxAlbum.Checked = false;
            txtbxAlbum.Enabled = false;
            txtbxAlbum.Text = string.Empty;

            chkbxArtist.Checked = false;
            txtbxArtist.Enabled = false;
            txtbxArtist.Text = string.Empty;

            chkbxGenre.Checked = false;
            txtbxGenre.Enabled = false;
            txtbxGenre.Text = string.Empty;
        }

        /// <summary>
        /// Shows the tags of the tracks found in the specified folder
        /// </summary>
        /// <param name="tracks">List of tracks which info to display</param>
        public void DisplayTracksInfo(List<TrackInfo> tracks){
            lstvwTracks.InvokeEx(lstvwTracks.Items.Clear);

            Action display = () =>{
                                 foreach (var trackInfo in tracks){
                                     var itemToAdd = new ListViewItem(trackInfo.FileName);
                                     itemToAdd.SubItems.Add(trackInfo.TrackTitle);
                                     itemToAdd.SubItems.Add(trackInfo.Artist);
                                     itemToAdd.SubItems.Add(trackInfo.Album);
                                     itemToAdd.SubItems.Add(trackInfo.Genre);
                                     lstvwTracks.Items.Add(itemToAdd);
                                     lstvwTracks.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
                                 }
                             };
            lstvwTracks.InvokeEx(display);
        }

        /// <summary>
        /// Opens a choose folder dialog and sets the chosen path to the GetFilesFrom
        /// </summary>
        public void ChooseFolder(){
            var dialog = new FolderBrowserDialog{SelectedPath = LastFilePath};

            if (dialog.ShowDialog() == DialogResult.OK) 
                GetFilesFrom = dialog.SelectedPath;
            ClearFormsFields();
            LastFilePath = GetFilesFrom;
        }

        /// <summary>
        /// Enables or disables Artist field
        /// </summary>
        public void ChangeArtistAvailability(){
            txtbxArtist.Enabled = chkbxArtist.Checked;
        }

        /// <summary>
        /// Enables or disables Album field
        /// </summary>
        public void ChangeAlbumAvailability(){
            txtbxAlbum.Enabled = chkbxAlbum.Checked;
        }

        /// <summary>
        /// Enables or disables Genre field
        /// </summary>
        public void ChangeGenreAvailability(){
            txtbxGenre.Enabled = chkbxGenre.Checked;
        }

        /// <summary>
        /// Disable view's controls 
        /// </summary>
        public void DisableControls(){
            btnBrowse.Enabled = false;
            btnUpdate.Enabled = false;
        }

        /// <summary>
        /// Enables view's controls
        /// </summary>
        public void EnableControls(){
            Action enableButtons = () =>{
                                       btnBrowse.Enabled = true;
                                       btnUpdate.Enabled = true;
                                   };
            btnBrowse.InvokeEx(enableButtons);
        }
    }
}