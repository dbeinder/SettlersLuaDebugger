﻿namespace LuaDebuggerStarter
{
    partial class frmLDStarter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLDStarter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInstS5 = new System.Windows.Forms.Label();
            this.btnS5AO2 = new System.Windows.Forms.Button();
            this.btnS5AO1 = new System.Windows.Forms.Button();
            this.btnS5Main = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnS6DevM = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInstS6 = new System.Windows.Forms.Label();
            this.btnS6AO1 = new System.Windows.Forms.Button();
            this.btnS6Main = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Settlers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heritage of Kings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblInstS5);
            this.panel1.Controls.Add(this.btnS5AO2);
            this.panel1.Controls.Add(this.btnS5AO1);
            this.panel1.Controls.Add(this.btnS5Main);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 77);
            this.panel1.TabIndex = 2;
            // 
            // lblInstS5
            // 
            this.lblInstS5.AutoSize = true;
            this.lblInstS5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInstS5.Location = new System.Drawing.Point(166, 32);
            this.lblInstS5.Name = "lblInstS5";
            this.lblInstS5.Size = new System.Drawing.Size(87, 13);
            this.lblInstS5.TabIndex = 5;
            this.lblInstS5.Text = "Installation found";
            this.lblInstS5.Click += new System.EventHandler(this.lblInstS5_Click);
            // 
            // btnS5AO2
            // 
            this.btnS5AO2.Enabled = false;
            this.btnS5AO2.Location = new System.Drawing.Point(293, 51);
            this.btnS5AO2.Name = "btnS5AO2";
            this.btnS5AO2.Size = new System.Drawing.Size(89, 23);
            this.btnS5AO2.TabIndex = 4;
            this.btnS5AO2.Text = "Add-On 2";
            this.btnS5AO2.UseVisualStyleBackColor = true;
            // 
            // btnS5AO1
            // 
            this.btnS5AO1.Enabled = false;
            this.btnS5AO1.Location = new System.Drawing.Point(293, 27);
            this.btnS5AO1.Name = "btnS5AO1";
            this.btnS5AO1.Size = new System.Drawing.Size(89, 23);
            this.btnS5AO1.TabIndex = 3;
            this.btnS5AO1.Text = "Add-On 1";
            this.btnS5AO1.UseVisualStyleBackColor = true;
            // 
            // btnS5Main
            // 
            this.btnS5Main.Enabled = false;
            this.btnS5Main.Location = new System.Drawing.Point(293, 3);
            this.btnS5Main.Name = "btnS5Main";
            this.btnS5Main.Size = new System.Drawing.Size(89, 23);
            this.btnS5Main.TabIndex = 2;
            this.btnS5Main.Text = "Original Game";
            this.btnS5Main.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnS6DevM);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblInstS6);
            this.panel2.Controls.Add(this.btnS6AO1);
            this.panel2.Controls.Add(this.btnS6Main);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 77);
            this.panel2.TabIndex = 5;
            // 
            // btnS6DevM
            // 
            this.btnS6DevM.Location = new System.Drawing.Point(169, 14);
            this.btnS6DevM.Name = "btnS6DevM";
            this.btnS6DevM.Size = new System.Drawing.Size(213, 47);
            this.btnS6DevM.TabIndex = 8;
            this.btnS6DevM.Text = "Set Development Key";
            this.btnS6DevM.UseVisualStyleBackColor = true;
            this.btnS6DevM.Visible = false;
            this.btnS6DevM.Click += new System.EventHandler(this.btnS6DevM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(302, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "experimental ;)";
            // 
            // lblInstS6
            // 
            this.lblInstS6.AutoSize = true;
            this.lblInstS6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInstS6.Location = new System.Drawing.Point(166, 32);
            this.lblInstS6.Name = "lblInstS6";
            this.lblInstS6.Size = new System.Drawing.Size(87, 13);
            this.lblInstS6.TabIndex = 6;
            this.lblInstS6.Text = "Installation found";
            this.lblInstS6.Click += new System.EventHandler(this.lblS6Inst_Click);
            // 
            // btnS6AO1
            // 
            this.btnS6AO1.Enabled = false;
            this.btnS6AO1.Location = new System.Drawing.Point(293, 38);
            this.btnS6AO1.Name = "btnS6AO1";
            this.btnS6AO1.Size = new System.Drawing.Size(89, 23);
            this.btnS6AO1.TabIndex = 3;
            this.btnS6AO1.Text = "Add-On 1";
            this.btnS6AO1.UseVisualStyleBackColor = true;
            // 
            // btnS6Main
            // 
            this.btnS6Main.Enabled = false;
            this.btnS6Main.Location = new System.Drawing.Point(293, 14);
            this.btnS6Main.Name = "btnS6Main";
            this.btnS6Main.Size = new System.Drawing.Size(89, 23);
            this.btnS6Main.TabIndex = 2;
            this.btnS6Main.Text = "Original Game";
            this.btnS6Main.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "The Settlers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rise of an Empire";
            // 
            // frmLDStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 182);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLDStarter";
            this.Text = "Lua Debugger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnS5AO2;
        private System.Windows.Forms.Button btnS5AO1;
        private System.Windows.Forms.Button btnS5Main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnS6AO1;
        private System.Windows.Forms.Button btnS6Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInstS5;
        private System.Windows.Forms.Label lblInstS6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnS6DevM;
    }
}

