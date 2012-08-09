namespace ConsoleRedirection
{
    partial class FormConsole
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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.txtSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 41);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(379, 272);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "Console Redirection Test";
            // 
            // txtSayHello
            // 
            this.txtSayHello.Location = new System.Drawing.Point(12, 12);
            this.txtSayHello.Name = "txtSayHello";
            this.txtSayHello.Size = new System.Drawing.Size(75, 23);
            this.txtSayHello.TabIndex = 1;
            this.txtSayHello.Text = "Say Hello";
            this.txtSayHello.UseVisualStyleBackColor = true;
            this.txtSayHello.Click += new System.EventHandler(this.txtSayHello_Click);
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 325);
            this.Controls.Add(this.txtSayHello);
            this.Controls.Add(this.txtConsole);
            this.Name = "FormConsole";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button txtSayHello;
    }
}

