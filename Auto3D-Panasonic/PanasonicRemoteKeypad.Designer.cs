﻿
namespace MediaPortal.ProcessPlugins.Auto3D.Devices
{
    partial class PanasonicRemoteKeypad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.buttonAdjust = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.buttonDown = new System.Windows.Forms.Button();
      this.buttonUp = new System.Windows.Forms.Button();
      this.buttonOK = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.buttonRight = new System.Windows.Forms.Button();
      this.buttonLeft = new System.Windows.Forms.Button();
      this.buttonRED = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonAdjust
      // 
      this.buttonAdjust.BackColor = System.Drawing.Color.PowderBlue;
      this.buttonAdjust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonAdjust.Location = new System.Drawing.Point(176, 45);
      this.buttonAdjust.Name = "buttonAdjust";
      this.buttonAdjust.Size = new System.Drawing.Size(60, 40);
      this.buttonAdjust.TabIndex = 67;
      this.buttonAdjust.Tag = "Mode3D";
      this.buttonAdjust.Text = "3D";
      this.buttonAdjust.UseVisualStyleBackColor = false;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panel1.Controls.Add(this.buttonDown);
      this.panel1.Controls.Add(this.buttonUp);
      this.panel1.Controls.Add(this.buttonOK);
      this.panel1.Location = new System.Drawing.Point(89, 31);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(80, 194);
      this.panel1.TabIndex = 70;
      // 
      // buttonDown
      // 
      this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDown.Location = new System.Drawing.Point(10, 138);
      this.buttonDown.Name = "buttonDown";
      this.buttonDown.Size = new System.Drawing.Size(60, 40);
      this.buttonDown.TabIndex = 3;
      this.buttonDown.Tag = "CursorDown";
      this.buttonDown.Text = "Down";
      this.buttonDown.UseVisualStyleBackColor = true;
      // 
      // buttonUp
      // 
      this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonUp.Location = new System.Drawing.Point(10, 14);
      this.buttonUp.Name = "buttonUp";
      this.buttonUp.Size = new System.Drawing.Size(60, 40);
      this.buttonUp.TabIndex = 17;
      this.buttonUp.Tag = "CursorUp";
      this.buttonUp.Text = "Up";
      this.buttonUp.UseVisualStyleBackColor = true;
      // 
      // buttonOK
      // 
      this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonOK.Location = new System.Drawing.Point(10, 76);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(60, 40);
      this.buttonOK.TabIndex = 18;
      this.buttonOK.Tag = "Confirm";
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panel2.Controls.Add(this.buttonRight);
      this.panel2.Controls.Add(this.buttonLeft);
      this.panel2.Location = new System.Drawing.Point(11, 96);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(235, 64);
      this.panel2.TabIndex = 71;
      // 
      // buttonRight
      // 
      this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonRight.Location = new System.Drawing.Point(165, 11);
      this.buttonRight.Name = "buttonRight";
      this.buttonRight.Size = new System.Drawing.Size(60, 40);
      this.buttonRight.TabIndex = 20;
      this.buttonRight.Tag = "CursorRight";
      this.buttonRight.Text = "Right";
      this.buttonRight.UseVisualStyleBackColor = true;
      // 
      // buttonLeft
      // 
      this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonLeft.Location = new System.Drawing.Point(10, 11);
      this.buttonLeft.Name = "buttonLeft";
      this.buttonLeft.Size = new System.Drawing.Size(60, 40);
      this.buttonLeft.TabIndex = 19;
      this.buttonLeft.Tag = "CursorLeft";
      this.buttonLeft.Text = "Left";
      this.buttonLeft.UseVisualStyleBackColor = true;
      // 
      // buttonRED
      // 
      this.buttonRED.BackColor = System.Drawing.Color.Firebrick;
      this.buttonRED.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonRED.Location = new System.Drawing.Point(176, 169);
      this.buttonRED.Name = "buttonRED";
      this.buttonRED.Size = new System.Drawing.Size(60, 40);
      this.buttonRED.TabIndex = 72;
      this.buttonRED.Tag = "Red";
      this.buttonRED.UseVisualStyleBackColor = false;
      // 
      // PanasonicRemoteKeypad
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.buttonRED);
      this.Controls.Add(this.buttonAdjust);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel2);
      this.Name = "PanasonicRemoteKeypad";
      this.Size = new System.Drawing.Size(256, 256);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdjust;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRED;
    }
}
