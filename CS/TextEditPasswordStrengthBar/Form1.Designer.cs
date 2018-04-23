namespace TextEditPasswordStrengthBar
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
            this.textEditPwdStrength2 = new TextEditPasswordStrengthBar.TextEditPwdStrength();
            this.textEditPwdStrength1 = new TextEditPasswordStrengthBar.TextEditPwdStrength();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwdStrength2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwdStrength1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditPwdStrength2
            // 
            this.textEditPwdStrength2.Location = new System.Drawing.Point(120, 13);
            this.textEditPwdStrength2.Name = "textEditPwdStrength2";
            this.textEditPwdStrength2.Properties.PasswordChar = '*';
            this.textEditPwdStrength2.Size = new System.Drawing.Size(100, 20);
            this.textEditPwdStrength2.TabIndex = 1;
            this.textEditPwdStrength2.Leave += new System.EventHandler(this.textEditPwdStrength_Leave);
            this.textEditPwdStrength2.Enter += new System.EventHandler(this.textEditPwdStrength_Enter);
            // 
            // textEditPwdStrength1
            // 
            this.textEditPwdStrength1.EditValue = "@Erv_42Ord";
            this.textEditPwdStrength1.Location = new System.Drawing.Point(13, 13);
            this.textEditPwdStrength1.Name = "textEditPwdStrength1";
            this.textEditPwdStrength1.Properties.PasswordChar = '*';
            this.textEditPwdStrength1.Size = new System.Drawing.Size(100, 20);
            this.textEditPwdStrength1.TabIndex = 0;
            this.textEditPwdStrength1.Leave += new System.EventHandler(this.textEditPwdStrength_Leave);
            this.textEditPwdStrength1.Enter += new System.EventHandler(this.textEditPwdStrength_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 44);
            this.Controls.Add(this.textEditPwdStrength2);
            this.Controls.Add(this.textEditPwdStrength1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwdStrength2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwdStrength1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextEditPwdStrength textEditPwdStrength1;
        private TextEditPwdStrength textEditPwdStrength2;

    }
}

