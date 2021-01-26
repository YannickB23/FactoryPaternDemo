
namespace FactoryPaternDemo
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtTurnOn = new System.Windows.Forms.TextBox();
            this.TxtTurnOff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(363, 168);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(121, 48);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(317, 22);
            this.TxtName.TabIndex = 1;
            // 
            // TxtTurnOn
            // 
            this.TxtTurnOn.Location = new System.Drawing.Point(121, 89);
            this.TxtTurnOn.Name = "TxtTurnOn";
            this.TxtTurnOn.ReadOnly = true;
            this.TxtTurnOn.Size = new System.Drawing.Size(317, 22);
            this.TxtTurnOn.TabIndex = 2;
            // 
            // TxtTurnOff
            // 
            this.TxtTurnOff.Location = new System.Drawing.Point(121, 131);
            this.TxtTurnOff.Name = "TxtTurnOff";
            this.TxtTurnOff.ReadOnly = true;
            this.TxtTurnOff.Size = new System.Drawing.Size(317, 22);
            this.TxtTurnOff.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtTurnOff);
            this.Controls.Add(this.TxtTurnOn);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtTurnOn;
        private System.Windows.Forms.TextBox TxtTurnOff;
    }
}

