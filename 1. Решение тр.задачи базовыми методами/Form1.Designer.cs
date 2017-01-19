namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.методСеверозапаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методНаименьшейСтоимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методФогеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методСеверозапаToolStripMenuItem,
            this.методНаименьшейСтоимостиToolStripMenuItem,
            this.методФогеляToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(113, 179);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // методСеверозапаToolStripMenuItem
            // 
            this.методСеверозапаToolStripMenuItem.Name = "методСеверозапаToolStripMenuItem";
            this.методСеверозапаToolStripMenuItem.Size = new System.Drawing.Size(219, 23);
            this.методСеверозапаToolStripMenuItem.Text = "Метод северо-западного угла";
            this.методСеверозапаToolStripMenuItem.Click += new System.EventHandler(this.методСеверозапаToolStripMenuItem_Click);
            // 
            // методНаименьшейСтоимостиToolStripMenuItem
            // 
            this.методНаименьшейСтоимостиToolStripMenuItem.Name = "методНаименьшейСтоимостиToolStripMenuItem";
            this.методНаименьшейСтоимостиToolStripMenuItem.Size = new System.Drawing.Size(230, 23);
            this.методНаименьшейСтоимостиToolStripMenuItem.Text = "Метод наименьшей стоимости";
            this.методНаименьшейСтоимостиToolStripMenuItem.Click += new System.EventHandler(this.методНаименьшейСтоимостиToolStripMenuItem_Click);
            // 
            // методФогеляToolStripMenuItem
            // 
            this.методФогеляToolStripMenuItem.Name = "методФогеляToolStripMenuItem";
            this.методФогеляToolStripMenuItem.Size = new System.Drawing.Size(118, 23);
            this.методФогеляToolStripMenuItem.Text = "Метод Фогеля";
            this.методФогеляToolStripMenuItem.Click += new System.EventHandler(this.методФогеляToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лабораторная работа №1\r\nпо транспортной логистике";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(369, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Методы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(293, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "РЕШЕНИЕ ТРАНСПОРНОЙ ЗАДАЧИ\r\nБАЗОВЫМИ МЕТОДАМИ\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(687, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 57);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выполнила: студентка группы\r\n                     СТС-302\r\n                     Ч" +
                "увилина Мария";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem методСеверозапаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методНаименьшейСтоимостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методФогеляToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

