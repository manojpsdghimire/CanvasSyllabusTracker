using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanvasAPITool.Model
{
    public class Courses_Documents
    {
        public int id { get; set; }
        public string uuid { get; set; }
        public int folder_id { get; set; }
        public string display_name { get; set; }
        public string filename { get; set; }
        public string upload_status { get; set; }
        public string __invalid_name__content_type { get; set; }
        public string url { get; set; }
        public int size { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public object unlock_at { get; set; }
        public bool locked { get; set; }
        public bool hidden { get; set; }
        public object lock_at { get; set; }
        public bool hidden_for_user { get; set; }
        public string thumbnail_url { get; set; }
        public DateTime? modified_at { get; set; }
        public string mime_class { get; set; }
        public object media_entry_id { get; set; }
        public bool locked_for_user { get; set; }
    }
    public class Course_Syllabus
    {
        public IEnumerable<Courses_Documents> syllabus { get; set; }
    }
}
