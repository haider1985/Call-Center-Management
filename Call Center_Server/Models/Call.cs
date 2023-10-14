namespace Call_Center_Server.Models
{
    public class Call
    {
        public int Id { get; set; }
        public string CallerName { get; set; } = string.Empty;
        public DateTime CallDateTime { get; set; } = DateTime.Now;
        public string CallerCompanyName { get; set; } = string.Empty;
        public string CallerPhone { get; set;} = string.Empty;
        public string CallerEmail { get; set; } = string.Empty;
        public string CallerAddress { get; set; } = string.Empty;
        public string CallReason { get; set; } = string.Empty;
        public string CallsUrgency { get; set; } = string.Empty;
        public string CallStatus { get; set; } = string.Empty;
        public string ReceivingCallName { get; set; } = string.Empty;
        public string CallStage { get; set; } = string.Empty;

    }
}
