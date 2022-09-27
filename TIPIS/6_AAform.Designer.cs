namespace TIPIS
{
    partial class AAform
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
            this.real = new System.Windows.Forms.Label();
            this.forecast = new System.Windows.Forms.Label();
            this.determine = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // real
            // 
            this.real.AutoSize = true;
            this.real.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.real.Location = new System.Drawing.Point(12, 9);
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(206, 17);
            this.real.TabIndex = 0;
            this.real.Text = "Реальные значения функции:";
            // 
            // forecast
            // 
            this.forecast.AutoSize = true;
            this.forecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forecast.Location = new System.Drawing.Point(12, 40);
            this.forecast.Name = "forecast";
            this.forecast.Size = new System.Drawing.Size(274, 17);
            this.forecast.TabIndex = 1;
            this.forecast.Text = "Спрогнозированные значения функции:";
            // 
            // determine
            // 
            this.determine.AutoSize = true;
            this.determine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.determine.Location = new System.Drawing.Point(12, 69);
            this.determine.Name = "determine";
            this.determine.Size = new System.Drawing.Size(254, 20);
            this.determine.TabIndex = 2;
            this.determine.Text = "Коэффициент детерминации = ";
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(12, 106);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(235, 29);
            this.Count.TabIndex = 3;
            this.Count.Text = "Запустить прогнозирование";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // AAform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 212);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.determine);
            this.Controls.Add(this.forecast);
            this.Controls.Add(this.real);
            this.Name = "AAform";
            this.Text = "AAform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label real;
        private System.Windows.Forms.Label forecast;
        private System.Windows.Forms.Label determine;
        private System.Windows.Forms.Button Count;
    }
}