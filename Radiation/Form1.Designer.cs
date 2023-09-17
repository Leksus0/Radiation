namespace Radiation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.методичкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыДляРасчетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cправкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_1,
            this.справочнаяИнформацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_1
            // 
            this.ToolStripMenuItem_1.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методичкаToolStripMenuItem});
            this.ToolStripMenuItem_1.Font = new System.Drawing.Font("STXihei", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItem_1.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItem_1.Name = "ToolStripMenuItem_1";
            this.ToolStripMenuItem_1.Size = new System.Drawing.Size(170, 23);
            this.ToolStripMenuItem_1.Text = "Общие сведения";
            // 
            // методичкаToolStripMenuItem
            // 
            this.методичкаToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.методичкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.методичкаToolStripMenuItem.Name = "методичкаToolStripMenuItem";
            this.методичкаToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.методичкаToolStripMenuItem.Text = "Методичка";
            this.методичкаToolStripMenuItem.Click += new System.EventHandler(this.методичкаToolStripMenuItem_Click);
            // 
            // справочнаяИнформацияToolStripMenuItem
            // 
            this.справочнаяИнформацияToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.справочнаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыДляРасчетовToolStripMenuItem,
            this.cправкаToolStripMenuItem});
            this.справочнаяИнформацияToolStripMenuItem.Font = new System.Drawing.Font("STXihei", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справочнаяИнформацияToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.справочнаяИнформацияToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Gray;
            this.справочнаяИнформацияToolStripMenuItem.Name = "справочнаяИнформацияToolStripMenuItem";
            this.справочнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(249, 23);
            this.справочнаяИнформацияToolStripMenuItem.Text = "Справочная информация";
            // 
            // таблицыДляРасчетовToolStripMenuItem
            // 
            this.таблицыДляРасчетовToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.таблицыДляРасчетовToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.таблицыДляРасчетовToolStripMenuItem.Name = "таблицыДляРасчетовToolStripMenuItem";
            this.таблицыДляРасчетовToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.таблицыДляРасчетовToolStripMenuItem.Text = "Таблицы для расчетов";
            this.таблицыДляРасчетовToolStripMenuItem.Click += new System.EventHandler(this.таблицыДляРасчетовToolStripMenuItem_Click);
            // 
            // cправкаToolStripMenuItem
            // 
            this.cправкаToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cправкаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cправкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cправкаToolStripMenuItem.Name = "cправкаToolStripMenuItem";
            this.cправкаToolStripMenuItem.Size = new System.Drawing.Size(272, 24);
            this.cправкаToolStripMenuItem.Text = "Cправка";
            this.cправкаToolStripMenuItem.Click += new System.EventHandler(this.cправкаToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("STXihei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(398, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Начать работу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("STXihei", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(694, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Проверить работу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Radiation.Properties.Resources.glavny_ekran__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1003, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Радиация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_1;
        private System.Windows.Forms.ToolStripMenuItem методичкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыДляРасчетовToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem cправкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

