using System;
using HospitalClinicSystem.Enums;
namespace HospitalClinicSystem.Models
{
    public class Appointment
    {
        public int AppointmentId { get; private set; }
        public Patient AppointmentPatient { get; private set; }
        public Doctor AppointmentDoctor { get; private set; }
        public DateTime AppointmentTime { get; private set; }
        public AppointmentStatus AppointmentStatus { get; private set; }

        public Appointment(int appointmentId, Patient appointmentPatient, Doctor appointmentDoctor, DateTime appointmentTime, AppointmentStatus appointmentStatus)
        {

            AppointmentId = appointmentId;
            AppointmentPatient = appointmentPatient ?? throw new ArgumentNullException(nameof(appointmentPatient));
            AppointmentDoctor = appointmentDoctor ?? throw new ArgumentNullException(nameof(appointmentDoctor));
            AppointmentTime = appointmentTime;
            AppointmentStatus = appointmentStatus;
        }
        public void UpdateStatus(AppointmentStatus newStatus)
        {
            AppointmentStatus = newStatus;
        }

    }
}