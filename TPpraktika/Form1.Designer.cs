namespace TPpraktika
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
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.buttonSize = new System.Windows.Forms.Button();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.buttonMethod1 = new System.Windows.Forms.Button();
            this.buttonMethod2 = new System.Windows.Forms.Button();
            this.buttonSetList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonFollow1 = new System.Windows.Forms.Button();
            this.buttonFollow2 = new System.Windows.Forms.Button();
            this.buttonUnfollow1 = new System.Windows.Forms.Button();
            this.buttonUnfollow2 = new System.Windows.Forms.Button();
            this.buttonInvoke1 = new System.Windows.Forms.Button();
            this.buttonInvoke2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxMyNum = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(50, 30);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxSize.TabIndex = 0;
            // 
            // buttonSize
            // 
            this.buttonSize.Location = new System.Drawing.Point(156, 30);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(100, 23);
            this.buttonSize.TabIndex = 1;
            this.buttonSize.Text = "Сгенерировать ";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // textBoxArray
            // 
            this.textBoxArray.Location = new System.Drawing.Point(50, 59);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(303, 20);
            this.textBoxArray.TabIndex = 2;
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Location = new System.Drawing.Point(359, 59);
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(100, 20);
            this.textBoxMethod.TabIndex = 3;
            // 
            // buttonMethod1
            // 
            this.buttonMethod1.Location = new System.Drawing.Point(262, 30);
            this.buttonMethod1.Name = "buttonMethod1";
            this.buttonMethod1.Size = new System.Drawing.Size(75, 23);
            this.buttonMethod1.TabIndex = 4;
            this.buttonMethod1.Text = "Метод1";
            this.buttonMethod1.UseVisualStyleBackColor = true;
            this.buttonMethod1.Click += new System.EventHandler(this.buttonMethod1_Click);
            // 
            // buttonMethod2
            // 
            this.buttonMethod2.Location = new System.Drawing.Point(343, 30);
            this.buttonMethod2.Name = "buttonMethod2";
            this.buttonMethod2.Size = new System.Drawing.Size(75, 23);
            this.buttonMethod2.TabIndex = 5;
            this.buttonMethod2.Text = "Метод2";
            this.buttonMethod2.UseVisualStyleBackColor = true;
            this.buttonMethod2.Click += new System.EventHandler(this.buttonMethod2_Click);
            // 
            // buttonSetList
            // 
            this.buttonSetList.Location = new System.Drawing.Point(50, 85);
            this.buttonSetList.Name = "buttonSetList";
            this.buttonSetList.Size = new System.Drawing.Size(87, 23);
            this.buttonSetList.TabIndex = 6;
            this.buttonSetList.Text = "Создать лист";
            this.buttonSetList.UseVisualStyleBackColor = true;
            this.buttonSetList.Click += new System.EventHandler(this.buttonSetList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(143, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // buttonFollow1
            // 
            this.buttonFollow1.Location = new System.Drawing.Point(278, 85);
            this.buttonFollow1.Name = "buttonFollow1";
            this.buttonFollow1.Size = new System.Drawing.Size(75, 23);
            this.buttonFollow1.TabIndex = 9;
            this.buttonFollow1.Text = "Подписка1";
            this.buttonFollow1.UseVisualStyleBackColor = true;
            this.buttonFollow1.Click += new System.EventHandler(this.buttonFollow1_Click);
            // 
            // buttonFollow2
            // 
            this.buttonFollow2.Location = new System.Drawing.Point(359, 85);
            this.buttonFollow2.Name = "buttonFollow2";
            this.buttonFollow2.Size = new System.Drawing.Size(75, 23);
            this.buttonFollow2.TabIndex = 10;
            this.buttonFollow2.Text = "Подписка2";
            this.buttonFollow2.UseVisualStyleBackColor = true;
            this.buttonFollow2.Click += new System.EventHandler(this.buttonFollow2_Click);
            // 
            // buttonUnfollow1
            // 
            this.buttonUnfollow1.Location = new System.Drawing.Point(278, 114);
            this.buttonUnfollow1.Name = "buttonUnfollow1";
            this.buttonUnfollow1.Size = new System.Drawing.Size(75, 23);
            this.buttonUnfollow1.TabIndex = 11;
            this.buttonUnfollow1.Text = "Отписка1";
            this.buttonUnfollow1.UseVisualStyleBackColor = true;
            this.buttonUnfollow1.Click += new System.EventHandler(this.buttonUnfollow1_Click);
            // 
            // buttonUnfollow2
            // 
            this.buttonUnfollow2.Location = new System.Drawing.Point(359, 114);
            this.buttonUnfollow2.Name = "buttonUnfollow2";
            this.buttonUnfollow2.Size = new System.Drawing.Size(75, 23);
            this.buttonUnfollow2.TabIndex = 12;
            this.buttonUnfollow2.Text = "Отписка2";
            this.buttonUnfollow2.UseVisualStyleBackColor = true;
            this.buttonUnfollow2.Click += new System.EventHandler(this.buttonUnfollow2_Click);
            // 
            // buttonInvoke1
            // 
            this.buttonInvoke1.Location = new System.Drawing.Point(278, 157);
            this.buttonInvoke1.Name = "buttonInvoke1";
            this.buttonInvoke1.Size = new System.Drawing.Size(75, 23);
            this.buttonInvoke1.TabIndex = 13;
            this.buttonInvoke1.Text = "Вызов1";
            this.buttonInvoke1.UseVisualStyleBackColor = true;
            this.buttonInvoke1.Click += new System.EventHandler(this.buttonInvoke1_Click);
            // 
            // buttonInvoke2
            // 
            this.buttonInvoke2.Location = new System.Drawing.Point(359, 157);
            this.buttonInvoke2.Name = "buttonInvoke2";
            this.buttonInvoke2.Size = new System.Drawing.Size(75, 23);
            this.buttonInvoke2.TabIndex = 14;
            this.buttonInvoke2.Text = "Вызов2";
            this.buttonInvoke2.UseVisualStyleBackColor = true;
            this.buttonInvoke2.Click += new System.EventHandler(this.buttonInvoke2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // textBoxMyNum
            // 
            this.textBoxMyNum.Location = new System.Drawing.Point(424, 30);
            this.textBoxMyNum.Name = "textBoxMyNum";
            this.textBoxMyNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxMyNum.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 288);
            this.Controls.Add(this.textBoxMyNum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInvoke2);
            this.Controls.Add(this.buttonInvoke1);
            this.Controls.Add(this.buttonUnfollow2);
            this.Controls.Add(this.buttonUnfollow1);
            this.Controls.Add(this.buttonFollow2);
            this.Controls.Add(this.buttonFollow1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSetList);
            this.Controls.Add(this.buttonMethod2);
            this.Controls.Add(this.buttonMethod1);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.buttonSize);
            this.Controls.Add(this.textBoxSize);
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

        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button buttonSize;
        private System.Windows.Forms.TextBox textBoxArray;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.Button buttonMethod1;
        private System.Windows.Forms.Button buttonMethod2;
        private System.Windows.Forms.Button buttonSetList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonFollow1;
        private System.Windows.Forms.Button buttonFollow2;
        private System.Windows.Forms.Button buttonUnfollow1;
        private System.Windows.Forms.Button buttonUnfollow2;
        private System.Windows.Forms.Button buttonInvoke1;
        private System.Windows.Forms.Button buttonInvoke2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxMyNum;
    }
}

