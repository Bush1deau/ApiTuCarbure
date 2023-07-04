using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ApiTuCarbure.EntityLayer;

[Table("Fuel", Schema = "dbo")]
public partial class Fuel
{
    public Fuel()
    {
        Name = string.Empty;
        codeEuro = string.Empty;
    }

    [Required]
    [Key]
    public Int32 id_Fuel { get; set; }
    [Required]
    public String Name { get; set; }
    [Required]
    public String codeEuro { get; set;}


}
