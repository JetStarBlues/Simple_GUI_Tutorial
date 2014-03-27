namespace Simple_GUI
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
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblFps = new System.Windows.Forms.Label();
            this.lblSaveLoc = new System.Windows.Forms.Label();
            this.txtSaveLoc = new System.Windows.Forms.TextBox();
            this.txtStartH = new System.Windows.Forms.TextBox();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.txtStartMS = new System.Windows.Forms.TextBox();
            this.txtStartS = new System.Windows.Forms.TextBox();
            this.txtStartM = new System.Windows.Forms.TextBox();
            this.txtStopM = new System.Windows.Forms.TextBox();
            this.txtStopS = new System.Windows.Forms.TextBox();
            this.txtStopMS = new System.Windows.Forms.TextBox();
            this.txtStopH = new System.Windows.Forms.TextBox();
            this.txtFps = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblTimeSyntax = new System.Windows.Forms.Label();
            this.fbdSaveLoc = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdVideo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.Location = new System.Drawing.Point(26, 34);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(92, 18);
            this.lblVideo.TabIndex = 0;
            this.lblVideo.Text = "Choose video";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(26, 87);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(37, 18);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start";
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Location = new System.Drawing.Point(26, 136);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(36, 18);
            this.lblStop.TabIndex = 2;
            this.lblStop.Text = "Stop";
            // 
            // lblFps
            // 
            this.lblFps.AutoSize = true;
            this.lblFps.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFps.Location = new System.Drawing.Point(26, 190);
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(29, 18);
            this.lblFps.TabIndex = 3;
            this.lblFps.Text = "Fps";
            // 
            // lblSaveLoc
            // 
            this.lblSaveLoc.AutoSize = true;
            this.lblSaveLoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveLoc.Location = new System.Drawing.Point(26, 240);
            this.lblSaveLoc.Name = "lblSaveLoc";
            this.lblSaveLoc.Size = new System.Drawing.Size(137, 18);
            this.lblSaveLoc.TabIndex = 4;
            this.lblSaveLoc.Text = "Choose save location";
            // 
            // txtSaveLoc
            // 
            this.txtSaveLoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaveLoc.Location = new System.Drawing.Point(42, 261);
            this.txtSaveLoc.Name = "txtSaveLoc";
            this.txtSaveLoc.Size = new System.Drawing.Size(221, 26);
            this.txtSaveLoc.TabIndex = 11;
            this.txtSaveLoc.Click += new System.EventHandler(this.txtSaveLoc_Click);
            // 
            // txtStartH
            // 
            this.txtStartH.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartH.Location = new System.Drawing.Point(42, 108);
            this.txtStartH.Name = "txtStartH";
            this.txtStartH.Size = new System.Drawing.Size(28, 26);
            this.txtStartH.TabIndex = 2;
            this.txtStartH.Click += new System.EventHandler(this.txtStartH_Click);
            this.txtStartH.Enter += new System.EventHandler(this.txtStartH_Enter);
            this.txtStartH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartH_KeyDown);
            this.txtStartH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartH_KeyPress);
            // 
            // txtVideo
            // 
            this.txtVideo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideo.Location = new System.Drawing.Point(42, 55);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(207, 26);
            this.txtVideo.TabIndex = 1;
            this.txtVideo.Click += new System.EventHandler(this.txtVideo_Click);
            // 
            // txtStartMS
            // 
            this.txtStartMS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMS.Location = new System.Drawing.Point(144, 108);
            this.txtStartMS.MaxLength = 3;
            this.txtStartMS.Name = "txtStartMS";
            this.txtStartMS.Size = new System.Drawing.Size(44, 26);
            this.txtStartMS.TabIndex = 5;
            this.txtStartMS.Click += new System.EventHandler(this.txtStartMS_Click);
            this.txtStartMS.Enter += new System.EventHandler(this.txtStartMS_Enter);
            this.txtStartMS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartMS_KeyDown);
            this.txtStartMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartMS_KeyPress);
            // 
            // txtStartS
            // 
            this.txtStartS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartS.Location = new System.Drawing.Point(110, 108);
            this.txtStartS.MaxLength = 2;
            this.txtStartS.Name = "txtStartS";
            this.txtStartS.Size = new System.Drawing.Size(28, 26);
            this.txtStartS.TabIndex = 4;
            this.txtStartS.Click += new System.EventHandler(this.txtStartS_Click);
            this.txtStartS.Enter += new System.EventHandler(this.txtStartS_Enter);
            this.txtStartS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartS_KeyDown);
            this.txtStartS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartS_KeyPress);
            this.txtStartS.Leave += new System.EventHandler(this.txtStartS_Leave);
            // 
            // txtStartM
            // 
            this.txtStartM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartM.Location = new System.Drawing.Point(76, 108);
            this.txtStartM.MaxLength = 2;
            this.txtStartM.Name = "txtStartM";
            this.txtStartM.Size = new System.Drawing.Size(28, 26);
            this.txtStartM.TabIndex = 3;
            this.txtStartM.Click += new System.EventHandler(this.txtStartM_Click);
            this.txtStartM.Enter += new System.EventHandler(this.txtStartM_Enter);
            this.txtStartM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartM_KeyDown);
            this.txtStartM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartM_KeyPress);
            this.txtStartM.Leave += new System.EventHandler(this.txtStartM_Leave);
            // 
            // txtStopM
            // 
            this.txtStopM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStopM.Location = new System.Drawing.Point(76, 157);
            this.txtStopM.MaxLength = 2;
            this.txtStopM.Name = "txtStopM";
            this.txtStopM.Size = new System.Drawing.Size(28, 26);
            this.txtStopM.TabIndex = 7;
            this.txtStopM.Click += new System.EventHandler(this.txtStopM_Click);
            this.txtStopM.Enter += new System.EventHandler(this.txtStopM_Enter);
            this.txtStopM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStopM_KeyDown);
            this.txtStopM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStopM_KeyPress);
            this.txtStopM.Leave += new System.EventHandler(this.txtStopM_Leave);
            // 
            // txtStopS
            // 
            this.txtStopS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStopS.Location = new System.Drawing.Point(110, 157);
            this.txtStopS.MaxLength = 2;
            this.txtStopS.Name = "txtStopS";
            this.txtStopS.Size = new System.Drawing.Size(28, 26);
            this.txtStopS.TabIndex = 8;
            this.txtStopS.Click += new System.EventHandler(this.txtStopS_Click);
            this.txtStopS.Enter += new System.EventHandler(this.txtStopS_Enter);
            this.txtStopS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStopS_KeyDown);
            this.txtStopS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStopS_KeyPress);
            this.txtStopS.Leave += new System.EventHandler(this.txtStopS_Leave);
            // 
            // txtStopMS
            // 
            this.txtStopMS.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStopMS.Location = new System.Drawing.Point(144, 157);
            this.txtStopMS.MaxLength = 3;
            this.txtStopMS.Name = "txtStopMS";
            this.txtStopMS.Size = new System.Drawing.Size(44, 26);
            this.txtStopMS.TabIndex = 9;
            this.txtStopMS.Click += new System.EventHandler(this.txtStopMS_Click);
            this.txtStopMS.Enter += new System.EventHandler(this.txtStopMS_Enter);
            this.txtStopMS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStopMS_KeyDown);
            this.txtStopMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStopMS_KeyPress);
            // 
            // txtStopH
            // 
            this.txtStopH.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStopH.Location = new System.Drawing.Point(42, 157);
            this.txtStopH.Name = "txtStopH";
            this.txtStopH.Size = new System.Drawing.Size(28, 26);
            this.txtStopH.TabIndex = 6;
            this.txtStopH.Click += new System.EventHandler(this.txtStopH_Click);
            this.txtStopH.Enter += new System.EventHandler(this.txtStopH_Enter);
            this.txtStopH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStopH_KeyDown);
            this.txtStopH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStopH_KeyPress);
            // 
            // txtFps
            // 
            this.txtFps.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFps.Location = new System.Drawing.Point(42, 211);
            this.txtFps.Name = "txtFps";
            this.txtFps.Size = new System.Drawing.Size(36, 26);
            this.txtFps.TabIndex = 10;
            this.txtFps.Click += new System.EventHandler(this.txtFps_Click);
            this.txtFps.Enter += new System.EventHandler(this.txtFps_Enter);
            this.txtFps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFps_KeyDown);
            this.txtFps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFps_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(42, 315);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 37);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(176, 316);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(87, 36);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblTimeSyntax
            // 
            this.lblTimeSyntax.AutoSize = true;
            this.lblTimeSyntax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSyntax.Location = new System.Drawing.Point(205, 111);
            this.lblTimeSyntax.Name = "lblTimeSyntax";
            this.lblTimeSyntax.Size = new System.Drawing.Size(80, 18);
            this.lblTimeSyntax.TabIndex = 18;
            this.lblTimeSyntax.Text = "( h:m:s:ms )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 391);
            this.Controls.Add(this.lblTimeSyntax);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtFps);
            this.Controls.Add(this.txtStopM);
            this.Controls.Add(this.txtStopS);
            this.Controls.Add(this.txtStopMS);
            this.Controls.Add(this.txtStopH);
            this.Controls.Add(this.txtStartM);
            this.Controls.Add(this.txtStartS);
            this.Controls.Add(this.txtStartMS);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.txtStartH);
            this.Controls.Add(this.txtSaveLoc);
            this.Controls.Add(this.lblSaveLoc);
            this.Controls.Add(this.lblFps);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblVideo);
            this.Name = "Form1";
            this.Text = "Grab them frames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.Label lblSaveLoc;
        private System.Windows.Forms.TextBox txtSaveLoc;
        private System.Windows.Forms.TextBox txtStartH;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.TextBox txtStartMS;
        private System.Windows.Forms.TextBox txtStartS;
        private System.Windows.Forms.TextBox txtStartM;
        private System.Windows.Forms.TextBox txtStopM;
        private System.Windows.Forms.TextBox txtStopS;
        private System.Windows.Forms.TextBox txtStopMS;
        private System.Windows.Forms.TextBox txtStopH;
        private System.Windows.Forms.TextBox txtFps;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblTimeSyntax;
        private System.Windows.Forms.FolderBrowserDialog fbdSaveLoc;
        private System.Windows.Forms.OpenFileDialog ofdVideo;
    }
}

