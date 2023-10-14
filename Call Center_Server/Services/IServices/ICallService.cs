using Call_Center_Server.Models;

using System.Collections.Generic;

namespace Call_Center_Server.Services.IServices
{
    public interface ICallService
    {
        public Task<CallModel> CreateCallAsync(CallModel call);
        public Task<CallModel> UpdateCallAsync(CallModel call);
        public Task<int> DeleteCallAsync(int callId);
        public Task<CallModel> GetCallAsync(int callId);
        public Task<IEnumerable<CallModel>> GetCallsAsync();
    }
}
