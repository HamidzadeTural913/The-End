using BigExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigExam.ViewModels
{
    public class HomeVM
    {
       public List<Service> Services { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
