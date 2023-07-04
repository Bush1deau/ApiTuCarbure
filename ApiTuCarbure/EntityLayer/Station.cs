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
    public int id_Station { get; set; }
    public String Address { get; set; }
    /*[Required]
    public float Latitude {get; set; }
    [Required]
    public float Longitude {get; set;}*/
}
