namespace TrainDistanceCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKmHour = new TextBox();
            txtHours = new TextBox();
            lbxOutput = new ListBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 0;
            label1.Text = "Calcualte a Trains distance traveled.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 38);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "KM per Hour";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 66);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Hours Traveled";
            // 
            // txtKmHour
            // 
            txtKmHour.Location = new Point(150, 38);
            txtKmHour.Name = "txtKmHour";
            txtKmHour.Size = new Size(100, 23);
            txtKmHour.TabIndex = 3;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(150, 67);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 23);
            txtHours.TabIndex = 4;
            // 
            // lbxOutput
            // 
            lbxOutput.FormattingEnabled = true;
            lbxOutput.ItemHeight = 15;
            lbxOutput.Location = new Point(38, 96);
            lbxOutput.Name = "lbxOutput";
            lbxOutput.Size = new Size(212, 94);
            lbxOutput.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(38, 196);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(212, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 247);
            Controls.Add(btnCalculate);
            Controls.Add(lbxOutput);
            Controls.Add(txtHours);
            Controls.Add(txtKmHour);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculate distance traveled.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKmHour;
        private TextBox txtHours;
        private ListBox lbxOutput;
        private Button btnCalculate;
    }
}
