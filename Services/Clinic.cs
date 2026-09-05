using HospitalClinicSystem.Enums;
using HospitalClinicSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace HospitalClinicSystem.Services
{
    public class Clinic
    {
        private readonly List<Patient> _patients = new List<Patient>();
        private readonly List<Doctor> _doctors = new List<Doctor>();
        private readonly List<Appointment> _appointments = new List<Appointment>();

        public Patient AddPatient(int patientId, string patientName, int age, Gender gender, string contactNumber)
        {
            if (_patients.Any(p => p.PatientId == patientId))
                throw new InvalidOperationException($"Patient {patientId} Is Already in the System.");
            Patient patient = new Patient(patientId, patientName, age, gender, contactNumber);
            _patients.Add(patient);
            return patient;
        }

        public Doctor AddDoctor(int doctorId, string doctorName, string specialty, string contactNumber)
        {
            if (_doctors.Any(d => d.DoctorId == doctorId))
                throw new InvalidOperationException($"Doctor {doctorId} Is Already in the System");
            Doctor doctor = new Doctor(doctorId, doctorName, specialty, contactNumber);
            _doctors.Add(doctor);
            return doctor;
        }

        public List<Patient> ViewAllPatients()
        {
            return new List<Patient>(_patients);
        }

        public List<Doctor> ViewAllDoctors()
        {
            return new List<Doctor>(_doctors);
        }

        public Appointment BookingAppointment(int appointmentId, int patientId, int doctorId, DateTime appointmentTime)
        {
            Patient patient = _patients.FirstOrDefault(p => p.PatientId == patientId);
            if (patient == null)
                throw new InvalidOperationException($"Patient {patientId} not found");
            Doctor doctor = _doctors.FirstOrDefault(d => d.DoctorId == doctorId);
            throw new InvalidOperationException($"Doctor {doctorId} not found");

            bool isDoctorBusy = _appointments.Any(a =>
            a.AppointmentDoctor.DoctorId == doctorId &&
            a.AppointmentTime == appointmentTime &&
            a.AppointmentStatus != AppointmentStatus.Cancelled
            );
            if (isDoctorBusy)
                throw new InvalidOperationException($"Doctor {doctorId} already has an appointment at {appointmentTime}.");


            Appointment appointment = new Appointment(appointmentId, patient, doctor, appointmentTime, AppointmentStatus.Pending);
            _appointments.Add(appointment);
            return appointment;
        }

        public List<Appointment> ViewAllAppointment()
        {
            return new List<Appointment>(_appointments);
        }

        public void UpdateAppointmentStatus(int appointmentId, AppointmentStatus newStatus)
        {
            Appointment appointment = _appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
            if (appointment == null)
                throw new InvalidOperationException($"Appointment {appointmentId} not found.");
            appointment.UpdateStatus(newStatus);
        }

    }
}