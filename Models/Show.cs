using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WatchDog.API.Models
{
    public class Show
    {
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime SavedAt { get; set; }

        public int CategoryId { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}
