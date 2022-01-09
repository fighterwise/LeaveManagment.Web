using AutoMapper;
using LeaveManagment.Web.Data;
using LeaveManagment.Web.Models;

namespace LeaveManagment.Web.Configurations
{
    public class Mapperconfig : Profile
    {
        public Mapperconfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }



    }
}
