/*  Program: Vaccination.cs
 *  
 *  Description: An object for a vaccination appointment
 *  
 *  Name: Ben Hengeveld
 *  
 *  Revision History:
 *      Ben Hengeveld, 2021.04.29: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BHFinalExam
{
    public class Vaccination
    {
        // A header for the future vaccination rich text box
        public static readonly string DisplayHeader = "ID\tPatient Name\t\tContect Info\t\t\tAppt Date\t\tAppt Time";

        //Regex patterns for name, email, and phone number
        private Regex nameRegex = new Regex(@"^\w\w+\s\w\w+$");
        private Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)\.\w+$");
        private Regex phoneRegex = new Regex(@"^\(?\d{3}\)?[-|\s]?\d{3}[-|\s]?\d{4}$");

        public int ID { get; }
        public string PatientName { get; set; }
        public string ContactInfo { get; set; }
        public DateTime AppointmentDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The id for the vaccination, must be a positive number</param>
        /// <param name="patientName">The name of the patient, must be two words with 2 letters in each</param>
        /// <param name="contactInfo">Phone number or email</param>
        /// <param name="appointmentDateTime">Date of the appointment</param>
        public Vaccination(int id, string patientName, string contactInfo, DateTime appointmentDateTime)
        {
            string errors = "";

            // Check for invalid values
            // ID
            if (id < 0)
            {
                errors += "ID Must be a positive number!\n";
            }

            // Name
            if (!nameRegex.IsMatch(patientName))
            {
                errors += "Invalid name!\n";
            }

            // Contact Info
            if (!emailRegex.IsMatch(contactInfo) && !phoneRegex.IsMatch(contactInfo))
            {
                errors += "Invalid email or phone!\n";
            }
            // If any errors then tell the user
            if (errors != "")
            {
                throw new Exception(errors);
            }

            ID = id;
            PatientName = patientName;
            ContactInfo = contactInfo;
            AppointmentDateTime = appointmentDateTime;
        }

        /// <summary>
        /// Makes a string that is used for the future vaccination rich text box
        /// </summary>
        /// <returns>The string for the future vaccination rich text box</returns>
        public string ToDisplayRecord()
        {
            return $"{ID}\t{PatientName}\t\t{ContactInfo}\t\t{AppointmentDateTime.ToString("yyyy-MM-dd")}\t\t{AppointmentDateTime.ToString("h:mm tt")}";
        }

        /// <summary>
        /// Makes a string to store in a file, and used to parse back into a vaccination latter
        /// </summary>
        /// <returns>The string to store in a file</returns>
        public override string ToString()
        {
            return $"{ID}|{PatientName}|{ContactInfo}|{AppointmentDateTime.ToString()}";
        }
    }
}
