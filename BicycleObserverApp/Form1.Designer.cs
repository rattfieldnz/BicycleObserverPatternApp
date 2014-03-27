namespace BicycleObserverApp
{
    partial class Form1
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
            this.changeSpeedBTN = new System.Windows.Forms.Button();
            this.speedTB = new System.Windows.Forms.TextBox();
            this.rpmGroupBox = new System.Windows.Forms.GroupBox();
            this.caloriesGroupBox = new System.Windows.Forms.GroupBox();
            this.kmPerHourGroupBox = new System.Windows.Forms.GroupBox();
            this.rpmDisplayLBL = new System.Windows.Forms.Label();
            this.caloriesPerHourLBL = new System.Windows.Forms.Label();
            this.kphLBL = new System.Windows.Forms.Label();
            this.rpmGroupBox.SuspendLayout();
            this.caloriesGroupBox.SuspendLayout();
            this.kmPerHourGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeSpeedBTN
            // 
            this.changeSpeedBTN.Font = new System.Drawing.Font("Magneto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSpeedBTN.Location = new System.Drawing.Point(13, 13);
            this.changeSpeedBTN.Name = "changeSpeedBTN";
            this.changeSpeedBTN.Size = new System.Drawing.Size(114, 61);
            this.changeSpeedBTN.TabIndex = 0;
            this.changeSpeedBTN.Text = "Change Speed";
            this.changeSpeedBTN.UseVisualStyleBackColor = true;
            this.changeSpeedBTN.Click += new System.EventHandler(this.changeSpeedBTN_Click);
            // 
            // speedTB
            // 
            this.speedTB.Location = new System.Drawing.Point(144, 34);
            this.speedTB.Name = "speedTB";
            this.speedTB.Size = new System.Drawing.Size(119, 20);
            this.speedTB.TabIndex = 1;
            // 
            // rpmGroupBox
            // 
            this.rpmGroupBox.Controls.Add(this.rpmDisplayLBL);
            this.rpmGroupBox.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmGroupBox.Location = new System.Drawing.Point(13, 100);
            this.rpmGroupBox.Name = "rpmGroupBox";
            this.rpmGroupBox.Size = new System.Drawing.Size(250, 125);
            this.rpmGroupBox.TabIndex = 2;
            this.rpmGroupBox.TabStop = false;
            this.rpmGroupBox.Text = "RPM";
            // 
            // caloriesGroupBox
            // 
            this.caloriesGroupBox.Controls.Add(this.caloriesPerHourLBL);
            this.caloriesGroupBox.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesGroupBox.Location = new System.Drawing.Point(13, 243);
            this.caloriesGroupBox.Name = "caloriesGroupBox";
            this.caloriesGroupBox.Size = new System.Drawing.Size(250, 125);
            this.caloriesGroupBox.TabIndex = 3;
            this.caloriesGroupBox.TabStop = false;
            this.caloriesGroupBox.Text = "Calories Per Hour";
            // 
            // kmPerHourGroupBox
            // 
            this.kmPerHourGroupBox.Controls.Add(this.kphLBL);
            this.kmPerHourGroupBox.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmPerHourGroupBox.Location = new System.Drawing.Point(13, 375);
            this.kmPerHourGroupBox.Name = "kmPerHourGroupBox";
            this.kmPerHourGroupBox.Size = new System.Drawing.Size(250, 125);
            this.kmPerHourGroupBox.TabIndex = 4;
            this.kmPerHourGroupBox.TabStop = false;
            this.kmPerHourGroupBox.Text = "KM Per Hour";
            // 
            // rpmDisplayLBL
            // 
            this.rpmDisplayLBL.AutoSize = true;
            this.rpmDisplayLBL.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmDisplayLBL.Location = new System.Drawing.Point(3, 49);
            this.rpmDisplayLBL.Name = "rpmDisplayLBL";
            this.rpmDisplayLBL.Size = new System.Drawing.Size(43, 41);
            this.rpmDisplayLBL.TabIndex = 0;
            this.rpmDisplayLBL.Text = "0";
            // 
            // caloriesPerHourLBL
            // 
            this.caloriesPerHourLBL.AutoSize = true;
            this.caloriesPerHourLBL.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesPerHourLBL.Location = new System.Drawing.Point(3, 47);
            this.caloriesPerHourLBL.Name = "caloriesPerHourLBL";
            this.caloriesPerHourLBL.Size = new System.Drawing.Size(43, 41);
            this.caloriesPerHourLBL.TabIndex = 0;
            this.caloriesPerHourLBL.Text = "0";
            // 
            // kphLBL
            // 
            this.kphLBL.AutoSize = true;
            this.kphLBL.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kphLBL.Location = new System.Drawing.Point(3, 53);
            this.kphLBL.Name = "kphLBL";
            this.kphLBL.Size = new System.Drawing.Size(78, 41);
            this.kphLBL.TabIndex = 0;
            this.kphLBL.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 515);
            this.Controls.Add(this.kmPerHourGroupBox);
            this.Controls.Add(this.caloriesGroupBox);
            this.Controls.Add(this.rpmGroupBox);
            this.Controls.Add(this.speedTB);
            this.Controls.Add(this.changeSpeedBTN);
            this.Name = "Form1";
            this.Text = "BicycleApp";
            this.rpmGroupBox.ResumeLayout(false);
            this.rpmGroupBox.PerformLayout();
            this.caloriesGroupBox.ResumeLayout(false);
            this.caloriesGroupBox.PerformLayout();
            this.kmPerHourGroupBox.ResumeLayout(false);
            this.kmPerHourGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeSpeedBTN;
        private System.Windows.Forms.TextBox speedTB;
        private System.Windows.Forms.GroupBox rpmGroupBox;
        private System.Windows.Forms.GroupBox caloriesGroupBox;
        private System.Windows.Forms.GroupBox kmPerHourGroupBox;
        private System.Windows.Forms.Label rpmDisplayLBL;
        private System.Windows.Forms.Label caloriesPerHourLBL;
        private System.Windows.Forms.Label kphLBL;
    }
}

