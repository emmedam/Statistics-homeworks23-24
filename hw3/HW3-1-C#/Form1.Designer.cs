namespace Penetration_C_
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
            components = new System.ComponentModel.Container();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(338, 14);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 27);
            numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 28);
            label1.TabIndex = 1;
            label1.Text = "Probability of success for the attack";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(959, 9);
            button1.Name = "button1";
            button1.Size = new Size(284, 68);
            button1.TabIndex = 2;
            button1.Text = "Generate attacks!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(173, 28);
            label2.TabIndex = 4;
            label2.Text = "Number of attacks";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(191, 54);
            numericUpDown2.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 27);
            numericUpDown2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(525, 28);
            label3.Name = "label3";
            label3.Size = new Size(252, 28);
            label3.TabIndex = 7;
            label3.Text = "Number of servers attacked";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(783, 33);
            numericUpDown3.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 27);
            numericUpDown3.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Location = new Point(34, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(102, 36);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // panel2
            // 
            panel2.Location = new Point(34, 215);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 9;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // panel3
            // 
            panel3.Location = new Point(34, 358);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 10;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;
            // 
            // panel4
            // 
            panel4.Location = new Point(34, 512);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 11;
            panel4.MouseDown += panel4_MouseDown;
            panel4.MouseMove += panel4_MouseMove;
            panel4.MouseUp += panel4_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 670);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(numericUpDown3);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "HW3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private NumericUpDown numericUpDown3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}