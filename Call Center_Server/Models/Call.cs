using System.ComponentModel.DataAnnotations;

namespace Call_Center_Server.Models
{
    public class Call
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(
            maximumLength: 50,
            MinimumLength = 3,
            ErrorMessage = "The caller name must be more than 3 letters and below 50 letters"
            )]
        [Display(Name ="Caller Name")]
        public string CallerName { get; set; } = string.Empty;

        [Display(Name = "Call Date & time")]
        public DateTime CallDateTime { get; set; } = DateTime.Now;

        [Display(Name = "Company Name")]
        public string CallerCompanyName { get; set; } = string.Empty;

        [Required]
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
           ErrorMessage = "The receiving call name must be more than 3 letters and below 50 letters"
           )]
        [Display(Name = "Receiving Call Name")]
        public string ReceivingCallName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Stage")]
        public string CallStage { get; set; } = string.Empty;
    }
}
