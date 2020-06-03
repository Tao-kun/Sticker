namespace Sticker.Model
{
    public class StickerTag
    {
        public int TagId { set; get; }
        public Tag Tag { set; get; }
        public int StickerInfoId { set; get; }
        public StickerInfo StickerInfo { set; get; }
    }
}