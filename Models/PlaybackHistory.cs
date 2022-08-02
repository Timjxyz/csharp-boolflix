using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class PlaybackHistory
    {
        [Key]
        public int Id { get; set; }
        public int VideoContentId { get; set; }
       
    }
}
