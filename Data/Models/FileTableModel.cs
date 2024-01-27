using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class FileTableModel
    {
        [Key]
        public int SourceFileId { get; set; }
        public int TargetFileId { get; set; }
        public int PagesInSourceFile { get; set; }
        public int PagesInTargetFile { get; set; }
        public string SourceFileLink { get; set; }
        public string TargetFileLink { get; set; }
    }

}
