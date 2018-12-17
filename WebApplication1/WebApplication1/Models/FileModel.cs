using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Models
{
    public class AlbumModel
    {
        public string Title { get; set; }

        

        public List<IFormFile> Files { get; set; }
    }

    public class FileDetails
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime LastModified { get; set; }
    }

    public class FilesViewModel
    {
        public List<FileDetails> Files { get; set; }
            = new List<FileDetails>();
    }

}
