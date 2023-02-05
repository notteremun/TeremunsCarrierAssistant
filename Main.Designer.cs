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
            this.textDebug = new System.Windows.Forms.Label();
            this.tritiumItemSlot = new System.Windows.Forms.NumericUpDown();
            this.textTritiumPos = new System.Windows.Forms.Label();
            this.textGalaxyMapBuffer = new System.Windows.Forms.Label();
            this.numUpDownGalaxyBuffer = new System.Windows.Forms.NumericUpDown();
            this.checkRefuelMan = new System.Windows.Forms.CheckBox();
            this.btnUpdateLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tritiumItemSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGalaxyBuffer)).BeginInit();
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
            this.listJumps.Location = new System.Drawing.Point(519, 8);
            this.listJumps.Name = "listJumps";
            this.listJumps.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listJumps.Size = new System.Drawing.Size(179, 300);
            this.listJumps.TabIndex = 3;
            // 
            // textCurrentLocation
            // 
            this.textCurrentLocation.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurrentLocation.ForeColor = System.Drawing.Color.White;
            this.textCurrentLocation.Location = new System.Drawing.Point(150, 12);
            this.textCurrentLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textCurrentLocation.Name = "textCurrentLocation";
            this.textCurrentLocation.Size = new System.Drawing.Size(364, 33);
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
            this.textNextJump.Size = new System.Drawing.Size(364, 33);
            this.textNextJump.TabIndex = 5;
            this.textNextJump.Text = "... ???";
            this.textNextJump.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textDebug
            // 
            this.textDebug.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDebug.ForeColor = System.Drawing.Color.DarkOrange;
            this.textDebug.Location = new System.Drawing.Point(8, 291);
            this.textDebug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textDebug.Name = "textDebug";
            this.textDebug.Size = new System.Drawing.Size(506, 18);
            this.textDebug.TabIndex = 6;
            this.textDebug.Text = "Waiting for a flightplan...";
            // 
            // tritiumItemSlot
            // 
            this.tritiumItemSlot.BackColor = System.Drawing.Color.Black;
            this.tritiumItemSlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tritiumItemSlot.Font = new System.Drawing.Font("Montserrat SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tritiumItemSlot.ForeColor = System.Drawing.Color.White;
            this.tritiumItemSlot.Location = new System.Drawing.Point(21, 190);
            this.tritiumItemSlot.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            this.tritiumItemSlot.Name = "tritiumItemSlot";
            this.tritiumItemSlot.Size = new System.Drawing.Size(40, 17);
            this.tritiumItemSlot.TabIndex = 7;
            this.tritiumItemSlot.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            this.tritiumItemSlot.ValueChanged += new System.EventHandler(this.tritiumItemSlot_ValueChanged);
            // 
            // textTritiumPos
            // 
            this.textTritiumPos.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTritiumPos.ForeColor = System.Drawing.Color.DarkOrange;
            this.textTritiumPos.Location = new System.Drawing.Point(66, 190);
            this.textTritiumPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textTritiumPos.Name = "textTritiumPos";
            this.textTritiumPos.Size = new System.Drawing.Size(98, 17);
            this.textTritiumPos.TabIndex = 8;
            this.textTritiumPos.Text = "Tritium Position";
            // 
            // textGalaxyMapBuffer
            // 
            this.textGalaxyMapBuffer.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGalaxyMapBuffer.ForeColor = System.Drawing.Color.DarkOrange;
            this.textGalaxyMapBuffer.Location = new System.Drawing.Point(66, 213);
            this.textGalaxyMapBuffer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textGalaxyMapBuffer.Name = "textGalaxyMapBuffer";
            this.textGalaxyMapBuffer.Size = new System.Drawing.Size(130, 17);
            this.textGalaxyMapBuffer.TabIndex = 10;
            this.textGalaxyMapBuffer.Text = "Galaxy Map Buffer (s)";
            // 
            // numUpDownGalaxyBuffer
            // 
            this.numUpDownGalaxyBuffer.BackColor = System.Drawing.Color.Black;
            this.numUpDownGalaxyBuffer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUpDownGalaxyBuffer.Font = new System.Drawing.Font("Montserrat SemiBold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownGalaxyBuffer.ForeColor = System.Drawing.Color.White;
            this.numUpDownGalaxyBuffer.Location = new System.Drawing.Point(21, 213);
            this.numUpDownGalaxyBuffer.Maximum = new decimal(new int[]
            {
                15,
                0,
                0,
                0
            });
            this.numUpDownGalaxyBuffer.Minimum = new decimal(new int[]
            {
                7,
                0,
                0,
                0
            });
            this.numUpDownGalaxyBuffer.Name = "numUpDownGalaxyBuffer";
            this.numUpDownGalaxyBuffer.Size = new System.Drawing.Size(40, 17);
            this.numUpDownGalaxyBuffer.TabIndex = 9;
            this.numUpDownGalaxyBuffer.Value = new decimal(new int[]
            {
                7,
                0,
                0,
                0
            });
            this.numUpDownGalaxyBuffer.ValueChanged += new System.EventHandler(this.galaxyBuffer_ValueChanged);
            // 
            // checkRefuelMan
            // 
            this.checkRefuelMan.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRefuelMan.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkRefuelMan.Location = new System.Drawing.Point(21, 236);
            this.checkRefuelMan.Name = "checkRefuelMan";
            this.checkRefuelMan.Size = new System.Drawing.Size(213, 18);
            this.checkRefuelMan.TabIndex = 11;
            this.checkRefuelMan.Text = "Refuel Manually (recommended)";
            this.checkRefuelMan.UseVisualStyleBackColor = true;
            this.checkRefuelMan.CheckedChanged += new System.EventHandler(this.checkRefuelMan_CheckedChanged);
            // 
            // btnUpdateLocation
            // 
            this.btnUpdateLocation.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUpdateLocation.Location = new System.Drawing.Point(7, 259);
            this.btnUpdateLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.Size = new System.Drawing.Size(87, 30);
            this.btnUpdateLocation.TabIndex = 12;
            this.btnUpdateLocation.Text = "Update";
            this.btnUpdateLocation.UseVisualStyleBackColor = true;
            this.btnUpdateLocation.Click += new System.EventHandler(this.btnUpdateLocation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(707, 318);
            this.Controls.Add(this.btnUpdateLocation);
            this.Controls.Add(this.checkRefuelMan);
            this.Controls.Add(this.textGalaxyMapBuffer);
            this.Controls.Add(this.numUpDownGalaxyBuffer);
            this.Controls.Add(this.textTritiumPos);
            this.Controls.Add(this.tritiumItemSlot);
            this.Controls.Add(this.textDebug);
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
            ((System.ComponentModel.ISupportInitialize)(this.tritiumItemSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGalaxyBuffer)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button btnUpdateLocation;
        private System.Windows.Forms.CheckBox checkRefuelMan;
        private System.Windows.Forms.Label textTritiumPos;
        private System.Windows.Forms.Label textGalaxyMapBuffer;
        private System.Windows.Forms.NumericUpDown numUpDownGalaxyBuffer;
        private System.Windows.Forms.NumericUpDown tritiumItemSlot;
        private System.Windows.Forms.Label textDebug;
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
