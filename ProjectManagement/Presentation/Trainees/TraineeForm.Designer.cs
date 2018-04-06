namespace ProjectManagement.Presentation.Trainees
{
    partial class TraineeForm
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label updateDateLabel;
            System.Windows.Forms.Label createDateLabel1;
            System.Windows.Forms.Label label1;
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cordonnés_GroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxDates = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            updateDateLabel = new System.Windows.Forms.Label();
            createDateLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.Cordonnés_GroupBox.SuspendLayout();
            this.groupBoxDates.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 34);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email:";
            emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(6, 44);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(6, 89);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(6, 68);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 11;
            phoneNumberLabel.Text = "Phone Number:";
            phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // updateDateLabel
            // 
            updateDateLabel.AutoSize = true;
            updateDateLabel.Location = new System.Drawing.Point(23, 25);
            updateDateLabel.Name = "updateDateLabel";
            updateDateLabel.Size = new System.Drawing.Size(71, 13);
            updateDateLabel.TabIndex = 13;
            updateDateLabel.Text = "Update Date:";
            updateDateLabel.Click += new System.EventHandler(this.updateDateLabel_Click);
            // 
            // createDateLabel1
            // 
            createDateLabel1.AutoSize = true;
            createDateLabel1.Location = new System.Drawing.Point(23, 66);
            createDateLabel1.Name = "createDateLabel1";
            createDateLabel1.Size = new System.Drawing.Size(67, 13);
            createDateLabel1.TabIndex = 17;
            createDateLabel1.Text = "Create Date:";
            createDateLabel1.Click += new System.EventHandler(this.createDateLabel1_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 13);
            label1.TabIndex = 12;
            label1.Text = "Group :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(93, 34);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(211, 20);
            this.emailTextBox.TabIndex = 4;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(ProjectManagement.Entities.Trainee);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(105, 41);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(105, 86);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(218, 20);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(93, 65);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(211, 20);
            this.phoneNumberTextBox.TabIndex = 12;
            // 
            // updateDateDateTimePicker
            // 
            this.updateDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.traineeBindingSource, "UpdateDate", true));
            this.updateDateDateTimePicker.Enabled = false;
            this.updateDateDateTimePicker.Location = new System.Drawing.Point(110, 19);
            this.updateDateDateTimePicker.Name = "updateDateDateTimePicker";
            this.updateDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.updateDateDateTimePicker.TabIndex = 14;
            this.updateDateDateTimePicker.ValueChanged += new System.EventHandler(this.updateDateDateTimePicker_ValueChanged);
            // 
            // createDateDateTimePicker1
            // 
            this.createDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.traineeBindingSource, "group.CreateDate", true));
            this.createDateDateTimePicker1.Enabled = false;
            this.createDateDateTimePicker1.Location = new System.Drawing.Point(110, 62);
            this.createDateDateTimePicker1.Name = "createDateDateTimePicker1";
            this.createDateDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.createDateDateTimePicker1.TabIndex = 18;
            this.createDateDateTimePicker1.ValueChanged += new System.EventHandler(this.createDateDateTimePicker1_ValueChanged);
            // 
            // Cordonnés_GroupBox
            // 
            this.Cordonnés_GroupBox.Controls.Add(label1);
            this.Cordonnés_GroupBox.Controls.Add(this.comboBox1);
            this.Cordonnés_GroupBox.Controls.Add(firstNameLabel);
            this.Cordonnés_GroupBox.Controls.Add(this.firstNameTextBox);
            this.Cordonnés_GroupBox.Controls.Add(this.lastNameTextBox);
            this.Cordonnés_GroupBox.Controls.Add(lastNameLabel);
            this.Cordonnés_GroupBox.Location = new System.Drawing.Point(14, 17);
            this.Cordonnés_GroupBox.Name = "Cordonnés_GroupBox";
            this.Cordonnés_GroupBox.Size = new System.Drawing.Size(346, 160);
            this.Cordonnés_GroupBox.TabIndex = 27;
            this.Cordonnés_GroupBox.TabStop = false;
            this.Cordonnés_GroupBox.Text = "Civil status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // groupBoxDates
            // 
            this.groupBoxDates.Controls.Add(this.updateDateDateTimePicker);
            this.groupBoxDates.Controls.Add(updateDateLabel);
            this.groupBoxDates.Controls.Add(createDateLabel1);
            this.groupBoxDates.Controls.Add(this.createDateDateTimePicker1);
            this.groupBoxDates.Location = new System.Drawing.Point(11, 298);
            this.groupBoxDates.Name = "groupBoxDates";
            this.groupBoxDates.Size = new System.Drawing.Size(349, 100);
            this.groupBoxDates.TabIndex = 28;
            this.groupBoxDates.TabStop = false;
            this.groupBoxDates.Text = "Modification Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Location = new System.Drawing.Point(11, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 106);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact information";
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDates);
            this.Controls.Add(this.Cordonnés_GroupBox);
            this.Name = "TraineeForm";
            this.Size = new System.Drawing.Size(368, 411);
            this.Load += new System.EventHandler(this.TraineeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
            this.Cordonnés_GroupBox.ResumeLayout(false);
            this.Cordonnés_GroupBox.PerformLayout();
            this.groupBoxDates.ResumeLayout(false);
            this.groupBoxDates.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource traineeBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.DateTimePicker updateDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker1;
        private System.Windows.Forms.GroupBox Cordonnés_GroupBox;
        private System.Windows.Forms.GroupBox groupBoxDates;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
