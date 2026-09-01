
namespace HospitalClinicSystem.Model
{

    public class Patient
    {

        private int PatientId { get; set; }
        private string PatientName { get; set; }
        private int Age { get; set; }
        private string Gender { get; set; }
        private string ContactNumber { get; set; }

        public Patient(int patientId, string patientName, int age, string gender, string contactNumber)
        {
            if (string.IsNullOrWhiteSpace(patientName))
                throw new ArgumentException("Patientname Can't be empty");

            if (age <= 0)
                throw new ArgumentException("Patientname Age Must Be Greater Than 0");

            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Gender = gender;
            ContactNumber = contactNumber;
        }

    }
}