namespace task1_GADE_KyleCowan_18013107_V2
{
    partial class frmGame
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.cmbUnitsDesplay = new System.Windows.Forms.ComboBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblHammer = new System.Windows.Forms.Label();
            this.lblRagger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(735, 124);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 87);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start\r\n>";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(923, 124);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 87);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop\r\n||";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(862, 69);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(48, 17);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Timer";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(55, 69);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(112, 17);
            this.lblMap.TabIndex = 3;
            this.lblMap.Text = "Map goes here";
            // 
            // cmbUnitsDesplay
            // 
            this.cmbUnitsDesplay.FormattingEnabled = true;
            this.cmbUnitsDesplay.Location = new System.Drawing.Point(807, 298);
            this.cmbUnitsDesplay.Name = "cmbUnitsDesplay";
            this.cmbUnitsDesplay.Size = new System.Drawing.Size(171, 24);
            this.cmbUnitsDesplay.TabIndex = 5;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblHammer
            // 
            this.lblHammer.AutoSize = true;
            this.lblHammer.Location = new System.Drawing.Point(739, 223);
            this.lblHammer.Name = "lblHammer";
            this.lblHammer.Size = new System.Drawing.Size(152, 34);
            this.lblHammer.TabIndex = 6;
            this.lblHammer.Text = "HammerHeadR Sharks \r\nResource";
            // 
            // lblRagger
            // 
            this.lblRagger.AutoSize = true;
            this.lblRagger.Location = new System.Drawing.Point(924, 223);
            this.lblRagger.Name = "lblRagger";
            this.lblRagger.Size = new System.Drawing.Size(152, 34);
            this.lblRagger.TabIndex = 7;
            this.lblRagger.Text = "RaggerToothR Shark \r\nResource";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 527);
            this.Controls.Add(this.lblRagger);
            this.Controls.Add(this.lblHammer);
            this.Controls.Add(this.cmbUnitsDesplay);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnStop;
        public System.Windows.Forms.Label lblTimer;
        public System.Windows.Forms.Label lblMap;
        public System.Windows.Forms.ComboBox cmbUnitsDesplay;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblHammer;
        private System.Windows.Forms.Label lblRagger;
    }
}

