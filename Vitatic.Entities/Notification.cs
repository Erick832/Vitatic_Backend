using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitatic.Entities;

public class Notification:EntityBase
{
    [Required]
    [StringLength(50)]
    public string Content { get; set; }
    public int ReminderId { get; set; }
    public Reminder Reminder { get; set; }
}
