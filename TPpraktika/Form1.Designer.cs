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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonFollow1 = new System.Windows.Forms.Button();
            this.buttonFollow2 = new System.Windows.Forms.Button();
            this.buttonUnfollow1 = new System.Windows.Forms.Button();
            this.buttonUnfollow2 = new System.Windows.Forms.Button();
            this.buttonInvoke1 = new System.Windows.Forms.Button();
            this.buttonInvoke2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSort = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
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
            this.buttonSize.Location = new System.Drawing.Point(50, 57);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(75, 23);
            this.buttonSize.TabIndex = 1;
            this.buttonSize.Text = "Set Size";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // textBoxArray
            // 
            this.textBoxArray.Location = new System.Drawing.Point(229, 29);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(303, 20);
            this.textBoxArray.TabIndex = 2;
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Location = new System.Drawing.Point(229, 57);
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.Size = new System.Drawing.Size(100, 20);
            this.textBoxMethod.TabIndex = 3;
            // 
            // buttonMethod1
            // 
            this.buttonMethod1.Location = new System.Drawing.Point(335, 55);
            this.buttonMethod1.Name = "buttonMethod1";
            this.buttonMethod1.Size = new System.Drawing.Size(75, 23);
            this.buttonMethod1.TabIndex = 4;
            this.buttonMethod1.Text = "Method1";
            this.buttonMethod1.UseVisualStyleBackColor = true;
            this.buttonMethod1.Click += new System.EventHandler(this.buttonMethod1_Click);
            // 
            // buttonMethod2
            // 
            this.buttonMethod2.Location = new System.Drawing.Point(457, 55);
            this.buttonMethod2.Name = "buttonMethod2";
            this.buttonMethod2.Size = new System.Drawing.Size(75, 23);
            this.buttonMethod2.TabIndex = 5;
            this.buttonMethod2.Text = "Method2";
            this.buttonMethod2.UseVisualStyleBackColor = true;
            this.buttonMethod2.Click += new System.EventHandler(this.buttonMethod2_Click);
            // 
            // buttonSetList
            // 
            this.buttonSetList.Location = new System.Drawing.Point(50, 103);
            this.buttonSetList.Name = "buttonSetList";
            this.buttonSetList.Size = new System.Drawing.Size(75, 23);
            this.buttonSetList.TabIndex = 6;
            this.buttonSetList.Text = "Set List";
            this.buttonSetList.UseVisualStyleBackColor = true;
            this.buttonSetList.Click += new System.EventHandler(this.buttonSetList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(229, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(412, 103);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 8;
            // 
            // buttonFollow1
            // 
            this.buttonFollow1.Location = new System.Drawing.Point(50, 215);
            this.buttonFollow1.Name = "buttonFollow1";
            this.buttonFollow1.Size = new System.Drawing.Size(75, 23);
            this.buttonFollow1.TabIndex = 9;
            this.buttonFollow1.Text = "Follow1";
            this.buttonFollow1.UseVisualStyleBackColor = true;
            this.buttonFollow1.Click += new System.EventHandler(this.buttonFollow1_Click);
            // 
            // buttonFollow2
            // 
            this.buttonFollow2.Location = new System.Drawing.Point(131, 215);
            this.buttonFollow2.Name = "buttonFollow2";
            this.buttonFollow2.Size = new System.Drawing.Size(75, 23);
            this.buttonFollow2.TabIndex = 10;
            this.buttonFollow2.Text = "Follow2";
            this.buttonFollow2.UseVisualStyleBackColor = true;
            this.buttonFollow2.Click += new System.EventHandler(this.buttonFollow2_Click);
            // 
            // buttonUnfollow1
            // 
            this.buttonUnfollow1.Location = new System.Drawing.Point(50, 244);
            this.buttonUnfollow1.Name = "buttonUnfollow1";
            this.buttonUnfollow1.Size = new System.Drawing.Size(75, 23);
            this.buttonUnfollow1.TabIndex = 11;
            this.buttonUnfollow1.Text = "Unfollow1";
            this.buttonUnfollow1.UseVisualStyleBackColor = true;
            this.buttonUnfollow1.Click += new System.EventHandler(this.buttonUnfollow1_Click);
            // 
            // buttonUnfollow2
            // 
            this.buttonUnfollow2.Location = new System.Drawing.Point(131, 244);
            this.buttonUnfollow2.Name = "buttonUnfollow2";
            this.buttonUnfollow2.Size = new System.Drawing.Size(75, 23);
            this.buttonUnfollow2.TabIndex = 12;
            this.buttonUnfollow2.Text = "Unfollow2";
            this.buttonUnfollow2.UseVisualStyleBackColor = true;
            this.buttonUnfollow2.Click += new System.EventHandler(this.buttonUnfollow2_Click);
            // 
            // buttonInvoke1
            // 
            this.buttonInvoke1.Location = new System.Drawing.Point(50, 273);
            this.buttonInvoke1.Name = "buttonInvoke1";
            this.buttonInvoke1.Size = new System.Drawing.Size(75, 23);
            this.buttonInvoke1.TabIndex = 13;
            this.buttonInvoke1.Text = "Invoke1";
            this.buttonInvoke1.UseVisualStyleBackColor = true;
            this.buttonInvoke1.Click += new System.EventHandler(this.buttonInvoke1_Click);
            // 
            // buttonInvoke2
            // 
            this.buttonInvoke2.Location = new System.Drawing.Point(131, 273);
            this.buttonInvoke2.Name = "buttonInvoke2";
            this.buttonInvoke2.Size = new System.Drawing.Size(75, 23);
            this.buttonInvoke2.TabIndex = 14;
            this.buttonInvoke2.Text = "Invoke2";
            this.buttonInvoke2.UseVisualStyleBackColor = true;
            this.buttonInvoke2.Click += new System.EventHandler(this.buttonInvoke2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 215);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(233, 249);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(115, 24);
            this.buttonSort.TabIndex = 17;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(376, 248);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(131, 43);
            this.listBox3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInvoke2);
            this.Controls.Add(this.buttonInvoke1);
            this.Controls.Add(this.buttonUnfollow2);
            this.Controls.Add(this.buttonUnfollow1);
            this.Controls.Add(this.buttonFollow2);
            this.Controls.Add(this.buttonFollow1);
            this.Controls.Add(this.listBox2);
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
        private System.Windows.Forms.ListBox listBox2;
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
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ListBox listBox3;
    }
}

