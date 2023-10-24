using Call_Center_Server.Data;
using Call_Center_Server.Models;
using Call_Center_Server.Services.IServices;

using Microsoft.EntityFrameworkCore;

namespace Call_Center_Server.Services
{
    public class AssignCallService : IAssignCallService
    {
        private readonly ApplicationDbContext db;

        public AssignCallService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<AssignedCallModel> CreateAssignCallAsync(AssignedCallModel assignCall)
        {
            await db.AssignedCallModels.AddAsync(assignCall);
            await db.SaveChangesAsync();
            return assignCall;
        }

        public async Task<IEnumerable<AssignedCallModel>> GetAssignCallsAsync(int callId)
        {
            return await db.AssignedCallModels.Where(u => u.CallModelId == callId).ToListAsync();
        }
    }
}
