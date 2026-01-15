using CollegeSchedule.DTO;
using CollegeSchedule.Models;

namespace CollegeSchedule.Services
{
    public interface IScheduleService
    {
        // Старый метод
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime startDate, DateTime endDate);

        // Новый метод
        Task<List<StudentGroup>> GetAllGroups();
    }

}