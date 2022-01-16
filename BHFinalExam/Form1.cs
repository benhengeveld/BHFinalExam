/*  Program: Form1.cs
 *  
 *  Description: A form for a user to add, update, and view vaccination appointments
 *  
 *  Name: Ben Hengeveld
 *  
 *  Revision History:
 *      Ben Hengeveld, 2021.04.29: Created
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHFinalExam
{
    public partial class frmVaccinationTracker : Form
    {
        VaccinationRecord vaccinationRecord = new VaccinationRecord();

        /// <summary>
        /// Clears all the vaccination forms fields
        /// </summary>
        public void ClearVaccinationForm()
        {
            txtVaccinationId.Clear();
            txtPatientName.Clear();
            txtEmailPhone.Clear();
            dtpAppointmentDateTime.Value = DateTime.Now;
        }

        public frmVaccinationTracker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the form loads get the display header and add it to the future vaccinations text box
        /// </summary>
        private void frmVaccinationTracker_Load(object sender, EventArgs e)
        {
            txtFutureVaccinations.Text += $"{Vaccination.DisplayHeader}\n";
        }

        /// <summary>
        /// Gets a new id that has not been used already
        /// </summary>
        private void btnGetNewId_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            txtVaccinationId.Text = vaccinationRecord.GetNewId().ToString();
        }

        /// <summary>
        /// Loads a vaccination from the given id
        /// </summary>
        private void btnLoadID_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            // Gets the id given by the user
            int id = 0;
            if (!int.TryParse(txtVaccinationId.Text, out id))
            {
                lblOutput.Text = "Invalid ID!\n";
            }

            try
            {
                // Gets the vaccination that matches that id, if any
                Vaccination vaccination = vaccinationRecord.GetVaccinationById(id);

                // Clears the form and then loads the vaccinations values
                ClearVaccinationForm();
                txtVaccinationId.Text = vaccination.ID.ToString();
                txtPatientName.Text = vaccination.PatientName;
                txtEmailPhone.Text = vaccination.ContactInfo;
                dtpAppointmentDateTime.Value = vaccination.AppointmentDateTime;

                // Tell the user that the vaccination was loaded
                lblOutput.Text = "User loaded!\n";
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        /// <summary>
        /// Makes a new vaccinations and saves it to the file
        /// </summary>
        private void btnAddNewVaccination_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            // Get all the vaccination values given by the user
            int id = 0;
            string patientName = txtPatientName.Text;
            string contactInfo = txtEmailPhone.Text;
            DateTime appointmentDateTime = dtpAppointmentDateTime.Value;
            if (!int.TryParse(txtVaccinationId.Text, out id))
            {
                lblOutput.Text = "Invalid ID!\n";
            }

            try
            {
                // Make the vaccination with the given values
                Vaccination vaccination = new Vaccination(id, patientName, contactInfo, appointmentDateTime);
                // Add the vaccination to the file
                vaccinationRecord.AddNewVaccination(vaccination);

                // Tell the user that the vaccination was added and clear the vaccination form
                lblOutput.Text = $"New vaccination for \"{patientName}\" was recorded successfully!\n";
                ClearVaccinationForm();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        /// <summary>
        /// Updates a vaccination
        /// </summary>
        private void btnUpdateVaccination_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            // Get all the vaccination values given by the user
            int id = 0;
            string patientName = txtPatientName.Text;
            string contactInfo = txtEmailPhone.Text;
            DateTime appointmentDateTime = dtpAppointmentDateTime.Value;
            if (!int.TryParse(txtVaccinationId.Text, out id))
            {
                lblOutput.Text = "Invalid ID!\n";
            }

            try
            {
                // Make the vaccination with the given values
                Vaccination vaccination = new Vaccination(id, patientName, contactInfo, appointmentDateTime);
                //Update the vaccination if there is a vaccination with a matching id
                vaccinationRecord.UpdateVaccination(vaccination);

                // Tell the user that the vaccination was updated and clear the vaccinations form
                lblOutput.Text = $"Vaccination for \"{patientName}\" was updated successfully!\n";
                ClearVaccinationForm();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        /// <summary>
        /// Shows all the vaccinations that are in the future
        /// </summary>
        private void btnShowFutureVaccinations_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            // Clear the form and get the header
            txtFutureVaccinations.Clear();
            txtFutureVaccinations.Text += $"{Vaccination.DisplayHeader}\n";

            // Get a list of all the vaccinations and loop through them all
            List<Vaccination> vaccinations = vaccinationRecord.GetAllVaccinations();
            foreach (Vaccination vaccination in vaccinations)
            {
                //If the vaccination is in the future then add the display record to the future vaccinations rich text box
                if (vaccination.AppointmentDateTime >= DateTime.Now)
                {
                    txtFutureVaccinations.Text += $"{vaccination.ToDisplayRecord()}\n";
                }
            }
        }
    }
}
