namespace _3._1F
{
    partial class Form1
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
            this.Вzna = new System.Windows.Forms.Label();
            this.VVod = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Вzna
            // 
            this.Вzna.AutoSize = true;
            this.Вzna.Location = new System.Drawing.Point(23, 87);
            this.Вzna.Name = "Вzna";
            this.Вzna.Size = new System.Drawing.Size(121, 13);
            this.Вzna.TabIndex = 1;
            this.Вzna.Text = "Введи трёх знач число";
            // 
            // VVod
            // 
            this.VVod.Location = new System.Drawing.Point(26, 103);
            this.VVod.Name = "VVod";
            this.VVod.Size = new System.Drawing.Size(118, 20);
            this.VVod.TabIndex = 2;
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(160, 103);
            this.V.Multiline = true;
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Size = new System.Drawing.Size(114, 49);
            this.V.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.V);
            this.Controls.Add(this.VVod);
            this.Controls.Add(this.Вzna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Вzna;
        private System.Windows.Forms.TextBox VVod;
        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.Button button1;
    }
}

