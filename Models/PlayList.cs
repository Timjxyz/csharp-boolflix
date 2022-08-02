using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class PlayList
    {
        [Key]
        public int Id { get; set; }
        public Profile Profiles { get; set; }
        public List<VideoContent>? VideoContents { get; set; }
    }
}
