using Call_Center_Server.Data;
using Call_Center_Server.Models;
using Call_Center_Server.Services.IServices;

using Microsoft.EntityFrameworkCore;

namespace Call_Center_Server.Services
{
    public class CallService : ICallService
    {
        private readonly ApplicationDbContext db;

        public CallService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<CallModel> CreateCallAsync(CallModel call)
        {
            await db.Calls.AddAsync(call);
            await db.SaveChangesAsync();
            return call;

        }

        public async Task<int> DeleteCallAsync(int callId)
        {
            var call = await db.Calls.FindAsync(callId);
            if (call != null)
            {
                db.Calls.Remove(call);
                await db.SaveChangesAsync();
                return callId;
            }
            return 0;
        }

        public async Task<CallModel> GetCallAsync(int callId)
        {
            if (callId != 0)
            {
                var call = await db.Calls.FindAsync(callId);
                if (call != null)
                {
                    return call;
                }
            }
            return new CallModel();
        }

        public async Task<IEnumerable<CallModel>> GetCallsAsync()
        {
            return await db.Calls.ToListAsync();
        }

        public async Task<CallModel> UpdateCallAsync(CallModel call)
        {
            var callfromDb = await db.Calls.FirstOrDefaultAsync(u=>u.Id==call.Id);
            if (callfromDb!=null)
            {
                db.Entry(callfromDb).CurrentValues.SetValues(call);
               await db.SaveChangesAsync();
                return callfromDb;
            }
            return call; 
        }
    }
}