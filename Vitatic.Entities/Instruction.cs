using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitatic.Entities;

public class Instruction:EntityBase
{
    public int InterfaceId { get; set; }
    public Interface Interface { get; set; }
    [Required]
    [StringLength(50)]
    public string InstructionDetail { get; set; }

}
