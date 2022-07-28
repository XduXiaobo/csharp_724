namespace csharp_724
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_motorselect = new System.Windows.Forms.ComboBox();
            this.motor_label = new System.Windows.Forms.Label();
            this.debug_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_motorselect
            // 
            this.comboBox_motorselect.FormattingEnabled = true;
            this.comboBox_motorselect.Items.AddRange(new object[] {
            "Phidget",
            "Zaber"});
            this.comboBox_motorselect.Location = new System.Drawing.Point(195, 75);
            this.comboBox_motorselect.Name = "comboBox_motorselect";
            this.comboBox_motorselect.Size = new System.Drawing.Size(121, 26);
            this.comboBox_motorselect.TabIndex = 1;
            this.comboBox_motorselect.SelectedIndexChanged += new System.EventHandler(this.comboBox_motorselect_SelectedIndexChanged);
            // 
            // motor_label
            // 
            this.motor_label.AutoSize = true;
            this.motor_label.Location = new System.Drawing.Point(192, 42);
            this.motor_label.Name = "motor_label";
            this.motor_label.Size = new System.Drawing.Size(116, 18);
            this.motor_label.TabIndex = 2;
            this.motor_label.Text = "Motor Select";
            // 
            // debug_richTextBox
            // 
            this.debug_richTextBox.Location = new System.Drawing.Point(497, 311);
            this.debug_richTextBox.Name = "debug_richTextBox";
            this.debug_richTextBox.Size = new System.Drawing.Size(208, 96);
            this.debug_richTextBox.TabIndex = 3;
            this.debug_richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debug_richTextBox);
            this.Controls.Add(this.motor_label);
            this.Controls.Add(this.comboBox_motorselect);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_motorselect;
        private System.Windows.Forms.Label motor_label;
        private System.Windows.Forms.RichTextBox debug_richTextBox;
    }
}

