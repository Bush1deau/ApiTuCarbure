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

    [ForeignKey("FK_Station")]
    public Station Station { get; set; }

    [ForeignKey("FK_Fuel")]
    public Fuel Fuel { get; set; }

}
