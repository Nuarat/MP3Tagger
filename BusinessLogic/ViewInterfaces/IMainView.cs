using System;
using System.Collections.Generic;


namespace BusinessLogic.ViewInterfaces
{
    /// <summary>
    /// Defines controls required for the main view
    /// </summary>
    public interface IMainView{

        /// <summary>
        /// Path to the folder with files which are to be updated
        /// </summary>
        string GetFilesFrom { get; }

        /// <summary>
        /// New artist to set for the selected tracks
        /// </summary>
        string NewArtist { get; }
        
        /// <summary>
        /// New album to set for the selected tracks
        /// </summary>
        string NewAlbum { get; }

        /// <summary>
        /// New genre to set for the selected tracks
        /// </summary>
        string NewGenre { get; }

        /// <summary>
        /// Indicates whether artist tag is to be updated or not
        /// </summary>
        bool UpdateArtist { get; }

        /// <summary>
        /// Indicates whether album tag is to be updated or not
        /// </summary>
        bool UpdateAlbum { get; }

        /// <summary>
        /// Indicates whether genre tag is to be updated or not
        /// </summary>
        bool UpdateGenre { get; }

        /// <summary>
        /// Cover event for user's interaction with the Browse command
        /// </summary>
        event EventHandler OnBrowse;

        /// <summary>
        /// Cover event for user's interaction with the Launch command
        /// </summary>
        event EventHandler OnUpdate;

        /// <summary>
        /// Cover event for user's interaction with the Artist checkbox
        /// </summary>
        event EventHandler OnArtistChecked;

        /// <summary>
        /// Cover event for user's interaction with the Album checkbox
        /// </summary>
        event EventHandler OnAlbumChecked;

        /// <summary>
        /// Cover event for user's interaction with the Genre checkbox
        /// </summary>
        event EventHandler OnGenreChecked;
        
    
        
        /// <summary>
        /// Shows the tags of the tracks found in the specified folder
        /// </summary>
        /// <param name="tracks">List of tracks which info to display</param>
        void DisplayTracksInfo(List<TrackInfo> tracks);

        /// <summary>
        /// Opens a choose folder dialog and sets the value to GetFilesFrom
        /// </summary>
        void ChooseFolder();

        /// <summary>
        /// Enables or disables Artist field
        /// </summary>
        void ChangeArtistAvailability();
        
        /// <summary>
        /// Enables or disables Album field
        /// </summary>
        void ChangeAlbumAvailability();

        /// <summary>
        /// Enables or disables Genre field
        /// </summary>
        void ChangeGenreAvailability();

        /// <summary>
        /// Disable view's controls 
        /// </summary>
        void DisableControls();

        /// <summary>
        /// Enables view's controls
        /// </summary>
        void EnableControls();
    }
}
