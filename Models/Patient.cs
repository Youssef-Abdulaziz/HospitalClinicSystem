
using HospitalClinicSystem.Enums;
namespace HospitalClinicSystem.Models
{

    public class Patient
    {

        public int PatientId { get; private set; }
        public string PatientName { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }
        public string ContactNumber { get; private set; }

        public Patient(int patientId, string patientName, int age, Gender gender, string contactNumber)
        {
            if (string.IsNullOrWhiteSpace(patientName))
                throw new ArgumentException("Patientname Can't be empty");

            if (age <= 0)
                throw new ArgumentException("Patient Age Must Be Greater Than 0");

            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Gender = gender;
            ContactNumber = contactNumber;
        }

    }
}