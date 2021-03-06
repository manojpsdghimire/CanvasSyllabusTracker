﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanvasAPITool.Model
{
    public class Calendar
    {
        public string ics { get; set; }
    }

    public class Canvas_Courses
    {
        public int id { get; set; }
        public string name { get; set; }
        public int account_id { get; set; }
        public string uuid { get; set; }
        public string syllabus_body { get; set; }
        public DateTime? start_at { get; set; }
        public object grading_standard_id { get; set; }
        public bool? is_public { get; set; }
        public DateTime? created_at { get; set; }
        public string course_code { get; set; }
        public string default_view { get; set; }
        public int root_account_id { get; set; }
        public int enrollment_term_id { get; set; }
        public string license { get; set; }
        public object grade_passback_setting { get; set; }
        public DateTime? end_at { get; set; }
        public bool public_syllabus { get; set; }
        public bool public_syllabus_to_auth { get; set; }
        public int storage_quota_mb { get; set; }
        public bool is_public_to_auth_users { get; set; }
        public bool apply_assignment_group_weights { get; set; }
        public string usesGradeBook { get; set; }
        public string usesAttendance { get; set; }
        public string hasSyllabus { get; set; }
        public Calendar calendar { get; set; }
        public string time_zone { get; set; }
        public string Department { get; set; }
        public bool blueprint { get; set; }
        public string sis_course_id { get; set; }
        public object sis_import_id { get; set; }
        public object integration_id { get; set; }
        public bool hide_final_grades { get; set; }
        public string workflow_state { get; set; }
        public string CourseCode { get; set; }
        public bool restrict_enrollments_to_course_dates { get; set; }
    }
}
