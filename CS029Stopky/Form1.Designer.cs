namespace CS029Stopky
{
    partial class CS029Stopky
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startStopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.casLabel = new System.Windows.Forms.Label();
            this.stopkyTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startStopButton.Location = new System.Drawing.Point(392, 172);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(148, 64);
            this.startStopButton.TabIndex = 0;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetButton.Location = new System.Drawing.Point(104, 307);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(172, 78);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // casLabel
            // 
            this.casLabel.AutoSize = true;
            this.casLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.casLabel.Location = new System.Drawing.Point(194, 130);
            this.casLabel.Name = "casLabel";
            this.casLabel.Size = new System.Drawing.Size(93, 31);
            this.casLabel.TabIndex = 2;
            this.casLabel.Text = "Čas: ?";
            // 
            // stopkyTimer
            // 
            this.stopkyTimer.Tick += new System.EventHandler(this.stopkyTimer_Tick);
            // 
            // CS029Stopky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.casLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startStopButton);
            this.Name = "CS029Stopky";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label casLabel;
        private System.Windows.Forms.Timer stopkyTimer;
    }
}

