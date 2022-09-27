namespace TIPIS
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Stabilization = new System.Windows.Forms.Button();
            this.Synthesis = new System.Windows.Forms.Button();
            this.Analysis = new System.Windows.Forms.Button();
            this.Optimization = new System.Windows.Forms.Button();
            this.Batch_processes = new System.Windows.Forms.Button();
            this.AA_model = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stabilization
            // 
            this.Stabilization.Location = new System.Drawing.Point(118, 14);
            this.Stabilization.Name = "Stabilization";
            this.Stabilization.Size = new System.Drawing.Size(224, 23);
            this.Stabilization.TabIndex = 0;
            this.Stabilization.Text = "Стабилизация";
            this.Stabilization.UseVisualStyleBackColor = true;
            this.Stabilization.Click += new System.EventHandler(this.Stabilization_Click);
            // 
            // Synthesis
            // 
            this.Synthesis.Location = new System.Drawing.Point(118, 43);
            this.Synthesis.Name = "Synthesis";
            this.Synthesis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Synthesis.Size = new System.Drawing.Size(224, 23);
            this.Synthesis.TabIndex = 1;
            this.Synthesis.Text = "Синтез";
            this.Synthesis.UseVisualStyleBackColor = true;
            this.Synthesis.Click += new System.EventHandler(this.Synthesis_Click);
            // 
            // Analysis
            // 
            this.Analysis.Location = new System.Drawing.Point(118, 72);
            this.Analysis.Name = "Analysis";
            this.Analysis.Size = new System.Drawing.Size(224, 23);
            this.Analysis.TabIndex = 2;
            this.Analysis.Text = "Анализ";
            this.Analysis.UseVisualStyleBackColor = true;
            this.Analysis.Click += new System.EventHandler(this.Analysis_Click);
            // 
            // Optimization
            // 
            this.Optimization.Location = new System.Drawing.Point(118, 101);
            this.Optimization.Name = "Optimization";
            this.Optimization.Size = new System.Drawing.Size(224, 23);
            this.Optimization.TabIndex = 3;
            this.Optimization.Text = "Оптимизация";
            this.Optimization.UseVisualStyleBackColor = true;
            this.Optimization.Click += new System.EventHandler(this.Optimization_Click);
            // 
            // Batch_processes
            // 
            this.Batch_processes.Location = new System.Drawing.Point(118, 130);
            this.Batch_processes.Name = "Batch_processes";
            this.Batch_processes.Size = new System.Drawing.Size(224, 23);
            this.Batch_processes.TabIndex = 4;
            this.Batch_processes.Text = "Периодические процессы";
            this.Batch_processes.UseVisualStyleBackColor = true;
            this.Batch_processes.Click += new System.EventHandler(this.Batch_processes_Click);
            // 
            // AA_model
            // 
            this.AA_model.Location = new System.Drawing.Point(118, 159);
            this.AA_model.Name = "AA_model";
            this.AA_model.Size = new System.Drawing.Size(224, 23);
            this.AA_model.TabIndex = 5;
            this.AA_model.Text = "Адаптивно-аналитические процессы";
            this.AA_model.UseVisualStyleBackColor = true;
            this.AA_model.Click += new System.EventHandler(this.AA_model_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 194);
            this.Controls.Add(this.AA_model);
            this.Controls.Add(this.Batch_processes);
            this.Controls.Add(this.Optimization);
            this.Controls.Add(this.Analysis);
            this.Controls.Add(this.Synthesis);
            this.Controls.Add(this.Stabilization);
            this.Name = "Main";
            this.Text = "TIPIS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Stabilization;
        private System.Windows.Forms.Button Synthesis;
        private System.Windows.Forms.Button Analysis;
        private System.Windows.Forms.Button Optimization;
        private System.Windows.Forms.Button Batch_processes;
        private System.Windows.Forms.Button AA_model;
    }
}

