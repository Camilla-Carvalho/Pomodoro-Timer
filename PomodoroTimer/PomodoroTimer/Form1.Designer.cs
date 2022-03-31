
namespace PomodoroTimer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.clear = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.TextBox();
            this.txtIntroduction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.clear.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(274, 249);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 38);
            this.clear.TabIndex = 9;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.stop.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stop.Location = new System.Drawing.Point(176, 249);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 38);
            this.stop.TabIndex = 8;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click_1);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.start.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start.Location = new System.Drawing.Point(82, 249);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 38);
            this.start.TabIndex = 7;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.Firebrick;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.SystemColors.Window;
            this.timer.Location = new System.Drawing.Point(82, 138);
            this.timer.Name = "timer";
            this.timer.ReadOnly = true;
            this.timer.Size = new System.Drawing.Size(267, 76);
            this.timer.TabIndex = 6;
            this.timer.Text = "00:00:00";
            this.timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.AutoSize = true;
            this.txtIntroduction.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntroduction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIntroduction.Location = new System.Drawing.Point(95, 83);
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.Size = new System.Drawing.Size(231, 42);
            this.txtIntroduction.TabIndex = 5;
            this.txtIntroduction.Text = "Pomodoro Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(448, 396);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.txtIntroduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.Label txtIntroduction;
    }
}

