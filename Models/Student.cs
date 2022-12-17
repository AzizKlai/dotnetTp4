using System.ComponentModel.DataAnnotations;
namespace tp4.Models
{
public class Student
{    
    [Key]
    public Int64 id{ get; set;}
    public string? first_name{ get; set;}
    public string? last_name{ get; set;}
    public string? phone_number{ get; set;}
    //[DataType(DataType.Date)]
    //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public string?  university { get; set; }
    public string? timestamp{ get; set;}
    public string? course{ get; set;}

}
}