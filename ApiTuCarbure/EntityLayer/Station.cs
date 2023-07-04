using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ApiTuCarbure.EntityLayer;

[Table("Station", Schema = "dbo")]
public partial class Station
{
    public Station()
    {
        Address = string.Empty;
    }

    [Required]
    [Key]
    public Int32 id_Station { get; set; }
    [Required]
    public String Address { get; set; }
    [Required]
    public Double Latitude {get; set; }
    [Required]
    public Double Longitude {get; set;}



    [ForeignKey("FK_Brand")]
    public Brand Brand { get; set; }
}
