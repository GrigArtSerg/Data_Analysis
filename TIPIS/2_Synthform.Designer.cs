namespace TIPIS
{
    partial class Synthform
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
            this.mas1a = new System.Windows.Forms.Label();
            this.mas1b = new System.Windows.Forms.Label();
            this.out1 = new System.Windows.Forms.Label();
            this.out2 = new System.Windows.Forms.Label();
            this.mas2b = new System.Windows.Forms.Label();
            this.mas2a = new System.Windows.Forms.Label();
            this.out3 = new System.Windows.Forms.Label();
            this.mas3b = new System.Windows.Forms.Label();
            this.mas3a = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mas1a
            // 
            this.mas1a.AutoSize = true;
            this.mas1a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mas1a.Location = new System.Drawing.Point(13, 15);
            this.mas1a.Name = "mas1a";
            this.mas1a.Size = new System.Drawing.Size(69, 17);
            this.mas1a.TabIndex = 0;
            this.mas1a.Text = "Массив А";
            // 
            // mas1b
            // 
            this.mas1b.AutoSize = true;
            this.mas1b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mas1b.Location = new System.Drawing.Point(13, 40);
            this.mas1b.Name = "mas1b";
            this.mas1b.Size = new System.Drawing.Size(69, 17);
            this.mas1b.TabIndex = 1;
            this.mas1b.Text = "Массив Б";
            // 
            // out1
            // 
            this.out1.AutoSize = true;
            this.out1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.out1.Location = new System.Drawing.Point(13, 65);
            this.out1.Name = "out1";
            this.out1.Size = new System.Drawing.Size(351, 17);
            this.out1.TabIndex = 2;
            this.out1.Text = "Коэффициент корреляции между массивами равен ";
            // 
            // out2
            // 
            this.out2.AutoSize = true;
            this.out2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.out2.Location = new System.Drawing.Point(13, 140);
            this.out2.Name = "out2";
            this.out2.Size = new System.Drawing.Size(351, 17);
            this.out2.TabIndex = 5;
            this.out2.Text = "Коэффициент корреляции между массивами равен ";
            // 
            // mas2b
            // 
            this.mas2b.AutoSize = true;
            this.mas2b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mas2b.Location = new System.Drawing.Point(13, 115);
            this.mas2b.Name = "mas2b";
            this.mas2b.Size = new System.Drawing.Size(69, 17);
            this.mas2b.TabIndex = 4;
            this.mas2b.Text = "Массив Б";
            // 
            // mas2a
            // 
            this.mas2a.AutoSize = true;
            this.mas2a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mas2a.Location = new System.Drawing.Point(13, 90);
            this.mas2a.Name = "mas2a";
            this.mas2a.Size = new System.Drawing.Size(69, 17);
            this.mas2a.TabIndex = 3;
            this.mas2a.Text = "Массив А";
            // 
            // out3
            // 
            this.out3.AutoSize = true;
            this.out3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.out3.Location = new System.Drawing.Point(13, 215);
            this.out3.Name = "out3";
            this.out3.Size = new System.Drawing.Size(351, 17);
            this.out3.TabIndex = 8;
            this.out3.Text = "Коэффициент корреляции между массивами равен ";
            // 
            // mas3b
            // 
            this.mas3b.AutoSize = true;
            this.mas3b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mas3b.Location = new System.Drawing.Point(13, 190);
            this.mas3b.Name = "mas3b";
            this.mas3b.Size = new System.Drawing.Size(69, 17);
            this.mas3b.TabIndex = 7;
            this.mas3b.Text = "Массив Б";
            // 
            // mas3a
            // 
            this.mas3a.AutoSize = true;
            this.mas3a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mas3a.Location = new System.Drawing.Point(13, 165);
            this.mas3a.Name = "mas3a";
            this.mas3a.Size = new System.Drawing.Size(69, 17);
            this.mas3a.TabIndex = 6;
            this.mas3a.Text = "Массив А";
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(16, 240);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(95, 27);
            this.count.TabIndex = 9;
            this.count.Text = "Рассчитать";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // Synthform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 312);
            this.Controls.Add(this.count);
            this.Controls.Add(this.out3);
            this.Controls.Add(this.mas3b);
            this.Controls.Add(this.mas3a);
            this.Controls.Add(this.out2);
            this.Controls.Add(this.mas2b);
            this.Controls.Add(this.mas2a);
            this.Controls.Add(this.out1);
            this.Controls.Add(this.mas1b);
            this.Controls.Add(this.mas1a);
            this.Name = "Synthform";
            this.Text = "Synthform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mas1a;
        private System.Windows.Forms.Label mas1b;
        private System.Windows.Forms.Label out1;
        private System.Windows.Forms.Label out2;
        private System.Windows.Forms.Label mas2b;
        private System.Windows.Forms.Label mas2a;
        private System.Windows.Forms.Label out3;
        private System.Windows.Forms.Label mas3b;
        private System.Windows.Forms.Label mas3a;
        private System.Windows.Forms.Button count;
    }
}