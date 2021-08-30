using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementSystem.Models.ViewModels;

namespace TaskManagementSystem.Areas.Admin.ViewModel
{
    public class TaskReportDataViewModel
    {
        public string SearchExpression { get; set; }


        public List<TaskViewModel> TaskReportData { get; set; }
    }
}
