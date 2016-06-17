namespace BusinessLogic
{
    /// <summary>
    /// Contains informaiton about tracks
    /// </summary>
    public class TrackInfo{

        /// <summary>
        /// Path to the track file
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// File name of the track
        /// </summary>
        public string FileName { get; set; }
        
        /// <summary>
        /// Track title (in media info)
        /// </summary>
        public string TrackTitle { get; set; }
        
        /// <summary>
        /// Track artist (in media info)
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Track album (in media info)
        /// </summary>
        public string Album { get; set; }

        /// <summary>
        /// Track genre (in media info)
        /// </summary>
        public string Genre { get; set; }
    }
}
