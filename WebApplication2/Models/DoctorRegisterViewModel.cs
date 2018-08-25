using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DoctorRegisterViewModel
    {
        public RegisterViewModel RegisterViewModel { get; set; }
        public Doctors Doctors { get; set; }
    }
}