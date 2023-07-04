using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ApiTuCarbure.EntityLayer;

[Table("Statement", Schema = "dbo")]
public partial class Statement
{
    public Statement()
    {

    }

    [Required]
    [Key]
    public Int32 id_Statement { get; set; }
    [Required]
    public DateTime DateTimeStatement { get; set; }
    [Required]
    public Double Price {get; set; }

}
