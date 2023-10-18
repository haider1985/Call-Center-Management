using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Call_Center_Server.Models
{
    public class AssignedCallModel
    {
        [Required]
        public int Id { get; set; }

        [StringLength(10)]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [StringLength(100)]
        [Display(Name = "Assigned Employee Name")]
        public string AssignedEmployeeFullName { get; set; } = string.Empty;

        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Assigned Employee Email")]
        public string AssignedEmployeeEmail { get; set; } = string.Empty;

        public bool IsAssigned { get; set; } = false;


        [ForeignKey("CallModelId")]
        public int CallModelId { get; set; }
        public CallModel? CallModel { get; set; }
    }
}
