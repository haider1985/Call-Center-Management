using Call_Center_Server.Models;

namespace Call_Center_Server.Services.IServices
{
    public interface IAssignCallService
    {
        public Task<AssignedCallModel> CreateAssignCallAsync(AssignedCallModel assignCall);

        public Task<IEnumerable<AssignedCallModel>> GetAssignCallsAsync(int callId);
    }
}
