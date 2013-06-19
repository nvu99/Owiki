namespace Owiki
{
    partial class searchprofile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname_search = new System.Windows.Forms.TextBox();
            this.lastname_search = new System.Windows.Forms.TextBox();
            this.search1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passportnumber_search = new System.Windows.Forms.TextBox();
            this.search2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // firstname_search
            // 
            this.firstname_search.Location = new System.Drawing.Point(76, 10);
            this.firstname_search.Name = "firstname_search";
            this.firstname_search.Size = new System.Drawing.Size(132, 20);
            this.firstname_search.TabIndex = 2;
            // 
            // lastname_search
            // 
            this.lastname_search.Location = new System.Drawing.Point(76, 42);
            this.lastname_search.Name = "lastname_search";
            this.lastname_search.Size = new System.Drawing.Size(132, 20);
            this.lastname_search.TabIndex = 3;
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(16, 74);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(75, 23);
            this.search1.TabIndex = 4;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Passport Number";
            // 
            // passportnumber_search
            // 
            this.passportnumber_search.Location = new System.Drawing.Point(108, 130);
            this.passportnumber_search.Name = "passportnumber_search";
            this.passportnumber_search.Size = new System.Drawing.Size(100, 20);
            this.passportnumber_search.TabIndex = 7;
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(16, 158);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(75, 23);
            this.search2.TabIndex = 8;
            this.search2.Text = "Search";
            this.search2.UseVisualStyleBackColor = true;
            // 
            // searchprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 189);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.passportnumber_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.lastname_search);
            this.Controls.Add(this.firstname_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "searchprofile";
            this.Text = "Search profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname_search;
        private System.Windows.Forms.TextBox lastname_search;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passportnumber_search;
        private System.Windows.Forms.Button search2;
    }
}