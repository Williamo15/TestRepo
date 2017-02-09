namespace MessageBoxGithubDing
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
            this.btnMessageEenMaSt = new System.Windows.Forms.Button();
            this.btnMessageTweeMaSt = new System.Windows.Forms.Button();
            this.btnMessageDrieMaSt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessageEenMaSt
            // 
            this.btnMessageEenMaSt.BackColor = System.Drawing.Color.Black;
            this.btnMessageEenMaSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageEenMaSt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageEenMaSt.ForeColor = System.Drawing.Color.White;
            this.btnMessageEenMaSt.Location = new System.Drawing.Point(58, 64);
            this.btnMessageEenMaSt.Name = "btnMessageEenMaSt";
            this.btnMessageEenMaSt.Size = new System.Drawing.Size(104, 39);
            this.btnMessageEenMaSt.TabIndex = 0;
            this.btnMessageEenMaSt.Text = "Message 1";
            this.btnMessageEenMaSt.UseVisualStyleBackColor = false;
            this.btnMessageEenMaSt.Click += new System.EventHandler(this.btnMessageEenMaSt_Click);
            // 
            // btnMessageTweeMaSt
            // 
            this.btnMessageTweeMaSt.BackColor = System.Drawing.Color.Black;
            this.btnMessageTweeMaSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageTweeMaSt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageTweeMaSt.ForeColor = System.Drawing.Color.White;
            this.btnMessageTweeMaSt.Location = new System.Drawing.Point(254, 64);
            this.btnMessageTweeMaSt.Name = "btnMessageTweeMaSt";
            this.btnMessageTweeMaSt.Size = new System.Drawing.Size(104, 39);
            this.btnMessageTweeMaSt.TabIndex = 1;
            this.btnMessageTweeMaSt.Text = "Message 2";
            this.btnMessageTweeMaSt.UseVisualStyleBackColor = false;
            this.btnMessageTweeMaSt.Click += new System.EventHandler(this.btnMessageTweeMaSt_Click);
            // 
            // btnMessageDrieMaSt
            // 
            this.btnMessageDrieMaSt.BackColor = System.Drawing.Color.Black;
            this.btnMessageDrieMaSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageDrieMaSt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageDrieMaSt.ForeColor = System.Drawing.Color.White;
            this.btnMessageDrieMaSt.Location = new System.Drawing.Point(473, 64);
            this.btnMessageDrieMaSt.Name = "btnMessageDrieMaSt";
            this.btnMessageDrieMaSt.Size = new System.Drawing.Size(104, 39);
            this.btnMessageDrieMaSt.TabIndex = 2;
            this.btnMessageDrieMaSt.Text = "Message 3";
            this.btnMessageDrieMaSt.UseVisualStyleBackColor = false;
            this.btnMessageDrieMaSt.Click += new System.EventHandler(this.btnMessageDrieMaSt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(626, 244);
            this.Controls.Add(this.btnMessageDrieMaSt);
            this.Controls.Add(this.btnMessageTweeMaSt);
            this.Controls.Add(this.btnMessageEenMaSt);
            this.Name = "Form1";
            this.Text = "Message Box Ding";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessageEenMaSt;
        private System.Windows.Forms.Button btnMessageTweeMaSt;
        private System.Windows.Forms.Button btnMessageDrieMaSt;
    }
}

