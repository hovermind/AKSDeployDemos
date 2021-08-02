using System.ComponentModel.DataAnnotations;

namespace MVC.CsiSmb.Models
{
    public class SharedFolderModel
    {
        public string MountPath { get; set; } = @"/mnt/ncexport";
        public bool IsAccessible { get; set; } = false;
        public bool HasFiles { get; set; } = false;
        public string[] FileEntries { get; set; }

        [Required]
        public string TestFileName { get; set; }
    }
}
