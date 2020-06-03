using System;
using System.ComponentModel.DataAnnotations;

namespace Sticker.Model
{
    public class People
    {
        public int PeopleId { set; get; }
        [MaxLength(64)] public string PeopleName { set; get; }
        [MaxLength(64)] public string ContractInfo { set; get; }
        public DateTime CreatedTime { set; get; }
    }
}