﻿
namespace Hotkeys
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
            this.lblProgram = new System.Windows.Forms.Label();
            this.dispProgram = new System.Windows.Forms.Label();
            this.dispCategory = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tblLabels = new System.Windows.Forms.TableLayoutPanel();
            this.dispHotkey = new System.Windows.Forms.Label();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.lblHotkeyHeading = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dispDescription = new System.Windows.Forms.Label();
            this.tblLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(3, 0);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(78, 18);
            this.lblProgram.TabIndex = 0;
            this.lblProgram.Text = "Program:";
            // 
            // dispProgram
            // 
            this.dispProgram.AutoSize = true;
            this.dispProgram.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dispProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispProgram.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dispProgram.Location = new System.Drawing.Point(87, 0);
            this.dispProgram.Name = "dispProgram";
            this.dispProgram.Size = new System.Drawing.Size(98, 20);
            this.dispProgram.TabIndex = 1;
            this.dispProgram.Text = "programHere";
            // 
            // dispCategory
            // 
            this.dispCategory.AutoSize = true;
            this.dispCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dispCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dispCategory.Location = new System.Drawing.Point(278, 0);
            this.dispCategory.Name = "dispCategory";
            this.dispCategory.Size = new System.Drawing.Size(99, 20);
            this.dispCategory.TabIndex = 3;
            this.dispCategory.Text = "categoryHere";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(191, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 18);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // tblLabels
            // 
            this.tblLabels.AutoSize = true;
            this.tblLabels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLabels.ColumnCount = 6;
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLabels.Controls.Add(this.dispHotkey, 5, 0);
            this.tblLabels.Controls.Add(this.lblProgram, 0, 0);
            this.tblLabels.Controls.Add(this.lblHotkey, 4, 0);
            this.tblLabels.Controls.Add(this.dispProgram, 1, 0);
            this.tblLabels.Controls.Add(this.lblCategory, 2, 0);
            this.tblLabels.Controls.Add(this.dispCategory, 3, 0);
            this.tblLabels.Location = new System.Drawing.Point(34, 37);
            this.tblLabels.Name = "tblLabels";
            this.tblLabels.RowCount = 1;
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLabels.Size = new System.Drawing.Size(544, 20);
            this.tblLabels.TabIndex = 4;
            // 
            // dispHotkey
            // 
            this.dispHotkey.AutoSize = true;
            this.dispHotkey.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dispHotkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispHotkey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dispHotkey.Location = new System.Drawing.Point(455, 0);
            this.dispHotkey.Name = "dispHotkey";
            this.dispHotkey.Size = new System.Drawing.Size(86, 20);
            this.dispHotkey.TabIndex = 6;
            this.dispHotkey.Text = "hotkeyHere";
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkey.Location = new System.Drawing.Point(383, 0);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(66, 18);
            this.lblHotkey.TabIndex = 5;
            this.lblHotkey.Text = "Hotkey:";
            // 
            // lblHotkeyHeading
            // 
            this.lblHotkeyHeading.AutoSize = true;
            this.lblHotkeyHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeyHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHotkeyHeading.Name = "lblHotkeyHeading";
            this.lblHotkeyHeading.Size = new System.Drawing.Size(92, 25);
            this.lblHotkeyHeading.TabIndex = 5;
            this.lblHotkeyHeading.Text = "Hotkey:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(37, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 18);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // dispDescription
            // 
            this.dispDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dispDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dispDescription.Location = new System.Drawing.Point(40, 78);
            this.dispDescription.Name = "dispDescription";
            this.dispDescription.Size = new System.Drawing.Size(632, 100);
            this.dispDescription.TabIndex = 8;
            this.dispDescription.Text = "descriptionHere";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dispDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblHotkeyHeading);
            this.Controls.Add(this.tblLabels);
            this.Name = "Form1";
            this.Text = "Hotkeys";
            this.tblLabels.ResumeLayout(false);
            this.tblLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label dispProgram;
        private System.Windows.Forms.Label dispCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TableLayoutPanel tblLabels;
        private System.Windows.Forms.Label dispHotkey;
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.Label lblHotkeyHeading;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label dispDescription;
    }
}

