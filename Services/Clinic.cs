using HospitalClinicSystem.Enums;
using HospitalClinicSystem.Models;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
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

    }
}