using System;
using System.ComponentModel.DataAnnotations;

namespace Sticker.Model
{
    public class Tag
    {
        public int TagId { set; get; }
        [MaxLength(256)] public string TagName { set; get; }
        public DateTime CreatedTime { set; get; }
    }
}