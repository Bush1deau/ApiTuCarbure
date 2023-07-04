using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ApiTuCarbure.EntityLayer;

[Table("Brand", Schema = "dbo")]
public partial class Brand
{
    public Brand()
    {
        Name = string.Empty;
    }

    [Required]
    [Key]
    public Int32 id_Brand { get; set; }
    [Required]
    public String Name { get; set; } 
}
