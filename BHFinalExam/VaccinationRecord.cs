/*  Program: VaccinationRecord.cs
 *  
 *  Description: Manages the Vaccination file io
 *  
 *  Name: Ben Hengeveld
 *  
 *  Revision History:
 *      Ben Hengeveld, 2021.04.29: Created
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHFinalExam
{
    public class VaccinationRecord
    {
        // The file name to read and write to
        private string filename = "vaccinations.txt";

        /// <summary>
        /// Default constructor that makes the file if it does not exist yet
        /// </summary>
        public VaccinationRecord()
        {
            // Check if file exists
            if (!File.Exists(this.filename))
            {
                // Make file if the file does not exist
                using (File.CreateText(this.filename)) { }
            }
        }

        /// <summary>
        /// Gets an id that is not already used
        /// </summary>
        /// <returns>The new id to use</returns>
        public int GetNewId()
        {
            // Gets all the vaccinations
            List<Vaccination> vaccinations = this.GetAllVaccinations();

            // Goes through all the vaccinations and finds the one with the highest id
            int highestID = -1;
            foreach (Vaccination vaccination in vaccinations)
            {
                if (vaccination.ID > highestID)
                {
                    highestID = vaccination.ID;
                }
            }

            // Return the number one higher then the highest id found
            return (highestID + 1);
        }

        /// <summary>
        /// Adds a new vaccination to the file
        /// </summary>
        /// <param name="newVaccination">The new vaccination to add</param>
        public void AddNewVaccination(Vaccination newVaccination)
        {
            // Checks if there is already a vaccination with the same id
            if (this.GetVaccinationById(newVaccination.ID) != null)
            {
                // There is a vaccination with the same id, so throw an error
                throw new Exception("That ID is already being used!\n");
            }

            // Add the new vaccination to the end of the file
            using (StreamWriter writer = File.AppendText(this.filename))
            {
                writer.WriteLine(newVaccination.ToString());
            }
        }

        /// <summary>
        /// Gets a list of all the vaccinations
        /// </summary>
        /// <returns>The list of vaccinations</returns>
        public List<Vaccination> GetAllVaccinations()
        {
            // Makes a list for the vaccinations
            List<Vaccination> vaccinations = new List<Vaccination>();

            // Reads each line of the file
            using (StreamReader reader = new StreamReader(this.filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    // Check if the line is empty
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Parses and then adds the vaccination if the line is not empty
                        vaccinations.Add(VaccinationRecord.ParseVaccination(line));
                    }
                }
            }

            //Return the list of vaccinations
            return vaccinations;
        }

        /// <summary>
        /// Finds a vaccination by the given id
        /// </summary>
        /// <param name="id">The id to search for</param>
        /// <returns>The vaccination with the matching id</returns>
        public Vaccination GetVaccinationById(int id)
        {
            // Gets a list of all the vaccinations
            List<Vaccination> vaccinations = this.GetAllVaccinations();

            // Search through all the vaccinations
            foreach (Vaccination vaccination in vaccinations)
            {
                // Check if the vaccination id matches the given id
                if (vaccination.ID == id)
                {
                    // Return the vaccination if the IDs match
                    return vaccination;
                }
            }

            // Return null if no id matches
            return null;
        }

        /// <summary>
        /// Update a vaccination with a new vaccination
        /// </summary>
        /// <param name="updatedVaccination">The vaccination to update with updated values</param>
        public void UpdateVaccination(Vaccination updatedVaccination)
        {
            // Gets a list of all the vaccinations
            List<Vaccination> vaccinations = this.GetAllVaccinations();

            // Keeps track if there was a vaccination that was updated
            bool vaccinationUpdated = false;
            // Loop through all the vaccinations
            for (int i = 0; i < vaccinations.Count(); i++)
            {
                // If a vaccination id matchs the given id update the vaccination
                if (vaccinations[i].ID == updatedVaccination.ID)
                {
                    vaccinations[i] = updatedVaccination;
                    vaccinationUpdated = true;
                }
            }
            // Check if a vaccination was updated, if not then tell the user
            if (!vaccinationUpdated)
            {
                throw new Exception("No vaccination with that ID!\n");
            }

            // Update the text file with the update vaccination
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                foreach (Vaccination vaccination in vaccinations)
                {
                    writer.WriteLine(vaccination.ToString());
                }
            }
        }

        /// <summary>
        /// Parses a string into a vaccination
        /// id|patientName|contactInfo|appointmentDateTime
        /// </summary>
        /// <param name="vaccinationString">The string to parse</param>
        /// <returns>The vaccination from the string</returns>
        private static Vaccination ParseVaccination(string vaccinationString)
        {
            // Split the string with the | character
            string[] splitData = vaccinationString.Split('|');
            //Make sure there is 4 values, otherwise through an error
            if (splitData.Length != 4)
            {
                throw new Exception("Invalid vaccination data in file!\n");
            }

            // Get all the diffrent values from the split data
            int id = 0;
            string patientName = splitData[1];
            string contactInfo = splitData[2];
            DateTime appointmentDateTime = DateTime.Now;
            if (!int.TryParse(splitData[0], out id))
            {
                throw new Exception("Invalid vaccination data in file!\n");
            }
            if (!DateTime.TryParse(splitData[3], out appointmentDateTime))
            {
                throw new Exception("Invalid vaccination data in file!\n");
            }

            // Make a new vaccination with the values and return the parsed vaccination
            Vaccination parsedVaccination = new Vaccination(id, patientName, contactInfo, appointmentDateTime);
            return parsedVaccination;
        }
    }
}
