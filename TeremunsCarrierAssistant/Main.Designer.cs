namespace TeremunsCarrierAssistant
{
    partial class Main
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
            this.selectCarrierRoute = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtHowItWorks = new System.Windows.Forms.Label();
            this.listJumps = new System.Windows.Forms.ListBox();
            this.textCurrentLocation = new System.Windows.Forms.Label();
            this.textNextJump = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectCarrierRoute
            // 
            this.selectCarrierRoute.FileName = "route";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnOpenFileDialog.Location = new System.Drawing.Point(8, 8);
            this.btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(138, 37);
            this.btnOpenFileDialog.TabIndex = 0;
            this.btnOpenFileDialog.Text = "Select Route";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(8, 49);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 37);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Enage Jumps";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtHowItWorks
            // 
            this.txtHowItWorks.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHowItWorks.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtHowItWorks.Location = new System.Drawing.Point(8, 97);
            this.txtHowItWorks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtHowItWorks.Name = "txtHowItWorks";
            this.txtHowItWorks.Size = new System.Drawing.Size(137, 81);
            this.txtHowItWorks.TabIndex = 2;
            this.txtHowItWorks.Text = "This program basically simulate key presses that should automate the process of j" + "umping fleet carriers.";
            // 
            // listJumps
            // 
            this.listJumps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.listJumps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJumps.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJumps.ForeColor = System.Drawing.Color.DarkOrange;
            this.listJumps.FormattingEnabled = true;
            this.listJumps.ItemHeight = 15;
            this.listJumps.Location = new System.Drawing.Point(609, 12);
            this.listJumps.Name = "listJumps";
            this.listJumps.Size = new System.Drawing.Size(179, 405);
            this.listJumps.TabIndex = 3;
            // 
            // textCurrentLocation
            // 
            this.textCurrentLocation.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurrentLocation.ForeColor = System.Drawing.Color.White;
            this.textCurrentLocation.Location = new System.Drawing.Point(150, 12);
            this.textCurrentLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textCurrentLocation.Name = "textCurrentLocation";
            this.textCurrentLocation.Size = new System.Drawing.Size(454, 33);
            this.textCurrentLocation.TabIndex = 4;
            this.textCurrentLocation.Text = "Current Location: ???";
            this.textCurrentLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textNextJump
            // 
            this.textNextJump.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNextJump.ForeColor = System.Drawing.Color.DarkOrange;
            this.textNextJump.Location = new System.Drawing.Point(150, 49);
            this.textNextJump.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textNextJump.Name = "textNextJump";
            this.textNextJump.Size = new System.Drawing.Size(454, 33);
            this.textNextJump.TabIndex = 5;
            this.textNextJump.Text = "... ???";
            this.textNextJump.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNextJump);
            this.Controls.Add(this.textCurrentLocation);
            this.Controls.Add(this.listJumps);
            this.Controls.Add(this.txtHowItWorks);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOpenFileDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.TopMost = true;
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label textCurrentLocation;
        private System.Windows.Forms.Label textNextJump;
        private System.Windows.Forms.ListBox listJumps;
        private System.Windows.Forms.Label txtHowItWorks;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog selectCarrierRoute;

        #endregion
    }
}
