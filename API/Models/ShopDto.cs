using System;

namespace API.Models
{
    public class ShopDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int ReviewStatusId { get; set; }
    }
}