using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CanvasAPITool.Model
{
    [Table("_WC_CanvasAPIData")]
    public partial class CanvasAPI
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("syllabus_body")]
        public string SyllabusBody { get; set; }
        [Column("start_at")]
        public string StartAt { get; set; }
        [Column("created_at")]
        public string CreatedAt { get; set; }
        [Column("course_code")]
        public string Course_Code { get; set; }
        [Column("enrollment_term_id")]
        public string EnrollmentTermId { get; set; }
        [Column("end_at")]
        public string EndAt { get; set; }
        [Column("usesGradeBook")]
        public string UsesGradeBook { get; set; }
        [Column("hasSyllabus")]
        public string HasSyllabus { get; set; }
        [Column("workflow_state")]
        public string WorkflowState { get; set; }
        [Column("usesAttendence")]
        public string UsesAttendence { get; set; }
        public string Department { get; set; }
        public string CourseCode { get; set; }
    }
}
