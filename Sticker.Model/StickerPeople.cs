namespace Sticker.Model
{
    public class StickerPeople
    {
        public int PeopleId { set; get; }
        public People People { set; get; }
        public int StickerInfoId { set; get; }
        public StickerInfo StickerInfo { set; get; }
    }
}