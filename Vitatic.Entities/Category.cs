using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitatic.Entities;

public class Category:EntityBase
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; }

}
