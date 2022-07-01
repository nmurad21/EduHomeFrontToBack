using HomeworkEduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkEduHome.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Notice> Notices { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Choose> Chooses { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
