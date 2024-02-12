using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities
{
    [Table("Items")]// this is effect to call/ and table name in Database
    public class Item
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string ImageUrl { get; set; }

        //nav properties
        public Auction Auction { get; set; }
        public Guid AuctionId { get; set; }
        // public DateTime Age { get; set; } = DateTime.UtcNow;
    }
}