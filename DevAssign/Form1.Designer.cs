namespace DevAssign
{
    partial class MainPage
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
            this.Execute = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.ComboBox();
            this.txtBSValue = new System.Windows.Forms.TextBox();
            this.lblEnterValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(150, 403);
            this.Execute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(174, 56);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // options
            // 
            this.options.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.FormattingEnabled = true;
            this.options.Location = new System.Drawing.Point(50, 118);
            this.options.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(383, 25);
            this.options.TabIndex = 2;
            this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged_1);
            // 
            // txtBSValue
            // 
            this.txtBSValue.Enabled = false;
            this.txtBSValue.Location = new System.Drawing.Point(172, 243);
            this.txtBSValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBSValue.Name = "txtBSValue";
            this.txtBSValue.Size = new System.Drawing.Size(136, 26);
            this.txtBSValue.TabIndex = 3;
            this.txtBSValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBSValue.TextChanged += new System.EventHandler(this.txtBSValue_TextChanged);
            // 
            // lblEnterValue
            // 
            this.lblEnterValue.AutoSize = true;
            this.lblEnterValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEnterValue.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterValue.Location = new System.Drawing.Point(106, 190);
            this.lblEnterValue.Name = "lblEnterValue";
            this.lblEnterValue.Size = new System.Drawing.Size(296, 28);
            this.lblEnterValue.TabIndex = 4;
            this.lblEnterValue.Text = "Enter A value ( for Binary Search)";
            this.lblEnterValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(482, 543);
            this.Controls.Add(this.lblEnterValue);
            this.Controls.Add(this.txtBSValue);
            this.Controls.Add(this.options);
            this.Controls.Add(this.Execute);
            this.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileOperations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.ComboBox options;
        private System.Windows.Forms.TextBox txtBSValue;
        private System.Windows.Forms.Label lblEnterValue;
    }
}

