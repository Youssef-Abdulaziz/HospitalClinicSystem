using System;
using System.Collections.Generic;
using HospitalClinicSystem.Models;
using HospitalClinicSystem.Enums;
using HospitalClinicSystem.Services;

namespace HospitalClinicSystem
{
    class Program
    {
        private static Clinic clinic = new Clinic();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n--- Hospital Clinic System ---");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. View All Patients");
                Console.WriteLine("4. View All Doctors");
                Console.WriteLine("5. Book Appointment");
                Console.WriteLine("6. View All Appointments");
                Console.WriteLine("7. Update Appointment Status");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddPatient(); break;
                    case "2": AddDoctor(); break;
                    case "3": ViewAllPatients(); break;
                    case "4": ViewAllDoctors(); break;
                    case "5": BookAppointment(); break;
                    case "6": ViewAllAppointment(); break;
                    case "7": UpdateAppointmentStatus(); break;
                    case "8": isRunning = false; break;
                    default: Console.WriteLine("Invalid option. try again."); break;
                }
            }
        }

        private static void AddPatient()
        {
            Console.Write("Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string patientName = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Gender (Male/Female/Other): ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());

            Console.Write("Contact Number: ");
            string patientContact = Console.ReadLine();

            try
            {
                clinic.AddPatient(patientId, patientName, age, gender, patientContact);
                Console.WriteLine("Patient added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


    }
}