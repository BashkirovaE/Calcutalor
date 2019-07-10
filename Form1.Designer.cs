namespace ObjectOrientedCalculator
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_sin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(15, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(119, 27);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(225, 27);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(105, 20);
            this.txtRes.TabIndex = 2;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(9, 11);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(97, 13);
            this.lbA.TabIndex = 3;
            this.lbA.Text = "Первый аргумент";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(116, 11);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(93, 13);
            this.lbB.TabIndex = 4;
            this.lbB.Text = "Второй аргумент";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(222, 11);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(59, 13);
            this.lbC.TabIndex = 5;
            this.lbC.Text = "Результат";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 53);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(93, 53);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(174, 53);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(75, 23);
            this.btn_mul.TabIndex = 8;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(255, 53);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 9;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_sin
            // 
            this.btn_sin.Location = new System.Drawing.Point(12, 82);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(75, 23);
            this.btn_sin.TabIndex = 10;
            this.btn_sin.Text = "sin";
            this.btn_sin.UseVisualStyleBackColor = true;
            this.btn_sin.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 121);
            this.Controls.Add(this.btn_sin);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_sin;
    }
}

