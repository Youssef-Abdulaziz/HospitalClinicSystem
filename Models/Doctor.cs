namespace HospitalClinicSystem.Models
{
    public class Doctor
    {
        public int DoctorId { get; private set; }
        public string DoctorName { get; private set; }
        public string Specialty { get; private set; }
        public string ContactNumber { get; private set; }


        public Doctor(int doctorId, string doctorName, string specialty, string contactNumber)
        {
            if (string.IsNullOrWhiteSpace(doctorName))
                throw new ArgumentException($"Doctor Name Can't Be Empty.");
            if (string.IsNullOrWhiteSpace(specialty))
                throw new ArgumentException($"Doctor Specialty Can't Be Empty.");
            DoctorId = doctorId;
            DoctorName = doctorName;
            Specialty = specialty;
            ContactNumber = contactNumber;
        }
    }

}