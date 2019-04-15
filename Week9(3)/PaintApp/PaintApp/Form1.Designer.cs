namespace PaintApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PenBtn = new System.Windows.Forms.Button();
            this.LineBtn = new System.Windows.Forms.Button();
            this.RecBtn = new System.Windows.Forms.Button();
            this.EllipseBtn = new System.Windows.Forms.Button();
            this.FillBtn = new System.Windows.Forms.Button();
            this.Fill2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EraserBtn = new System.Windows.Forms.Button();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.Pipette = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Star = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(90, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1127, 455);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // PenBtn
            // 
            this.PenBtn.Location = new System.Drawing.Point(12, 66);
            this.PenBtn.Name = "PenBtn";
            this.PenBtn.Size = new System.Drawing.Size(72, 40);
            this.PenBtn.TabIndex = 1;
            this.PenBtn.Text = "PenBtn";
            this.PenBtn.UseVisualStyleBackColor = true;
            this.PenBtn.Click += new System.EventHandler(this.PenBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.Location = new System.Drawing.Point(12, 190);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(72, 40);
            this.LineBtn.TabIndex = 2;
            this.LineBtn.Text = "LineBtn";
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // RecBtn
            // 
            this.RecBtn.Location = new System.Drawing.Point(12, 236);
            this.RecBtn.Name = "RecBtn";
            this.RecBtn.Size = new System.Drawing.Size(72, 40);
            this.RecBtn.TabIndex = 3;
            this.RecBtn.Text = "RecBtn";
            this.RecBtn.UseVisualStyleBackColor = true;
            this.RecBtn.Click += new System.EventHandler(this.RecBtn_Click);
            // 
            // EllipseBtn
            // 
            this.EllipseBtn.Location = new System.Drawing.Point(12, 282);
            this.EllipseBtn.Name = "EllipseBtn";
            this.EllipseBtn.Size = new System.Drawing.Size(72, 40);
            this.EllipseBtn.TabIndex = 4;
            this.EllipseBtn.Text = "EllipseBtn";
            this.EllipseBtn.UseVisualStyleBackColor = true;
            this.EllipseBtn.Click += new System.EventHandler(this.EllipseBtn_Click);
            // 
            // FillBtn
            // 
            this.FillBtn.Location = new System.Drawing.Point(12, 442);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(72, 33);
            this.FillBtn.TabIndex = 5;
            this.FillBtn.Text = "Fill";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // Fill2
            // 
            this.Fill2.Location = new System.Drawing.Point(12, 481);
            this.Fill2.Name = "Fill2";
            this.Fill2.Size = new System.Drawing.Size(72, 40);
            this.Fill2.TabIndex = 6;
            this.Fill2.Text = "Fill2";
            this.Fill2.UseVisualStyleBackColor = true;
            this.Fill2.Click += new System.EventHandler(this.Fill2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.FileOpenMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.FileSaveMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.FromColorDialogToolStripMenuItem_Click);
            // 
            // EraserBtn
            // 
            this.EraserBtn.Location = new System.Drawing.Point(12, 108);
            this.EraserBtn.Name = "EraserBtn";
            this.EraserBtn.Size = new System.Drawing.Size(72, 40);
            this.EraserBtn.TabIndex = 8;
            this.EraserBtn.Text = "EraserBtn";
            this.EraserBtn.UseVisualStyleBackColor = true;
            this.EraserBtn.Click += new System.EventHandler(this.EraserBtn_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(252, 30);
            this.toolStripMenuItem2.Text = "+";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SizePlusMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(252, 30);
            this.toolStripMenuItem5.Text = "--";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.SizeMinusMenuItem_Click);
            // 
            // Pipette
            // 
            this.Pipette.Location = new System.Drawing.Point(12, 151);
            this.Pipette.Name = "Pipette";
            this.Pipette.Size = new System.Drawing.Size(72, 33);
            this.Pipette.TabIndex = 9;
            this.Pipette.Text = "Pipette";
            this.Pipette.UseVisualStyleBackColor = true;
            this.Pipette.Click += new System.EventHandler(this.PipetteBtn_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(12, 328);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(72, 32);
            this.Triangle.TabIndex = 10;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.TriangleBtn_Click);
            // 
            // Star
            // 
            this.Star.Location = new System.Drawing.Point(12, 366);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(75, 36);
            this.Star.TabIndex = 11;
            this.Star.Text = "Star";
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.StarBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 533);
            this.Controls.Add(this.Star);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Pipette);
            this.Controls.Add(this.EraserBtn);
            this.Controls.Add(this.Fill2);
            this.Controls.Add(this.FillBtn);
            this.Controls.Add(this.EllipseBtn);
            this.Controls.Add(this.RecBtn);
            this.Controls.Add(this.LineBtn);
            this.Controls.Add(this.PenBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PenBtn;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Button RecBtn;
        private System.Windows.Forms.Button EllipseBtn;
        private System.Windows.Forms.Button FillBtn;
        private System.Windows.Forms.Button Fill2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.Button EraserBtn;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button Pipette;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Star;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

