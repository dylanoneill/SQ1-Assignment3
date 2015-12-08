namespace TriangleForm
{
    partial class TriangleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SideATextbox = new System.Windows.Forms.TextBox();
            this.SideBTextbox = new System.Windows.Forms.TextBox();
            this.SideCTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AngleBTextbox = new System.Windows.Forms.TextBox();
            this.AngleCTextbox = new System.Windows.Forms.TextBox();
            this.AngleATextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ThirdAngleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side A: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Side B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Side C:";
            // 
            // SideATextbox
            // 
            this.SideATextbox.Location = new System.Drawing.Point(63, 6);
            this.SideATextbox.Name = "SideATextbox";
            this.SideATextbox.Size = new System.Drawing.Size(26, 20);
            this.SideATextbox.TabIndex = 3;
            this.SideATextbox.Text = "0";
            // 
            // SideBTextbox
            // 
            this.SideBTextbox.Location = new System.Drawing.Point(63, 39);
            this.SideBTextbox.Name = "SideBTextbox";
            this.SideBTextbox.Size = new System.Drawing.Size(26, 20);
            this.SideBTextbox.TabIndex = 4;
            this.SideBTextbox.Text = "0";
            // 
            // SideCTextbox
            // 
            this.SideCTextbox.Location = new System.Drawing.Point(63, 70);
            this.SideCTextbox.Name = "SideCTextbox";
            this.SideCTextbox.Size = new System.Drawing.Size(26, 20);
            this.SideCTextbox.TabIndex = 5;
            this.SideCTextbox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Angle A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Angle B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Angle C:";
            // 
            // AngleBTextbox
            // 
            this.AngleBTextbox.Location = new System.Drawing.Point(169, 39);
            this.AngleBTextbox.Name = "AngleBTextbox";
            this.AngleBTextbox.Size = new System.Drawing.Size(26, 20);
            this.AngleBTextbox.TabIndex = 9;
            this.AngleBTextbox.Text = "0";
            // 
            // AngleCTextbox
            // 
            this.AngleCTextbox.Location = new System.Drawing.Point(169, 70);
            this.AngleCTextbox.Name = "AngleCTextbox";
            this.AngleCTextbox.Size = new System.Drawing.Size(26, 20);
            this.AngleCTextbox.TabIndex = 10;
            this.AngleCTextbox.Text = "0";
            // 
            // AngleATextbox
            // 
            this.AngleATextbox.Location = new System.Drawing.Point(169, 6);
            this.AngleATextbox.Name = "AngleATextbox";
            this.AngleATextbox.Size = new System.Drawing.Size(26, 20);
            this.AngleATextbox.TabIndex = 11;
            this.AngleATextbox.Text = "0";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 106);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(129, 23);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Calculate Hypotenuse";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ThirdAngleButton
            // 
            this.ThirdAngleButton.Location = new System.Drawing.Point(12, 135);
            this.ThirdAngleButton.Name = "ThirdAngleButton";
            this.ThirdAngleButton.Size = new System.Drawing.Size(129, 23);
            this.ThirdAngleButton.TabIndex = 13;
            this.ThirdAngleButton.Text = "Calculate Third Angle";
            this.ThirdAngleButton.UseVisualStyleBackColor = true;
            this.ThirdAngleButton.Click += new System.EventHandler(this.ThirdAngleButton_Click);
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 171);
            this.Controls.Add(this.ThirdAngleButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AngleATextbox);
            this.Controls.Add(this.AngleCTextbox);
            this.Controls.Add(this.AngleBTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SideCTextbox);
            this.Controls.Add(this.SideBTextbox);
            this.Controls.Add(this.SideATextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TriangleForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SideATextbox;
        private System.Windows.Forms.TextBox SideBTextbox;
        private System.Windows.Forms.TextBox SideCTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AngleBTextbox;
        private System.Windows.Forms.TextBox AngleCTextbox;
        private System.Windows.Forms.TextBox AngleATextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ThirdAngleButton;
    }
}

