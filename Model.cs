using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace MemesLoader
{


    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Analytics
    {
        [JsonPropertyName("onload")]
        public Onload Onload { get; set; }

        [JsonPropertyName("onclick")]
        public Onclick Onclick { get; set; }

        [JsonPropertyName("onsent")]
        public Onsent Onsent { get; set; }
    }

    public class Datum
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("bitly_gif_url")]
        public string BitlyGifUrl { get; set; }

        [JsonPropertyName("bitly_url")]
        public string BitlyUrl { get; set; }

        [JsonPropertyName("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("content_url")]
        public string ContentUrl { get; set; }

        [JsonPropertyName("source_tld")]
        public string SourceTld { get; set; }

        [JsonPropertyName("source_post_url")]
        public string SourcePostUrl { get; set; }

        [JsonPropertyName("is_sticker")]
        public int IsSticker { get; set; }

        [JsonPropertyName("import_datetime")]
        public string ImportDatetime { get; set; }

        [JsonPropertyName("trending_datetime")]
        public string TrendingDatetime { get; set; }

        [JsonPropertyName("images")]
        public Images Images { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("analytics_response_payload")]
        public string AnalyticsResponsePayload { get; set; }

        [JsonPropertyName("analytics")]
        public Analytics Analytics { get; set; }
    }

    public class FixedHeight
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }
    }

    public class FixedHeightDownsampled
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }
    }

    public class FixedHeightSmall
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }
    }

    public class FixedWidth
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }
    }

    public class FixedWidthDownsampled
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }
    }

    public class FixedWidthSmall
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }
    }

    public class Images
    {
        [JsonPropertyName("original")]
        public Original Original { get; set; }

        [JsonPropertyName("fixed_height")]
        public FixedHeight FixedHeight { get; set; }

        [JsonPropertyName("fixed_height_downsampled")]
        public FixedHeightDownsampled FixedHeightDownsampled { get; set; }

        [JsonPropertyName("fixed_height_small")]
        public FixedHeightSmall FixedHeightSmall { get; set; }

        [JsonPropertyName("fixed_width")]
        public FixedWidth FixedWidth { get; set; }

        [JsonPropertyName("fixed_width_downsampled")]
        public FixedWidthDownsampled FixedWidthDownsampled { get; set; }

        [JsonPropertyName("fixed_width_small")]
        public FixedWidthSmall FixedWidthSmall { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        [JsonPropertyName("response_id")]
        public string ResponseId { get; set; }
    }

    public class Onclick
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Onload
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Onsent
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class Original
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("mp4")]
        public string Mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("webp")]
        public string Webp { get; set; }

        [JsonPropertyName("frames")]
        public string Frames { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }
    }

    public class Pagination
    {
        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("offset")]
        public int Offset { get; set; }
    }



    public class User
    {
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonPropertyName("banner_image")]
        public string BannerImage { get; set; }

        [JsonPropertyName("banner_url")]
        public string BannerUrl { get; set; }

        [JsonPropertyName("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("instagram_url")]
        public string InstagramUrl { get; set; }

        [JsonPropertyName("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }
    }



    public class MemesLoaderData
    {
        [JsonPropertyName("data")]
        public List<Datum>? Data;

        [JsonPropertyName("pagination")]
        public Pagination? Pagination;

        [JsonPropertyName("meta")]
        public Meta? Meta;




    }






}