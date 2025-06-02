using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetNewClient.Models
{
    public class PlayState
    {
        [JsonPropertyName("PositionTicks")]
        public long? PositionTicks { get; set; }
        [JsonPropertyName("CanSeek")]
        public bool CanSeek { get; set; }
        [JsonPropertyName("IsPaused")]
        public bool IsPaused { get; set; }
        [JsonPropertyName("IsMuted")]
        public bool IsMuted { get; set; }
        [JsonPropertyName("VolumeLevel")]
        public int? VolumeLevel { get; set; }
        [JsonPropertyName("AudioStreamIndex")]
        public int? AudioStreamIndex { get; set; }
        [JsonPropertyName("SubtitleStreamIndex")]
        public int? SubtitleStreamIndex { get; set; }
        [JsonPropertyName("MediaSourceId")]
        public string MediaSourceId { get; set; }
        [JsonPropertyName("PlayMethod")]
        public string PlayMethod { get; set; }
        [JsonPropertyName("RepeatMode")]
        public string RepeatMode { get; set; }
        [JsonPropertyName("SubtitleOffset")]
        public int SubtitleOffset { get; set; }
        [JsonPropertyName("Shuffle")]
        public bool Shuffle { get; set; }
        [JsonPropertyName("PlaybackRate")]
        public double PlaybackRate { get; set; }
    }

    public class ExternalUrl
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }

    public class GenreItem
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Id")]
        public int Id { get; set; }
    }

    public class ProviderIds
    {
        [JsonPropertyName("Tvdb")]
        public string Tvdb { get; set; }
        [JsonPropertyName("IMDB")]
        public string IMDB { get; set; }
    }

    public class MediaStream
    {
        [JsonPropertyName("Codec")]
        public string Codec { get; set; }
        [JsonPropertyName("Language")]
        public string Language { get; set; }
        [JsonPropertyName("TimeBase")]
        public string TimeBase { get; set; }
        [JsonPropertyName("DisplayTitle")]
        public string DisplayTitle { get; set; }
        [JsonPropertyName("DisplayLanguage")]
        public string DisplayLanguage { get; set; }
        [JsonPropertyName("IsInterlaced")]
        public bool IsInterlaced { get; set; }
        [JsonPropertyName("BitRate")]
        public int? BitRate { get; set; }
        [JsonPropertyName("Channels")]
        public int? Channels { get; set; }
        [JsonPropertyName("SampleRate")]
        public int? SampleRate { get; set; }
        [JsonPropertyName("IsDefault")]
        public bool IsDefault { get; set; }
        [JsonPropertyName("IsForced")]
        public bool IsForced { get; set; }
        [JsonPropertyName("IsHearingImpaired")]
        public bool IsHearingImpaired { get; set; }
        [JsonPropertyName("Profile")]
        public string Profile { get; set; }
        [JsonPropertyName("Type")]
        public string Type { get; set; }
        [JsonPropertyName("Index")]
        public int Index { get; set; }
        [JsonPropertyName("IsExternal")]
        public bool IsExternal { get; set; }
        [JsonPropertyName("IsTextSubtitleStream")]
        public bool IsTextSubtitleStream { get; set; }
        [JsonPropertyName("SupportsExternalStream")]
        public bool SupportsExternalStream { get; set; }
        [JsonPropertyName("Protocol")]
        public string Protocol { get; set; }
        [JsonPropertyName("AttachmentSize")]
        public int? AttachmentSize { get; set; }
        [JsonPropertyName("SubtitleLocationType")]
        public string SubtitleLocationType { get; set; }
        // ... add other properties as needed ...
    }

    public class Chapter
    {
        [JsonPropertyName("StartPositionTicks")]
        public long StartPositionTicks { get; set; }
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("MarkerType")]
        public string MarkerType { get; set; }
        [JsonPropertyName("ChapterIndex")]
        public int ChapterIndex { get; set; }
    }

    public class NowPlayingItem
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("ServerId")]
        public string ServerId { get; set; }
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        [JsonPropertyName("DateCreated")]
        public DateTime DateCreated { get; set; }
        [JsonPropertyName("PresentationUniqueKey")]
        public string PresentationUniqueKey { get; set; }
        [JsonPropertyName("Container")]
        public string Container { get; set; }
        [JsonPropertyName("PremiereDate")]
        public DateTime PremiereDate { get; set; }
        [JsonPropertyName("ExternalUrls")]
        public List<ExternalUrl> ExternalUrls { get; set; }
        [JsonPropertyName("Path")]
        public string Path { get; set; }
        [JsonPropertyName("Overview")]
        public string Overview { get; set; }
        [JsonPropertyName("Taglines")]
        public List<string> Taglines { get; set; }
        [JsonPropertyName("Genres")]
        public List<string> Genres { get; set; }
        [JsonPropertyName("CommunityRating")]
        public double? CommunityRating { get; set; }
        [JsonPropertyName("RunTimeTicks")]
        public long? RunTimeTicks { get; set; }
        [JsonPropertyName("Size")]
        public long? Size { get; set; }
        [JsonPropertyName("FileName")]
        public string FileName { get; set; }
        [JsonPropertyName("Bitrate")]
        public int? Bitrate { get; set; }
        [JsonPropertyName("ProductionYear")]
        public int? ProductionYear { get; set; }
        [JsonPropertyName("IndexNumber")]
        public int? IndexNumber { get; set; }
        [JsonPropertyName("ParentIndexNumber")]
        public int? ParentIndexNumber { get; set; }
        [JsonPropertyName("ProviderIds")]
        public ProviderIds ProviderIds { get; set; }
        [JsonPropertyName("IsFolder")]
        public bool IsFolder { get; set; }
        [JsonPropertyName("ParentId")]
        public string ParentId { get; set; }
        [JsonPropertyName("Type")]
        public string Type { get; set; }
        [JsonPropertyName("Studios")]
        public List<string> Studios { get; set; }
        [JsonPropertyName("GenreItems")]
        public List<GenreItem> GenreItems { get; set; }
        [JsonPropertyName("ParentLogoItemId")]
        public string ParentLogoItemId { get; set; }
        [JsonPropertyName("ParentBackdropItemId")]
        public string ParentBackdropItemId { get; set; }
        [JsonPropertyName("ParentBackdropImageTags")]
        public List<string> ParentBackdropImageTags { get; set; }
        [JsonPropertyName("SeriesName")]
        public string SeriesName { get; set; }
        [JsonPropertyName("SeriesId")]
        public string SeriesId { get; set; }
        [JsonPropertyName("SeasonId")]
        public string SeasonId { get; set; }
        [JsonPropertyName("PrimaryImageAspectRatio")]
        public double? PrimaryImageAspectRatio { get; set; }
        [JsonPropertyName("SeriesPrimaryImageTag")]
        public string SeriesPrimaryImageTag { get; set; }
        [JsonPropertyName("SeasonName")]
        public string SeasonName { get; set; }
        [JsonPropertyName("MediaStreams")]
        public List<MediaStream> MediaStreams { get; set; }
        [JsonPropertyName("ImageTags")]
        public Dictionary<string, string> ImageTags { get; set; }
        [JsonPropertyName("BackdropImageTags")]
        public List<string> BackdropImageTags { get; set; }
        [JsonPropertyName("ParentLogoImageTag")]
        public string ParentLogoImageTag { get; set; }
        [JsonPropertyName("ParentThumbItemId")]
        public string ParentThumbItemId { get; set; }
        [JsonPropertyName("ParentThumbImageTag")]
        public string ParentThumbImageTag { get; set; }
        [JsonPropertyName("Chapters")]
        public List<Chapter> Chapters { get; set; }
        [JsonPropertyName("MediaType")]
        public string MediaType { get; set; }
        [JsonPropertyName("Width")]
        public int? Width { get; set; }
        [JsonPropertyName("Height")]
        public int? Height { get; set; }
    }

    public class Session
    {

        public override string ToString()
        {
            string playingInfo = NowPlayingItem != null 
                ? $"Now Playing: {NowPlayingItem.Name}" 
                : "Nothing playing";
            
            return $"{DeviceName} - {playingInfo}";
        }

        [JsonPropertyName("PlayState")]
        public PlayState PlayState { get; set; }
        [JsonPropertyName("AdditionalUsers")]
        public List<object> AdditionalUsers { get; set; }
        [JsonPropertyName("RemoteEndPoint")]
        public string RemoteEndPoint { get; set; }
        [JsonPropertyName("Protocol")]
        public string Protocol { get; set; }
        [JsonPropertyName("PlayableMediaTypes")]
        public List<string> PlayableMediaTypes { get; set; }
        [JsonPropertyName("PlaylistIndex")]
        public int PlaylistIndex { get; set; }
        [JsonPropertyName("PlaylistLength")]
        public int PlaylistLength { get; set; }
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        [JsonPropertyName("ServerId")]
        public string ServerId { get; set; }
        [JsonPropertyName("UserId")]
        public string UserId { get; set; }
        [JsonPropertyName("UserName")]
        public string UserName { get; set; }
        [JsonPropertyName("Client")]
        public string Client { get; set; }
        [JsonPropertyName("LastActivityDate")]
        public DateTime LastActivityDate { get; set; }
        [JsonPropertyName("DeviceName")]
        public string DeviceName { get; set; }
        [JsonPropertyName("NowPlayingItem")]
        public NowPlayingItem NowPlayingItem { get; set; }
        [JsonPropertyName("InternalDeviceId")]
        public int InternalDeviceId { get; set; }
        [JsonPropertyName("DeviceId")]
        public string DeviceId { get; set; }
        [JsonPropertyName("ApplicationVersion")]
        public string ApplicationVersion { get; set; }
        [JsonPropertyName("AppIconUrl")]
        public string AppIconUrl { get; set; }
        [JsonPropertyName("SupportedCommands")]
        public List<string> SupportedCommands { get; set; }
        [JsonPropertyName("SupportsRemoteControl")]
        public bool SupportsRemoteControl { get; set; }
    }
}
