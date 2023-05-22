using AppointmentScheduling.Service;
using AppointmentScheduling.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheduling.Controllers
{
    [Authorize]

    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        //if we want to only Admin accsess to this action we have to use attributes like this. 
        //[Authorize(Roles =Helper.Admin)]
        public IActionResult Index()
        {
            ViewBag.DoctorList = _appointmentService.GetDoctorList();
            ViewBag.PatientList = _appointmentService.GetPatientList();
            ViewBag.Duration = Helper.GetTimeDropDown();
            return View();
        }
    }
}
