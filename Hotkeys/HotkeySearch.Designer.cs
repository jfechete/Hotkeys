
namespace Hotkeys
{
    partial class HotkeySearch
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
            this.lblKeysHeading = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.dispKeys = new System.Windows.Forms.Label();
            this.btnResetKeys = new System.Windows.Forms.Button();
            this.lblHotkeysHeading = new System.Windows.Forms.Label();
            this.listHotkeys = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblKeysHeading
            // 
            this.lblKeysHeading.AutoSize = true;
            this.lblKeysHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeysHeading.Location = new System.Drawing.Point(17, 9);
            this.lblKeysHeading.Name = "lblKeysHeading";
            this.lblKeysHeading.Size = new System.Drawing.Size(71, 25);
            this.lblKeysHeading.TabIndex = 6;
            this.lblKeysHeading.Text = "Keys:";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeys.Location = new System.Drawing.Point(34, 34);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(111, 18);
            this.lblKeys.TabIndex = 8;
            this.lblKeys.Text = "Current Keys:";
            // 
            // dispKeys
            // 
            this.dispKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dispKeys.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dispKeys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dispKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispKeys.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dispKeys.Location = new System.Drawing.Point(151, 34);
            this.dispKeys.Name = "dispKeys";
            this.dispKeys.Size = new System.Drawing.Size(259, 20);
            this.dispKeys.TabIndex = 9;
            this.dispKeys.Text = "keysHere";
            // 
            // btnResetKeys
            // 
            this.btnResetKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnResetKeys.Location = new System.Drawing.Point(416, 30);
            this.btnResetKeys.Name = "btnResetKeys";
            this.btnResetKeys.Size = new System.Drawing.Size(75, 27);
            this.btnResetKeys.TabIndex = 11;
            this.btnResetKeys.TabStop = false;
            this.btnResetKeys.Text = "Reset";
            this.btnResetKeys.UseVisualStyleBackColor = true;
            this.btnResetKeys.Click += new System.EventHandler(this.btnResetKeys_Click);
            // 
            // lblHotkeysHeading
            // 
            this.lblHotkeysHeading.AutoSize = true;
            this.lblHotkeysHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotkeysHeading.Location = new System.Drawing.Point(17, 52);
            this.lblHotkeysHeading.Name = "lblHotkeysHeading";
            this.lblHotkeysHeading.Size = new System.Drawing.Size(104, 25);
            this.lblHotkeysHeading.TabIndex = 12;
            this.lblHotkeysHeading.Text = "Hotkeys:";
            // 
            // listHotkeys
            // 
            this.listHotkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHotkeys.FormattingEnabled = true;
            this.listHotkeys.Location = new System.Drawing.Point(37, 80);
            this.listHotkeys.Name = "listHotkeys";
            this.listHotkeys.Size = new System.Drawing.Size(454, 173);
            this.listHotkeys.TabIndex = 13;
            this.listHotkeys.TabStop = false;
            this.listHotkeys.SelectedIndexChanged += new System.EventHandler(this.listHotkeys_SelectedIndexChanged);
            // 
            // HotkeySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 272);
            this.Controls.Add(this.listHotkeys);
            this.Controls.Add(this.lblHotkeysHeading);
            this.Controls.Add(this.btnResetKeys);
            this.Controls.Add(this.dispKeys);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lblKeysHeading);
            this.KeyPreview = true;
            this.Name = "HotkeySearch";
            this.Text = "HotkeySearch";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeySearch_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeysHeading;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Label dispKeys;
        private System.Windows.Forms.Button btnResetKeys;
        private System.Windows.Forms.Label lblHotkeysHeading;
        private System.Windows.Forms.ListBox listHotkeys;
    }
}