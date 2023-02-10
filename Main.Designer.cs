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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.selectCarrierRoute = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.listJumps = new System.Windows.Forms.ListBox();
            this.textCurrentLocation = new System.Windows.Forms.Label();
            this.textNextJump = new System.Windows.Forms.Label();
            this.textDebug = new System.Windows.Forms.Label();
            this.tritiumPosition = new System.Windows.Forms.NumericUpDown();
            this.textTritiumPos = new System.Windows.Forms.Label();
            this.textGalaxyMapBuffer = new System.Windows.Forms.Label();
            this.galaxyMapLag = new System.Windows.Forms.NumericUpDown();
            this.checkRefuelMan = new System.Windows.Forms.CheckBox();
            this.btnUpdateLocation = new System.Windows.Forms.Button();
            this.countdown = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.tritiumPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galaxyMapLag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countdown)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCarrierRoute
            // 
            this.selectCarrierRoute.FileName = "route";
            resources.ApplyResources(this.selectCarrierRoute, "selectCarrierRoute");
            // 
            // btnOpenFileDialog
            // 
            resources.ApplyResources(this.btnOpenFileDialog, "btnOpenFileDialog");
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listJumps
            // 
            resources.ApplyResources(this.listJumps, "listJumps");
            this.listJumps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.listJumps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJumps.ForeColor = System.Drawing.Color.DarkOrange;
            this.listJumps.FormattingEnabled = true;
            this.listJumps.Name = "listJumps";
            this.listJumps.SelectionMode = System.Windows.Forms.SelectionMode.None;
            // 
            // textCurrentLocation
            // 
            resources.ApplyResources(this.textCurrentLocation, "textCurrentLocation");
            this.textCurrentLocation.BackColor = System.Drawing.Color.Transparent;
            this.textCurrentLocation.ForeColor = System.Drawing.Color.White;
            this.textCurrentLocation.Name = "textCurrentLocation";
            // 
            // textNextJump
            // 
            resources.ApplyResources(this.textNextJump, "textNextJump");
            this.textNextJump.BackColor = System.Drawing.Color.Transparent;
            this.textNextJump.ForeColor = System.Drawing.Color.White;
            this.textNextJump.Name = "textNextJump";
            // 
            // textDebug
            // 
            resources.ApplyResources(this.textDebug, "textDebug");
            this.textDebug.BackColor = System.Drawing.Color.Transparent;
            this.textDebug.ForeColor = System.Drawing.Color.DarkOrange;
            this.textDebug.Name = "textDebug";
            // 
            // tritiumPosition
            // 
            resources.ApplyResources(this.tritiumPosition, "tritiumPosition");
            this.tritiumPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.tritiumPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tritiumPosition.ForeColor = System.Drawing.Color.White;
            this.tritiumPosition.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            this.tritiumPosition.Name = "tritiumPosition";
            this.tritiumPosition.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            this.tritiumPosition.ValueChanged += new System.EventHandler(this.tritiumItemSlot_ValueChanged);
            // 
            // textTritiumPos
            // 
            resources.ApplyResources(this.textTritiumPos, "textTritiumPos");
            this.textTritiumPos.BackColor = System.Drawing.Color.Transparent;
            this.textTritiumPos.ForeColor = System.Drawing.Color.DarkOrange;
            this.textTritiumPos.Name = "textTritiumPos";
            // 
            // textGalaxyMapBuffer
            // 
            resources.ApplyResources(this.textGalaxyMapBuffer, "textGalaxyMapBuffer");
            this.textGalaxyMapBuffer.BackColor = System.Drawing.Color.Transparent;
            this.textGalaxyMapBuffer.ForeColor = System.Drawing.Color.DarkOrange;
            this.textGalaxyMapBuffer.Name = "textGalaxyMapBuffer";
            // 
            // galaxyMapLag
            // 
            resources.ApplyResources(this.galaxyMapLag, "galaxyMapLag");
            this.galaxyMapLag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.galaxyMapLag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.galaxyMapLag.ForeColor = System.Drawing.Color.White;
            this.galaxyMapLag.Maximum = new decimal(new int[]
            {
                15,
                0,
                0,
                0
            });
            this.galaxyMapLag.Minimum = new decimal(new int[]
            {
                7,
                0,
                0,
                0
            });
            this.galaxyMapLag.Name = "galaxyMapLag";
            this.galaxyMapLag.Value = new decimal(new int[]
            {
                7,
                0,
                0,
                0
            });
            this.galaxyMapLag.ValueChanged += new System.EventHandler(this.galaxyBuffer_ValueChanged);
            // 
            // checkRefuelMan
            // 
            resources.ApplyResources(this.checkRefuelMan, "checkRefuelMan");
            this.checkRefuelMan.BackColor = System.Drawing.Color.Transparent;
            this.checkRefuelMan.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkRefuelMan.Name = "checkRefuelMan";
            this.checkRefuelMan.UseVisualStyleBackColor = false;
            this.checkRefuelMan.CheckedChanged += new System.EventHandler(this.checkRefuelMan_CheckedChanged);
            // 
            // btnUpdateLocation
            // 
            resources.ApplyResources(this.btnUpdateLocation, "btnUpdateLocation");
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.UseVisualStyleBackColor = true;
            this.btnUpdateLocation.Click += new System.EventHandler(this.btnUpdateLocation_Click);
            // 
            // countdown
            // 
            this.countdown.SynchronizingObject = this;
            this.countdown.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer_Elapsed);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TeremunsCarrierAssistant.Properties.Resources.appBackground;
            this.Controls.Add(this.btnUpdateLocation);
            this.Controls.Add(this.checkRefuelMan);
            this.Controls.Add(this.textGalaxyMapBuffer);
            this.Controls.Add(this.galaxyMapLag);
            this.Controls.Add(this.textTritiumPos);
            this.Controls.Add(this.tritiumPosition);
            this.Controls.Add(this.textDebug);
            this.Controls.Add(this.textNextJump);
            this.Controls.Add(this.textCurrentLocation);
            this.Controls.Add(this.listJumps);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOpenFileDialog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tritiumPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galaxyMapLag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countdown)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Timers.Timer countdown;
        private System.Windows.Forms.Button btnUpdateLocation;
        private System.Windows.Forms.CheckBox checkRefuelMan;
        private System.Windows.Forms.Label textTritiumPos;
        private System.Windows.Forms.Label textGalaxyMapBuffer;
        private System.Windows.Forms.NumericUpDown galaxyMapLag;
        private System.Windows.Forms.NumericUpDown tritiumPosition;
        private System.Windows.Forms.Label textDebug;
        private System.Windows.Forms.Label textCurrentLocation;
        private System.Windows.Forms.Label textNextJump;
        private System.Windows.Forms.ListBox listJumps;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog selectCarrierRoute;

        #endregion
    }
}
