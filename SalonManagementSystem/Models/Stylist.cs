using System.Linq;

namespace SalonManagementSystem.Models
{
    public class Stylist
    {
        public string Name {get; set; }
        public int StylistId {get; set; }
        public int ClientId { get; set; }
        public virtual Client Client {get; set; }
    }
}