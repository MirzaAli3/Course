using Course.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace Course.Client
{ 
  
    

    public class SRservice
    {
       
        private HubConnection _teacherHub { get; set; }
        public HubConnection TeacherHub { get => _teacherHub; }
        public List<Teacher> Teachers { get; set; } = new();
        public SRservice(NavigationManager nm)
        {
            _teacherHub = new HubConnectionBuilder().
            WithUrl(nm.BaseUri + "teacherHub").
            Build();
            _teacherHub.StartAsync();
            _teacherHub.SendAsync("GetAllTeachers");
            _teacherHub.On<List<Teacher>>("SendingList", list=>GettingAllTeachers(list));





        }
        public void GettingAllTeachers(List<Teacher> teachers)
        => Teachers = teachers;
        
    }
}
