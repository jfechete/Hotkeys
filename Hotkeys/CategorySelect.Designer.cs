
namespace Hotkeys
{
    partial class CategorySelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorySelect));
            this.lblSelectHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.slctCategory = new System.Windows.Forms.ComboBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.slctProgram = new System.Windows.Forms.ComboBox();
            this.lblHotkeysHeading = new System.Windows.Forms.Label();
            this.listHotkeys = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectHeading
            // 
            this.lblSelectHeading.AutoSize = true;
            this.lblSelectHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectHeading.Location = new System.Drawing.Point(12, 9);
            this.lblSelectHeading.Name = "lblSelectHeading";
            this.lblSelectHeading.Size = new System.Drawing.Size(85, 25);
            this.lblSelectHeading.TabIndex = 6;
            this.lblSelectHeading.Text = "Select:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.slctCategory, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProgram, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.slctProgram, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 24);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // slctCategory
            // 
            this.slctCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slctCategory.FormattingEnabled = true;
            this.slctCategory.Location = new System.Drawing.Point(254, 3);
            this.slctCategory.Name = "slctCategory";
            this.slctCategory.Size = new System.Drawing.Size(14, 21);
            this.slctCategory.TabIndex = 5;
            this.slctCategory.SelectedIndexChanged += new System.EventHandler(this.slctCategory_SelectedIndexChanged);
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(3, 0);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(78, 18);
            this.lblProgram.TabIndex = 1;
            this.lblProgram.Text = "Program:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(167, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 18);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            // 
            // slctProgram
            // 
            this.slctProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.slctProgram.FormattingEnabled = true;
            this.slctProgram.Location = new System.Drawing.Point(87, 3);
            this.slctProgram.Name = "slctProgram";
            this.slctProgram.Size = new System.Drawing.Size(74, 21);
            this.slctProgram.TabIndex = 4;
            this.slctProgram.SelectedIndexChanged += new System.EventHandler(this.slctProgram_SelectedIndexChanged);
            // 
            // lblHotkeysHeading
            // 
            this.lblHotkeysHeading.AutoSize = true;
            this.lblHotkeysHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeysHeading.Location = new System.Drawing.Point(12, 65);
            this.lblHotkeysHeading.Name = "lblHotkeysHeading";
            this.lblHotkeysHeading.Size = new System.Drawing.Size(104, 25);
            this.lblHotkeysHeading.TabIndex = 8;
            this.lblHotkeysHeading.Text = "Hotkeys:";
            // 
            // listHotkeys
            // 
            this.listHotkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHotkeys.FormattingEnabled = true;
            this.listHotkeys.Location = new System.Drawing.Point(34, 93);
            this.listHotkeys.Name = "listHotkeys";
            this.listHotkeys.Size = new System.Drawing.Size(452, 199);
            this.listHotkeys.TabIndex = 9;
            this.listHotkeys.SelectedIndexChanged += new System.EventHandler(this.listTips_SelectedIndexChanged);
            // 
            // CategorySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 311);
            this.Controls.Add(this.listHotkeys);
            this.Controls.Add(this.lblHotkeysHeading);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSelectHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategorySelect";
            this.Text = "Category Select";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectHeading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox slctCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox slctProgram;
        private System.Windows.Forms.Label lblHotkeysHeading;
        private System.Windows.Forms.ListBox listHotkeys;
    }
}