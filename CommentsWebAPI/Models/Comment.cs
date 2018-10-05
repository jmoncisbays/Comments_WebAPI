using System.ComponentModel.DataAnnotations;

namespace CommentsWebAPI.Models
{
    public class Comment
    {
        [Required]
        public string Value { get; set; }
    }
}
