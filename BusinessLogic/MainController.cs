using System;
using System.Collections.Generic;
using System.Threading;
using BusinessLogic.ViewInterfaces;


namespace BusinessLogic
{
    /// <summary>
    /// Serves as a connection between app's View and Tracks manager
    /// </summary>
    public class MainController{

        private const int MAX_TAG_LENGTH = 50;
        private const string WRONG_FILE_PATH = "Please pick a folder to get files from";
        private const string ARTIST = "\nArtist";
        private const string ALBUM = "\nAlbum";
        private const string GENRE = "\nGenre";
        private const string NONE_SELECTED = "Please check tags you want to update";
        private readonly string _textTooLong = string.Format("Please set the following fields to {0} symbols or less:", MAX_TAG_LENGTH);

        /// <summary>
        /// List of tracks to update
        /// </summary>
        private List<TrackInfo> _tracksToUpdate;
        
        /// <summary>
        /// Tags to set in update action
        /// </summary>
        private readonly Tags _tagsToSet;
        
        /// <summary>
        /// Instance of tracks manager related to the current MainController instance
        /// </summary>
        private readonly TracksManager _currentTracksManager;

        /// <summary>
        /// Instance of Message Service related to the current MainController instance
        /// </summary>
        private readonly IMessageService _messageService;

        private readonly IMainView _mainView;


        /// <summary>
        /// Constructor of the main controller
        /// </summary>
        /// <param name="tracksManager">TracksManager instance</param>
        /// <param name="messageService">IMessageService instance</param>
        /// <param name="mainView">IMainView instance</param>
        public MainController(TracksManager tracksManager, IMessageService messageService, IMainView mainView){
            _currentTracksManager = tracksManager;
            _messageService = messageService;
            _mainView = mainView;
            _tagsToSet = new Tags();

            _mainView.OnBrowse += MainViewOnBrowse;
            _mainView.OnUpdate += MainViewOnUpdate;

            _mainView.OnArtistChecked += MainViewOnArtistChecked;
            _mainView.OnAlbumChecked += MainViewOnAlbumChecked;
            _mainView.OnGenreChecked += MainViewOnGenreChecked;
        }



        /// <summary>
        /// Enables or disables Genre field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainViewOnGenreChecked(object sender, EventArgs e)
        {
            var mainView = (IMainView)sender;
            mainView.ChangeGenreAvailability();
        }

        /// <summary>
        /// Enables or disables Album field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MainViewOnAlbumChecked(object sender, EventArgs e)
        {
            var mainView = (IMainView)sender;
            mainView.ChangeAlbumAvailability();
        }

        /// <summary>
        /// Enables or disables Artist field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MainViewOnArtistChecked(object sender, EventArgs e){
            var mainView = (IMainView)sender;
            mainView.ChangeArtistAvailability();
        }

        /// <summary>
        /// Opens a Choose folder dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainViewOnBrowse(object sender, EventArgs e)
        {
            var mainView = (IMainView) sender;
            mainView.ChooseFolder();
            if (mainView.GetFilesFrom != string.Empty){
                var tracksList = _currentTracksManager.GetTracksInfo(mainView.GetFilesFrom);
                mainView.DisplayTracksInfo(tracksList);
            }
        }

        
        /// <summary>
        /// Updates tags for the selected tracks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainViewOnUpdate(object sender, EventArgs e)
        {
            var mainView = (IMainView) sender;
            if (mainView.GetFilesFrom != string.Empty)
            {
                _tracksToUpdate = _currentTracksManager.GetTracksInfo(mainView.GetFilesFrom);

                _tagsToSet.Artist = mainView.NewArtist;
                _tagsToSet.UpdateArtist = mainView.UpdateArtist;
                _tagsToSet.Album = mainView.NewAlbum;
                _tagsToSet.UpdateAlbum = mainView.UpdateAlbum;
                _tagsToSet.Genre = mainView.NewGenre;
                _tagsToSet.UpdateGenre = mainView.UpdateGenre;

                if (!_tagsToSet.UpdateGenre && !_tagsToSet.UpdateArtist && !_tagsToSet.UpdateAlbum){
                    _messageService.ShowNotification(NONE_SELECTED);
                }

                else{
                    if (_tagsToSet.Artist.Length <= MAX_TAG_LENGTH &&
                        _tagsToSet.Album.Length <= MAX_TAG_LENGTH &&
                        _tagsToSet.Genre.Length <= MAX_TAG_LENGTH){
                        mainView.DisableControls();
                       
                        var bgThread = new Thread(RunUpdate);
                        bgThread.Start();
                    }
                    else{
                        var errorText = _textTooLong;
                        if (_tagsToSet.Artist.Length > MAX_TAG_LENGTH && _tagsToSet.UpdateArtist){
                            errorText = string.Format("{0}{1}", errorText, ARTIST);
                        }
                        if (_tagsToSet.Album.Length > MAX_TAG_LENGTH && _tagsToSet.UpdateAlbum){
                            errorText = string.Format("{0}{1}", errorText, ALBUM);
                        }
                        if (_tagsToSet.Genre.Length > MAX_TAG_LENGTH && _tagsToSet.UpdateGenre){
                            errorText = string.Format("{0}{1}", errorText, GENRE);
                        }
                        _messageService.ShowError(errorText);
                    }
                }
            }

            else _messageService.ShowWarning(WRONG_FILE_PATH);
        }

        /// <summary>
        /// Runs updating tracks' tags in a secondary thread
        /// </summary>
        private void RunUpdate(){
            _tracksToUpdate = _currentTracksManager.UpdateTracksInfo(_tracksToUpdate, _tagsToSet);
            _mainView.DisplayTracksInfo(_tracksToUpdate);
            _mainView.EnableControls();
        }
    }
}
