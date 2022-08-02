using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public abstract class VideoContent
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public bool New { get; set; }
        public string PathImg { get; set; } 
        public List<Profile> Profiles { get; set; }
        public List<PlayList>? PlayLists { get; set; }
        public List<Genre>? Genres { get; set; }


    }
}
