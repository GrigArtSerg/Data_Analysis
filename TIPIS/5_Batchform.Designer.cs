namespace TIPIS
{
    partial class Batchform
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
            this.count = new System.Windows.Forms.Button();
            this.Period = new System.Windows.Forms.Label();
            this.func = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.W)).BeginInit();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(12, 103);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(108, 29);
            this.count.TabIndex = 1;
            this.count.Text = "Рассчитать";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.button1_Click);
            // 
            // Period
            // 
            this.Period.AutoSize = true;
            this.Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Period.Location = new System.Drawing.Point(12, 80);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(155, 20);
            this.Period.TabIndex = 3;
            this.Period.Text = "Период функции = ";
            // 
            // func
            // 
            this.func.AutoSize = true;
            this.func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.func.Location = new System.Drawing.Point(12, 49);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(231, 20);
            this.func.TabIndex = 5;
            this.func.Text = "y = cos(w*Pi/180*x)+random";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Циклическая частота";
            // 
            // W
            // 
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.W.Location = new System.Drawing.Point(193, 20);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(53, 26);
            this.W.TabIndex = 7;
            // 
            // Batchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 212);
            this.Controls.Add(this.W);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.func);
            this.Controls.Add(this.Period);
            this.Controls.Add(this.count);
            this.Name = "Batchform";
            this.Text = "G";
            ((System.ComponentModel.ISupportInitialize)(this.W)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Label Period;
        private System.Windows.Forms.Label func;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown W;
    }
}