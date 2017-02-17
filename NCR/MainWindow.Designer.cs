namespace NCR
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDuplicatesAll = new System.Windows.Forms.TextBox();
            this.textBoxNonDuplicatesAll = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxTimesDuplicated = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTheMostB = new System.Windows.Forms.TextBox();
            this.textBoxTheMostA = new System.Windows.Forms.TextBox();
            this.textBoxHowManyTimesABduplicated = new System.Windows.Forms.TextBox();
            this.textBoxTrueOrFalse = new System.Windows.Forms.TextBox();
            this.DuplicateTestBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSetB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSetA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(880, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "made by David Jaroš 17-02-2017";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 47;
            this.label11.Text = "A:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Human readable report of invalid inputs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "The MOST FREQUENT DUPLICATE GROUP seen so far";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "How many TIMES has A and B been duplicated:";
            // 
            // textBoxDuplicatesAll
            // 
            this.textBoxDuplicatesAll.Location = new System.Drawing.Point(458, 190);
            this.textBoxDuplicatesAll.Name = "textBoxDuplicatesAll";
            this.textBoxDuplicatesAll.Size = new System.Drawing.Size(132, 22);
            this.textBoxDuplicatesAll.TabIndex = 43;
            // 
            // textBoxNonDuplicatesAll
            // 
            this.textBoxNonDuplicatesAll.Location = new System.Drawing.Point(458, 234);
            this.textBoxNonDuplicatesAll.Name = "textBoxNonDuplicatesAll";
            this.textBoxNonDuplicatesAll.Size = new System.Drawing.Size(132, 22);
            this.textBoxNonDuplicatesAll.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "The number of ALL NON-DUPLICATES seen from the beginning:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "The number of ALL DUPLICATES seen from the beginning:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(434, 324);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(665, 102);
            this.textBoxOutput.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1000, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "times:";
            // 
            // textBoxMaxTimesDuplicated
            // 
            this.textBoxMaxTimesDuplicated.Location = new System.Drawing.Point(1050, 275);
            this.textBoxMaxTimesDuplicated.Name = "textBoxMaxTimesDuplicated";
            this.textBoxMaxTimesDuplicated.Size = new System.Drawing.Size(49, 22);
            this.textBoxMaxTimesDuplicated.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "A:";
            // 
            // textBoxTheMostB
            // 
            this.textBoxTheMostB.Location = new System.Drawing.Point(748, 275);
            this.textBoxTheMostB.Name = "textBoxTheMostB";
            this.textBoxTheMostB.Size = new System.Drawing.Size(246, 22);
            this.textBoxTheMostB.TabIndex = 34;
            // 
            // textBoxTheMostA
            // 
            this.textBoxTheMostA.Location = new System.Drawing.Point(458, 275);
            this.textBoxTheMostA.Name = "textBoxTheMostA";
            this.textBoxTheMostA.Size = new System.Drawing.Size(257, 22);
            this.textBoxTheMostA.TabIndex = 33;
            // 
            // textBoxHowManyTimesABduplicated
            // 
            this.textBoxHowManyTimesABduplicated.Location = new System.Drawing.Point(458, 150);
            this.textBoxHowManyTimesABduplicated.Name = "textBoxHowManyTimesABduplicated";
            this.textBoxHowManyTimesABduplicated.Size = new System.Drawing.Size(132, 22);
            this.textBoxHowManyTimesABduplicated.TabIndex = 32;
            // 
            // textBoxTrueOrFalse
            // 
            this.textBoxTrueOrFalse.Location = new System.Drawing.Point(458, 106);
            this.textBoxTrueOrFalse.Name = "textBoxTrueOrFalse";
            this.textBoxTrueOrFalse.Size = new System.Drawing.Size(132, 22);
            this.textBoxTrueOrFalse.TabIndex = 31;
            // 
            // DuplicateTestBtn
            // 
            this.DuplicateTestBtn.Location = new System.Drawing.Point(15, 105);
            this.DuplicateTestBtn.Name = "DuplicateTestBtn";
            this.DuplicateTestBtn.Size = new System.Drawing.Size(413, 23);
            this.DuplicateTestBtn.TabIndex = 30;
            this.DuplicateTestBtn.Text = "Is A set a duplicate of B set ?";
            this.DuplicateTestBtn.UseVisualStyleBackColor = true;
            this.DuplicateTestBtn.Click += new System.EventHandler(this.DuplicateTestBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "B set of integer values, comma separated";
            // 
            // textBoxSetB
            // 
            this.textBoxSetB.Location = new System.Drawing.Point(15, 58);
            this.textBoxSetB.Name = "textBoxSetB";
            this.textBoxSetB.Size = new System.Drawing.Size(413, 22);
            this.textBoxSetB.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "A set of integer values, comma separated";
            // 
            // textBoxSetA
            // 
            this.textBoxSetA.Location = new System.Drawing.Point(15, 19);
            this.textBoxSetA.Name = "textBoxSetA";
            this.textBoxSetA.Size = new System.Drawing.Size(413, 22);
            this.textBoxSetA.TabIndex = 26;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 494);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDuplicatesAll);
            this.Controls.Add(this.textBoxNonDuplicatesAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaxTimesDuplicated);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTheMostB);
            this.Controls.Add(this.textBoxTheMostA);
            this.Controls.Add(this.textBoxHowManyTimesABduplicated);
            this.Controls.Add(this.textBoxTrueOrFalse);
            this.Controls.Add(this.DuplicateTestBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSetB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSetA);
            this.Name = "MainWindow";
            this.Text = "NCR Duplicate Test Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDuplicatesAll;
        private System.Windows.Forms.TextBox textBoxNonDuplicatesAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxTimesDuplicated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTheMostB;
        private System.Windows.Forms.TextBox textBoxTheMostA;
        private System.Windows.Forms.TextBox textBoxHowManyTimesABduplicated;
        private System.Windows.Forms.TextBox textBoxTrueOrFalse;
        private System.Windows.Forms.Button DuplicateTestBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSetB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSetA;
    }
}

