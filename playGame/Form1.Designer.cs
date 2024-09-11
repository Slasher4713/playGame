namespace playGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startingInLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingInLabel
            // 
            this.startingInLabel.BackColor = System.Drawing.Color.Transparent;
            this.startingInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingInLabel.ForeColor = System.Drawing.Color.Black;
            this.startingInLabel.Location = new System.Drawing.Point(307, 273);
            this.startingInLabel.Name = "startingInLabel";
            this.startingInLabel.Size = new System.Drawing.Size(180, 31);
            this.startingInLabel.TabIndex = 1;
            this.startingInLabel.Text = "Starting in: 3";
            this.startingInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.startingInLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(313, 44);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(175, 85);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            this.startButton.MouseLeave += new System.EventHandler(this.startButton_MouseLeave);
            this.startButton.MouseHover += new System.EventHandler(this.startButton_MouseHover);
            // 
            // hideButton
            // 
            this.hideButton.BackColor = System.Drawing.Color.Transparent;
            this.hideButton.Location = new System.Drawing.Point(677, 12);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(111, 64);
            this.hideButton.TabIndex = 3;
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.startingInLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label startingInLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button hideButton;
    }
}

