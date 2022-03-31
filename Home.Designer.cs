
namespace Testing_ProjectPractice_KAS
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EasyButton = new System.Windows.Forms.Button();
            this.MiddleButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Программа тестирования по английскому языку";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(109, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Для того, чтобы начать тестирование, выберите 1 из уровней сложности. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EasyButton
            // 
            this.EasyButton.BackColor = System.Drawing.Color.LawnGreen;
            this.EasyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EasyButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EasyButton.Location = new System.Drawing.Point(23, 308);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(139, 35);
            this.EasyButton.TabIndex = 2;
            this.EasyButton.Text = "Легкий";
            this.EasyButton.UseVisualStyleBackColor = false;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // MiddleButton
            // 
            this.MiddleButton.BackColor = System.Drawing.Color.Yellow;
            this.MiddleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.MiddleButton.Location = new System.Drawing.Point(220, 308);
            this.MiddleButton.Name = "MiddleButton";
            this.MiddleButton.Size = new System.Drawing.Size(147, 35);
            this.MiddleButton.TabIndex = 3;
            this.MiddleButton.Text = "Средний";
            this.MiddleButton.UseVisualStyleBackColor = false;
            this.MiddleButton.Click += new System.EventHandler(this.MiddleButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.BackColor = System.Drawing.Color.OrangeRed;
            this.HardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HardButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.HardButton.Location = new System.Drawing.Point(422, 308);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(120, 35);
            this.HardButton.TabIndex = 4;
            this.HardButton.Text = "Сложный";
            this.HardButton.UseVisualStyleBackColor = false;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Lavender;
            this.ExitButton.Location = new System.Drawing.Point(439, 488);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(153, 31);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выйти из программы";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 531);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.MiddleButton);
            this.Controls.Add(this.EasyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование по английскому языку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button MiddleButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

