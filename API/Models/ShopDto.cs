using System;

namespace API.Models
{
    public class ShopDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        // public int LocationId { get; set; }
        public string Name { get; set; }

        // public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        // public int ReviewStatusId { get; set; }
        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public string Country { get; set; }

        public string County { get; set; }

        public string City { get; set; }

        public string Street { get; set; }
    }
}

// export interface IShop {
//   id: number,
//   name: string,
//   street: string,
//   city: string,
//   county: string,
//   country: string,
//   longitude: number,
//   latitude: number
// }
