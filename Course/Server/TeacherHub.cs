using Course.Server.Services;
using Microsoft.AspNetCore.SignalR;

namespace Course.Server
{
    public class TeacherHub : Hub
    {
        private TeacherService TeacherService {init;get;}

        public TeacherHub(TeacherService teacherService)
        {
            TeacherService = teacherService;
        }
       public async Task GetAllTeachers ()
        {
            await Clients.Caller.SendAsync("SendingList" , TeacherService.GettingTeachers());
        }
    }
}
