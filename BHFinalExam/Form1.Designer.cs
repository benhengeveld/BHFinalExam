namespace BHFinalExam
{
    partial class frmVaccinationTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVaccinationID = new System.Windows.Forms.Label();
            this.lblAppointmentDateTime = new System.Windows.Forms.Label();
            this.lblEmailPhone = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.txtVaccinationId = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtEmailPhone = new System.Windows.Forms.TextBox();
            this.dtpAppointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnGetNewId = new System.Windows.Forms.Button();
            this.btnLoadID = new System.Windows.Forms.Button();
            this.btnAddNewVaccination = new System.Windows.Forms.Button();
            this.btnUpdateVaccination = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnShowFutureVaccinations = new System.Windows.Forms.Button();
            this.txtFutureVaccinations = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblVaccinationID
            // 
            this.lblVaccinationID.AutoSize = true;
            this.lblVaccinationID.Location = new System.Drawing.Point(68, 36);
            this.lblVaccinationID.Name = "lblVaccinationID";
            this.lblVaccinationID.Size = new System.Drawing.Size(80, 13);
            this.lblVaccinationID.TabIndex = 0;
            this.lblVaccinationID.Text = "Vaccination ID:";
            // 
            // lblAppointmentDateTime
            // 
            this.lblAppointmentDateTime.AutoSize = true;
            this.lblAppointmentDateTime.Location = new System.Drawing.Point(33, 148);
            this.lblAppointmentDateTime.Name = "lblAppointmentDateTime";
            this.lblAppointmentDateTime.Size = new System.Drawing.Size(115, 13);
            this.lblAppointmentDateTime.TabIndex = 1;
            this.lblAppointmentDateTime.Text = "Appointment date time:";
            // 
            // lblEmailPhone
            // 
            this.lblEmailPhone.AutoSize = true;
            this.lblEmailPhone.Location = new System.Drawing.Point(68, 110);
            this.lblEmailPhone.Name = "lblEmailPhone";
            this.lblEmailPhone.Size = new System.Drawing.Size(80, 13);
            this.lblEmailPhone.TabIndex = 2;
            this.lblEmailPhone.Text = "Email or phone:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(76, 72);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(72, 13);
            this.lblPatientName.TabIndex = 3;
            this.lblPatientName.Text = "Patient name:";
            // 
            // txtVaccinationId
            // 
            this.txtVaccinationId.Location = new System.Drawing.Point(154, 33);
            this.txtVaccinationId.Name = "txtVaccinationId";
            this.txtVaccinationId.Size = new System.Drawing.Size(100, 20);
            this.txtVaccinationId.TabIndex = 4;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(154, 69);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(287, 20);
            this.txtPatientName.TabIndex = 5;
            // 
            // txtEmailPhone
            // 
            this.txtEmailPhone.Location = new System.Drawing.Point(154, 107);
            this.txtEmailPhone.Name = "txtEmailPhone";
            this.txtEmailPhone.Size = new System.Drawing.Size(287, 20);
            this.txtEmailPhone.TabIndex = 6;
            // 
            // dtpAppointmentDateTime
            // 
            this.dtpAppointmentDateTime.CustomFormat = "dddd,MMMM dd,yyyy h:mm tt";
            this.dtpAppointmentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDateTime.Location = new System.Drawing.Point(154, 146);
            this.dtpAppointmentDateTime.Name = "dtpAppointmentDateTime";
            this.dtpAppointmentDateTime.Size = new System.Drawing.Size(287, 20);
            this.dtpAppointmentDateTime.TabIndex = 7;
            // 
            // btnGetNewId
            // 
            this.btnGetNewId.Location = new System.Drawing.Point(260, 31);
            this.btnGetNewId.Name = "btnGetNewId";
            this.btnGetNewId.Size = new System.Drawing.Size(92, 23);
            this.btnGetNewId.TabIndex = 8;
            this.btnGetNewId.Text = "Get new ID";
            this.btnGetNewId.UseVisualStyleBackColor = true;
            this.btnGetNewId.Click += new System.EventHandler(this.btnGetNewId_Click);
            // 
            // btnLoadID
            // 
            this.btnLoadID.Location = new System.Drawing.Point(358, 31);
            this.btnLoadID.Name = "btnLoadID";
            this.btnLoadID.Size = new System.Drawing.Size(83, 23);
            this.btnLoadID.TabIndex = 9;
            this.btnLoadID.Text = "Load by ID";
            this.btnLoadID.UseVisualStyleBackColor = true;
            this.btnLoadID.Click += new System.EventHandler(this.btnLoadID_Click);
            // 
            // btnAddNewVaccination
            // 
            this.btnAddNewVaccination.Location = new System.Drawing.Point(36, 195);
            this.btnAddNewVaccination.Name = "btnAddNewVaccination";
            this.btnAddNewVaccination.Size = new System.Drawing.Size(195, 23);
            this.btnAddNewVaccination.TabIndex = 10;
            this.btnAddNewVaccination.Text = "Add new vaccination";
            this.btnAddNewVaccination.UseVisualStyleBackColor = true;
            this.btnAddNewVaccination.Click += new System.EventHandler(this.btnAddNewVaccination_Click);
            // 
            // btnUpdateVaccination
            // 
            this.btnUpdateVaccination.Location = new System.Drawing.Point(260, 195);
            this.btnUpdateVaccination.Name = "btnUpdateVaccination";
            this.btnUpdateVaccination.Size = new System.Drawing.Size(181, 23);
            this.btnUpdateVaccination.TabIndex = 11;
            this.btnUpdateVaccination.Text = "Update vaccination";
            this.btnUpdateVaccination.UseVisualStyleBackColor = true;
            this.btnUpdateVaccination.Click += new System.EventHandler(this.btnUpdateVaccination_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(33, 247);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 12;
            // 
            // btnShowFutureVaccinations
            // 
            this.btnShowFutureVaccinations.Location = new System.Drawing.Point(512, 31);
            this.btnShowFutureVaccinations.Name = "btnShowFutureVaccinations";
            this.btnShowFutureVaccinations.Size = new System.Drawing.Size(242, 23);
            this.btnShowFutureVaccinations.TabIndex = 13;
            this.btnShowFutureVaccinations.Text = "Show future vaccinations";
            this.btnShowFutureVaccinations.UseVisualStyleBackColor = true;
            this.btnShowFutureVaccinations.Click += new System.EventHandler(this.btnShowFutureVaccinations_Click);
            // 
            // txtFutureVaccinations
            // 
            this.txtFutureVaccinations.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFutureVaccinations.Location = new System.Drawing.Point(512, 60);
            this.txtFutureVaccinations.Name = "txtFutureVaccinations";
            this.txtFutureVaccinations.Size = new System.Drawing.Size(609, 158);
            this.txtFutureVaccinations.TabIndex = 14;
            this.txtFutureVaccinations.Text = "";
            // 
            // frmVaccinationTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 349);
            this.Controls.Add(this.txtFutureVaccinations);
            this.Controls.Add(this.btnShowFutureVaccinations);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnUpdateVaccination);
            this.Controls.Add(this.btnAddNewVaccination);
            this.Controls.Add(this.btnLoadID);
            this.Controls.Add(this.btnGetNewId);
            this.Controls.Add(this.dtpAppointmentDateTime);
            this.Controls.Add(this.txtEmailPhone);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtVaccinationId);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblEmailPhone);
            this.Controls.Add(this.lblAppointmentDateTime);
            this.Controls.Add(this.lblVaccinationID);
            this.Name = "frmVaccinationTracker";
            this.Text = "Vaccination Tracker - Ben Hengeveld";
            this.Load += new System.EventHandler(this.frmVaccinationTracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVaccinationID;
        private System.Windows.Forms.Label lblAppointmentDateTime;
        private System.Windows.Forms.Label lblEmailPhone;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtVaccinationId;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtEmailPhone;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDateTime;
        private System.Windows.Forms.Button btnGetNewId;
        private System.Windows.Forms.Button btnLoadID;
        private System.Windows.Forms.Button btnAddNewVaccination;
        private System.Windows.Forms.Button btnUpdateVaccination;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnShowFutureVaccinations;
        private System.Windows.Forms.RichTextBox txtFutureVaccinations;
    }
}

