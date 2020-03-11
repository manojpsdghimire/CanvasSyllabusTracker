using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanvasAPITool.Model
{
    public class EnrollmentTerm
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime? start_at { get; set; }
        public DateTime? end_at { get; set; }
        public DateTime created_at { get; set; }
        public string workflow_state { get; set; }
        public object grading_period_group_id { get; set; }
        public string sis_term_id { get; set; }
        public object sis_import_id { get; set; }
    }
    public class Enrollment_Terms
    {
        public IEnumerable<EnrollmentTerm> enrollment_terms { get; set; }
    }
}
