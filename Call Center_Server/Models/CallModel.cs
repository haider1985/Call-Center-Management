using System.ComponentModel.DataAnnotations;

namespace Call_Center_Server.Models
{
    public class CallModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(
            maximumLength: 50,
            MinimumLength = 3,
            ErrorMessage = "Invalid Customer Name."
            )]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; } = string.Empty;

        [Display(Name = "Call Date & time")]
        public DateTime CallDateTime { get; set; } = DateTime.Now;

        [Display(Name = "Company Name")]
        public string CustomerCompanyName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Invalid Phone Number.")]
        [Display(Name = "Customer Phone Number")]
        public string CustomerPhone { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Customer Email")]
        public string CustomerEmail { get; set; } = string.Empty;

        [Display(Name = "Company Address")]
        public string CustomerCompanyAddress { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Reason of Call")]
        public string CallReason { get; set; } = string.Empty;

        [Display(Name = "Urgency Level")]
        public string CallsUrgency { get; set; } = string.Empty;

        [Display(Name = "Status")]
        public string CallStatus { get; set; } = string.Empty;

        [Required]
        [StringLength(
           maximumLength: 50,
           MinimumLength = 3,
           ErrorMessage = "Invalid Employee Name"
           )]
        [Display(Name = "Agent Employee Name")]
        public string AgentEmployeeName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Stage")]
        public string CallStage { get; set; } = "New";


        //Relationship calls to assigned person.
        public ICollection<AssignedCallModel> AssignedEmployees { get; set; } = new List<AssignedCallModel>();
    }
}
