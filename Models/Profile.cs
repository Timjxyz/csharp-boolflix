using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool  Child { get; set; }
        public List<VideoContent> VideoContents { get; set; }
        public int PlayListId { get; set; }
        public PlayList PlayLists { get; set; }
    }
}
