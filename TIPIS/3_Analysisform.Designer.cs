namespace TIPIS
{
    partial class Analysisform
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
            this.Y_Out = new System.Windows.Forms.Label();
            this.T_Out = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Y_Out
            // 
            this.Y_Out.AutoSize = true;
            this.Y_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y_Out.Location = new System.Drawing.Point(13, 13);
            this.Y_Out.Name = "Y_Out";
            this.Y_Out.Size = new System.Drawing.Size(84, 20);
            this.Y_Out.TabIndex = 0;
            this.Y_Out.Text = "Массив Y:";
            // 
            // T_Out
            // 
            this.T_Out.AutoSize = true;
            this.T_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T_Out.Location = new System.Drawing.Point(13, 43);
            this.T_Out.Name = "T_Out";
            this.T_Out.Size = new System.Drawing.Size(82, 20);
            this.T_Out.TabIndex = 1;
            this.T_Out.Text = "Массив T:";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(12, 104);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(283, 20);
            this.Output.TabIndex = 2;
            this.Output.Text = "Апроксимация массивов данных";
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.Location = new System.Drawing.Point(17, 157);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(113, 29);
            this.counter.TabIndex = 3;
            this.counter.Text = "Рассчитать";
            this.counter.UseVisualStyleBackColor = true;
            this.counter.Click += new System.EventHandler(this.counter_Click);
            // 
            // Analysisform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 282);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.T_Out);
            this.Controls.Add(this.Y_Out);
            this.Name = "Analysisform";
            this.Text = "Analysisform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Y_Out;
        private System.Windows.Forms.Label T_Out;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button counter;
    }
}