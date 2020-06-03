using System;
using System.ComponentModel.DataAnnotations;

namespace Sticker.Model
{
    public class StickerInfo
    {
        public int StickerInfoId { set; get; }
        [MaxLength(256)] public string FileName { set; get; }
        public DateTime UploadTime { set; get; }
    }
}