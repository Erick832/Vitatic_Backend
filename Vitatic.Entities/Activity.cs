using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitatic.Entities;

public class Activity:EntityBase
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int DurationMinutes { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int PriorityId { get; set; }
    public Priority Priority { get; set; }
    public int ProgressId { get; set; }
    public Progress Progress { get; set; }
    public int ScheduleId { get; set; }
    public Schedule Schedule { get; set; }

}
