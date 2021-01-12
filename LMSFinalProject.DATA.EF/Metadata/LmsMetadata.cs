using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSFinalProject.DATA.EF
{
    class LmsMetadata
    {
        #region Course
       public class CourseMetadata
        {
            [Required(ErrorMessage ="*Course ID is required")]
            [Display(Name ="Course ID")]
            [StringLength(int.MaxValue,ErrorMessage ="*Course ID must be greater than 0")]
            public int CourseId { get; set; }

            [Required(ErrorMessage ="*Course Name is required")]
            [Display(Name ="Course Name")]
            [StringLength(200,ErrorMessage ="*Course Name must be less than 200 characters")]
            public string CourseName { get; set; }

            [DisplayFormat(NullDisplayText ="[N/A]")]
            [Display(Name ="Course Description")]
            [StringLength(500,ErrorMessage ="*Course Description must be less than 500 characters")]
            public string CourseDescription { get; set; }

            [Display(Name ="Is Active")]
            public bool IsActive { get; set; }
        }
        #endregion

        #region CourseCompletion
        public class CCMetadata
        {
            [Required(ErrorMessage = "*Course Completion ID is required")]
            [Display(Name = "Course Completion ID")]
            [StringLength(int.MaxValue, ErrorMessage = "*Course Completion ID must be greater than 0")]
            public int CourseCompletionId { get; set; }

            [Required(ErrorMessage ="*User ID is required")]
            [Display(Name ="*User ID")]
            [StringLength(128,ErrorMessage ="*User ID must be less then 128 characters")]
            public string UserId { get; set; }

            [Required(ErrorMessage ="*Course ID is required")]
            [Display(Name ="Course ID")]
            [StringLength(int.MaxValue,ErrorMessage ="*Course ID must be greater than 0")]
            public int CourseId { get; set; }

            [Required(ErrorMessage ="*Date Completed required")]
            [Display(Name ="Date Completed")]
            [DisplayFormat(DataFormatString ="{0:d}")]
            public System.DateTime DateCompleted { get; set; }
        }
        #endregion

        #region Lesson
        public class LessonMetadata
        {
            //public int LessonId { get; set; }

            [Required(ErrorMessage ="*Lesson Title required")]
            [Display(Name ="Lesson Title")]
            [StringLength(200,ErrorMessage ="*Lesson Title must be less then 200 characters")]
            public string LessonTitle { get; set; }

            [Required(ErrorMessage ="*Course ID is required")]
            [Display(Name ="Course ID")]
            [StringLength(int.MaxValue,ErrorMessage ="*Course ID must be greater than 0")]
            public int CourseId { get; set; }

            [DisplayFormat(NullDisplayText ="[N/A]")]
            [StringLength(300,ErrorMessage ="*Introduction must be less than 300 characters")]
            public string Introduction { get; set; }

            [DisplayFormat(NullDisplayText = "[N/A]")]
            [StringLength(250,ErrorMessage ="*Video URL can not exceed 250 characters")]
            [Display(Name ="Video URL")]
            public string VideoURL { get; set; }

            [DisplayFormat(NullDisplayText = "[N/A]")]
            [StringLength(100,ErrorMessage ="*PDF File Name must be less than 100 characters")]
            [Display(Name ="PDF File Name")]
            public string PdfFilename { get; set; }

            [Display(Name ="Is Active")]
            public bool IsActive { get; set; }
        }
        #endregion

        #region Lesson View
        public class LessonViewMetadata
        {
            //public int LessonViewId { get; set; }

            [Required(ErrorMessage = "*User ID is required")]
            [Display(Name = "*User ID")]
            [StringLength(128, ErrorMessage = "*User ID must be less then 128 characters")]
            public string UserId { get; set; }

            [Required(ErrorMessage ="*Lesson ID required")]
            [Display(Name ="Lesson ID")]
            [StringLength(int.MaxValue,ErrorMessage ="*Lesson ID must be greater than 0")]
            public int LessonId { get; set; }

            [Required(ErrorMessage = "*Date Viewed required")]
            [Display(Name = "Date Viewed")]
            [DisplayFormat(DataFormatString = "{0:d}")]
            public System.DateTime DateViewed { get; set; }
        }
        #endregion

        #region UserDetails
        public class UserDetailsMetadata
        {

            [Required(ErrorMessage ="*User ID required")]
            [Display(Name ="User ID")]
            [StringLength(128, ErrorMessage ="*User ID can not exceed 128 characters")]
            public string UserId { get; set; }

            [Required(ErrorMessage ="*First Name required")]
            [Display(Name ="First Name")]
            [StringLength(50,ErrorMessage ="*First Name must be less than 50 characters")]
            public string FirstName { get; set; }

            [Required(ErrorMessage ="*Last Name required")]
            [Display(Name ="Last Name")]
            [StringLength(50,ErrorMessage ="*Last Name must be less than 50 characters")]
            public string LastName { get; set; }
        }
        #endregion
    }
}
