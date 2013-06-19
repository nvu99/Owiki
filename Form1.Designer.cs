namespace Owiki
{
    partial class Owiki
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
            this.newprofile = new System.Windows.Forms.Button();
            this.editprofile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newprofile
            // 
            this.newprofile.Location = new System.Drawing.Point(12, 12);
            this.newprofile.Name = "newprofile";
            this.newprofile.Size = new System.Drawing.Size(140, 69);
            this.newprofile.TabIndex = 0;
            this.newprofile.Text = "New profile";
            this.newprofile.UseVisualStyleBackColor = true;
            this.newprofile.Click += new System.EventHandler(this.newprofile_Click);
            // 
            // editprofile
            // 
            this.editprofile.Location = new System.Drawing.Point(12, 87);
            this.editprofile.Name = "editprofile";
            this.editprofile.Size = new System.Drawing.Size(140, 69);
            this.editprofile.TabIndex = 1;
            this.editprofile.Text = "Edit/Show profile";
            this.editprofile.UseVisualStyleBackColor = true;
            this.editprofile.Click += new System.EventHandler(this.editprofile_Click);
            // 
            // Owiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 169);
            this.Controls.Add(this.editprofile);
            this.Controls.Add(this.newprofile);
            this.Name = "Owiki";
            this.Text = "Profiles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newprofile;
        private System.Windows.Forms.Button editprofile;
    }
}

