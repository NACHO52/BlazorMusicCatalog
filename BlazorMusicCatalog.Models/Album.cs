using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMusicCatalog.Models
{
    public class Album
    {
        public Album()
        {
            Songs = new List<Song>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Description { get; set; }
        public byte[] CoverImage { get; set; }
        public string Author { get; set; }
        public List<Song> Songs { get; set; }
    }
}
