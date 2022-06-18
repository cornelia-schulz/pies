using System.Collections.Generic;
using API.Models;

namespace API.DataStores
{
    public class ShopDataStore
    {
        public static ShopDataStore Current { get; } = new ShopDataStore();

        public List<ShopDto> Shops { get; set; }

        public ShopDataStore()
        {
            Shops =
                new List<ShopDto>()
                {
                    new ShopDto()
                    {
                        Id = 1,
                        UserId = 1,
                        Name = "Pies and Coffee api",
                        City = "Christchurch",
                        Street = "290 Selwyn St",
                        County = "Canterbury",
                        Country = "New Zealand",
                        Latitude = -43.529126911758606,
                        Longitude = 172.62206744255727
                        // pies = []
                    },
                    new ShopDto()
                    {
                        Id = 124,
                        UserId = 1,
                        Name = "The great pastry shop api api",
                        City = "Christchurch",
                        Street = "Riverside Market",
                        County = "Canterbury",
                        Country = "New Zealand",
                        Latitude = -43.533927237712405,
                        Longitude = 172.63397647139195
                    },
                    new ShopDto()
                    {
                        Id = 126,
                        Name = "The Pie Tin Newtown",
                        City = "Sydney",
                        Street = "1a Brown St",
                        County = "NSW",
                        Country = "Australia",
                        Latitude = -33.89518531945312,
                        Longitude = 151.18240158394033
                    },
                    new ShopDto()
                    {
                        Id = 127,
                        Name = "The House of Pie",
                        City = "Sydney",
                        Street = "540 Bunnerong Road",
                        County = "NSW",
                        Country = "Australia",
                        Latitude = -33.959505303896556,
                        Longitude = 151.23099792627124
                    }
                };
        }
    }
}
