using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ApiTuCarbure.EntityLayer;

[Table("StationFuel", Schema = "dbo")]
public partial class StationFuel
{
    public StationFuel()
    {
    }


    [Required]
    [Key]
    public Int32 id_StationFuel { get; set; }

    [ForeignKey("FK_Station")]
    public Station Station { get; set; }

    [ForeignKey("FK_Fuel")]
    public Fuel Fuel { get; set; }


}