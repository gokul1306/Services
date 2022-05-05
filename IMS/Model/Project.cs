using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Model
{
    public class Project
    {
     [Key]
     public int ProjectId{get; set;}
     public string ProjectName{get;set;}
     public bool IsActive { get; set; } = true;
     public int  DepartmentId{get;set;}


      [ForiegnKey("DepartmentId")]
     [InverseProperty("Projects")]
     public virtual Department? department { get; set; }
    }
}