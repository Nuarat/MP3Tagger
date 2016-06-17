using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace BusinessLogic
{
    /// <summary>
    /// Deals with the app's data: creates, updates, stores and opens the entities.
    /// </summary>
    public class TracksManager{

        private const string ACCEPTABLE_FILE_TYPES = "*.mp3";

       
        /// <summary>
        /// Forms a list of TrackInfo items based on the tracks found in a specified folder
        /// </summary>
        /// <param name="folderPath">Path to the folder to look files in</param>
        /// <returns>List of TrackInfo items</returns>
        public List<TrackInfo> GetTracksInfo(string folderPath){

            var tracksInfoList = new List<TrackInfo>();
            

            var filePaths = Directory.GetFiles(folderPath, ACCEPTABLE_FILE_TYPES, SearchOption.TopDirectoryOnly);

            foreach (var filePath in filePaths){
                var mediaFile = TagLib.File.Create(filePath);
                tracksInfoList.Add(new TrackInfo{
                    FileName = Path.GetFileName(filePath),
                    FilePath = filePath,
                    TrackTitle = mediaFile.Tag.Title,
                    Artist = mediaFile.Tag.FirstAlbumArtist,
                    Album = mediaFile.Tag.Album,
                    Genre = mediaFile.Tag.FirstGenre
                });    
            }
            return tracksInfoList;
        }



        /// <summary>
        /// Updates tags in a list of media files and returns a list of updated TrackInfos
        /// </summary>
        /// <param name="tracks">List of tracks to update</param>
        /// <param name="tagsToSet">New values of tags and whether to update them or not</param>
        /// <returns>List of updated tracks tags</returns>
        //public List<TrackInfo> UpdateTracksInfo(List<TrackInfo> tracks, Tags tagsToSet){
        public List<TrackInfo> UpdateTracksInfo(List<TrackInfo> tracks, Tags tagsToSet){
            foreach (var track in tracks){
                var mediaFile = TagLib.File.Create(track.FilePath);
                if (tagsToSet.UpdateAlbum){
                    track.Album = tagsToSet.Album;
                    mediaFile.Tag.Album = track.Album;
                }
                if (tagsToSet.UpdateArtist){
                    track.Artist = tagsToSet.Artist;
                    mediaFile.Tag.AlbumArtists = new[] { track.Artist };
                }
                if (tagsToSet.UpdateGenre){
                    track.Genre = tagsToSet.Genre;
                    mediaFile.Tag.Genres = new[] { track.Genre };
                }
                
                mediaFile.Save();
            }
            Thread.Sleep(2000);
            return tracks;
        }

        ////AWAIT version
        ///// <summary>
        ///// Updates tags in a list of media files and returns a list of updated TrackInfos
        ///// </summary>
        ///// <param name="tracks">List of tracks to update</param>
        ///// <param name="tagsToSet">New values of tags and whether to update them or not</param>
        ///// <returns>List of updated tracks tags</returns>
        ////public List<TrackInfo> UpdateTracksInfo(List<TrackInfo> tracks, Tags tagsToSet){
        //public Task<List<TrackInfo>>  UpdateTracksInfo(List<TrackInfo> tracks, Tags tagsToSet){
        //    return Task.Run(() =>{
        //        foreach (var track in tracks)
        //        {
        //            var mediaFile = TagLib.File.Create(track.FilePath);
        //            if (tagsToSet.UpdateAlbum)
        //            {
        //                track.Album = tagsToSet.Album;
        //                mediaFile.Tag.Album = track.Album;
        //            }

        //            if (tagsToSet.UpdateArtist)
        //            {
        //                track.Artist = tagsToSet.Artist;
        //                mediaFile.Tag.AlbumArtists = new[] { track.Artist };
        //            }

        //            if (tagsToSet.UpdateGenre)
        //            {
        //                track.Genre = tagsToSet.Genre;
        //                mediaFile.Tag.Genres = new[] { track.Genre };
        //            }
        //            mediaFile.Save();
        //        }
        //        return tracks;
        //    }
        //        );

            
        //}
    }
}
