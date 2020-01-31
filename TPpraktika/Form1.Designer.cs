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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonMethod2);
            this.Controls.Add(this.buttonMethod1);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.buttonSize);
            this.Controls.Add(this.textBoxSize);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

