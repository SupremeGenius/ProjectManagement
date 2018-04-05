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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cordonnés_GroupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxDates = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.traineeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            updateDateLabel = new System.Windows.Forms.Label();
            createDateLabel1 = new System.Windows.Forms.Label();
            this.Cordonnés_GroupBox.SuspendLayout();
            this.groupBoxDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 141);
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
            phoneNumberLabel.Location = new System.Drawing.Point(6, 195);
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
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.traineeBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(105, 138);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(218, 20);
            this.emailTextBox.TabIndex = 4;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
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
            this.phoneNumberTextBox.Location = new System.Drawing.Point(105, 192);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(218, 20);
            this.phoneNumberTextBox.TabIndex = 12;
            // 
            // updateDateDateTimePicker
            // 
            this.updateDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.traineeBindingSource, "UpdateDate", true));
            this.updateDateDateTimePicker.Location = new System.Drawing.Point(110, 19);
            this.updateDateDateTimePicker.Name = "updateDateDateTimePicker";
            this.updateDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.updateDateDateTimePicker.TabIndex = 14;
            this.updateDateDateTimePicker.ValueChanged += new System.EventHandler(this.updateDateDateTimePicker_ValueChanged);
            // 
            // createDateDateTimePicker1
            // 
            this.createDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.traineeBindingSource, "group.CreateDate", true));
            this.createDateDateTimePicker1.Location = new System.Drawing.Point(110, 62);
            this.createDateDateTimePicker1.Name = "createDateDateTimePicker1";
            this.createDateDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.createDateDateTimePicker1.TabIndex = 18;
            this.createDateDateTimePicker1.ValueChanged += new System.EventHandler(this.createDateDateTimePicker1_ValueChanged);
            // 
            // Cordonnés_GroupBox
            // 
            this.Cordonnés_GroupBox.Controls.Add(firstNameLabel);
            this.Cordonnés_GroupBox.Controls.Add(this.firstNameTextBox);
            this.Cordonnés_GroupBox.Controls.Add(this.lastNameTextBox);
            this.Cordonnés_GroupBox.Controls.Add(lastNameLabel);
            this.Cordonnés_GroupBox.Controls.Add(this.emailTextBox);
            this.Cordonnés_GroupBox.Controls.Add(emailLabel);
            this.Cordonnés_GroupBox.Controls.Add(this.phoneNumberTextBox);
            this.Cordonnés_GroupBox.Controls.Add(phoneNumberLabel);
            this.Cordonnés_GroupBox.Location = new System.Drawing.Point(14, 17);
            this.Cordonnés_GroupBox.Name = "Cordonnés_GroupBox";
            this.Cordonnés_GroupBox.Size = new System.Drawing.Size(346, 280);
            this.Cordonnés_GroupBox.TabIndex = 27;
            this.Cordonnés_GroupBox.TabStop = false;
            this.Cordonnés_GroupBox.Text = "Cordinates";
            // 
            // groupBoxDates
            // 
            this.groupBoxDates.Controls.Add(this.updateDateDateTimePicker);
            this.groupBoxDates.Controls.Add(updateDateLabel);
            this.groupBoxDates.Controls.Add(createDateLabel1);
            this.groupBoxDates.Controls.Add(this.createDateDateTimePicker1);
            this.groupBoxDates.Location = new System.Drawing.Point(397, 197);
            this.groupBoxDates.Name = "groupBoxDates";
            this.groupBoxDates.Size = new System.Drawing.Size(326, 100);
            this.groupBoxDates.TabIndex = 28;
            this.groupBoxDates.TabStop = false;
            this.groupBoxDates.Text = "Dates";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(412, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(632, 38);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(397, 103);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 31;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(478, 103);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 32;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(559, 103);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 33;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(640, 103);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 34;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(525, 38);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 35;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // traineeBindingSource
            // 
            this.traineeBindingSource.DataSource = typeof(ProjectManagement.Entities.Trainee);
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxDates);
            this.Controls.Add(this.Cordonnés_GroupBox);
            this.Name = "TraineeForm";
            this.Size = new System.Drawing.Size(737, 309);
            this.Load += new System.EventHandler(this.TraineeForm_Load);
            this.Cordonnés_GroupBox.ResumeLayout(false);
            this.Cordonnés_GroupBox.PerformLayout();
            this.groupBoxDates.ResumeLayout(false);
            this.groupBoxDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonModify;
    }
}
