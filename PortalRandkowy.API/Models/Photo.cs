using System;

namespace PortalRandkowy.API.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public DateTime DateAdd { get; set; }
        public bool IsMain { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}