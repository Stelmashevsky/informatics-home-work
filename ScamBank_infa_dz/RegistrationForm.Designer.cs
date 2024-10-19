namespace ScamBank_infa_dz
{
    partial class RegistrationForm
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
            this.SecondName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PassportSeries = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PassportNumber = new System.Windows.Forms.TextBox();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DatabaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(115, 53);
            this.SecondName.Multiline = true;
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(185, 24);
            this.SecondName.TabIndex = 0;
            this.SecondName.TextChanged += new System.EventHandler(this.SecondName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(115, 115);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(185, 24);
            this.LastName.TabIndex = 2;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(115, 84);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(185, 24);
            this.FirstName.TabIndex = 1;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество:";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(115, 146);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(185, 24);
            this.Phone.TabIndex = 3;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            this.Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тел. :";
            // 
            // PassportSeries
            // 
            this.PassportSeries.Location = new System.Drawing.Point(115, 177);
            this.PassportSeries.Multiline = true;
            this.PassportSeries.Name = "PassportSeries";
            this.PassportSeries.Size = new System.Drawing.Size(185, 24);
            this.PassportSeries.TabIndex = 4;
            this.PassportSeries.TextChanged += new System.EventHandler(this.PassportSeries_TextChanged);
            this.PassportSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassportSeries_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Серия паспорта :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер паспорта :";
            // 
            // PassportNumber
            // 
            this.PassportNumber.Location = new System.Drawing.Point(115, 208);
            this.PassportNumber.Multiline = true;
            this.PassportNumber.Name = "PassportNumber";
            this.PassportNumber.Size = new System.Drawing.Size(185, 24);
            this.PassportNumber.TabIndex = 9;
            this.PassportNumber.TextChanged += new System.EventHandler(this.PassportNumber_TextChanged);
            this.PassportNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassportNumber_KeyPress);
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(115, 239);
            this.CardNumber.Multiline = true;
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(185, 24);
            this.CardNumber.TabIndex = 11;
            this.CardNumber.TextChanged += new System.EventHandler(this.CardNumber_TextChanged);
            this.CardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер карты :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(115, 287);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(185, 47);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.Location = new System.Drawing.Point(115, 351);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(185, 23);
            this.DatabaseButton.TabIndex = 14;
            this.DatabaseButton.Text = "Просмотреть БД";
            this.DatabaseButton.UseVisualStyleBackColor = true;
            this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click_1);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatabaseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PassportNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassportSeries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.SecondName);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassportSeries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PassportNumber;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DatabaseButton;
    }
}