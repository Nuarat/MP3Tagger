namespace BusinessLogic
{
    /// <summary>
    /// Represents new values of tags to set, defined in GUI
    /// </summary>
    public class Tags{

        /// <summary>
        /// Artist value to set
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Update Artist to new value or not
        /// </summary>
        public bool UpdateArtist { get; set; }


        /// <summary>
        /// Album value to set
        /// </summary>
        public string Album { get; set; }

        /// <summary>
        /// Update Album to new value or not
        /// </summary>
        public bool UpdateAlbum { get; set; }


        /// <summary>
        /// Genre value to set
        /// </summary>
        public string Genre { get; set; }
        
        /// <summary>
        /// Update Genre to new value or not
        /// </summary>
        public bool UpdateGenre { get; set; }


    }
}
