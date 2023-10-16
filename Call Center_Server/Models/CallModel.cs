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
        [Display(Name ="Caller Name")]
        public string CallerName { get; set; } = string.Empty;

        [Display(Name = "Call Date & time")]
        public DateTime CallDateTime { get; set; } = DateTime.Now;

        [Display(Name = "Company Name")]
        public string CallerCompanyName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Invalid Phone Number.")]
        [Display(Name = "Caller Phone Number")]
        public string CallerPhone { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Caller Email")]
        public string CallerEmail { get; set; } = string.Empty;

        [Display(Name = "Company Address")]
        public string CallerAddress { get; set; } = string.Empty;

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
        [Display(Name = "Receiving Call Name")]
        public string ReceivingCallName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Stage")]
        public string CallStage { get; set; } = "New";
    }
}
