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
            this.btn_cos = new System.Windows.Forms.Button();
            this.ln_x = new System.Windows.Forms.Button();
            this.minus_x = new System.Windows.Forms.Button();
            this.abs_x = new System.Windows.Forms.Button();
            this.x_inv = new System.Windows.Forms.Button();
            this.x_pow_2 = new System.Windows.Forms.Button();
            this.rad_x = new System.Windows.Forms.Button();
            this.deg_x = new System.Windows.Forms.Button();
            this.min_x_y = new System.Windows.Forms.Button();
            this.x_pow_y = new System.Windows.Forms.Button();
            this.log_x_y = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(12, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(118, 27);
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
            // btn_cos
            // 
            this.btn_cos.Location = new System.Drawing.Point(93, 82);
            this.btn_cos.Name = "btn_cos";
            this.btn_cos.Size = new System.Drawing.Size(75, 23);
            this.btn_cos.TabIndex = 11;
            this.btn_cos.Text = "cos";
            this.btn_cos.UseVisualStyleBackColor = true;
            this.btn_cos.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // ln_x
            // 
            this.ln_x.Location = new System.Drawing.Point(174, 140);
            this.ln_x.Name = "ln_x";
            this.ln_x.Size = new System.Drawing.Size(75, 23);
            this.ln_x.TabIndex = 12;
            this.ln_x.Text = "ln(x)";
            this.ln_x.UseVisualStyleBackColor = true;
            // 
            // minus_x
            // 
            this.minus_x.Location = new System.Drawing.Point(255, 140);
            this.minus_x.Name = "minus_x";
            this.minus_x.Size = new System.Drawing.Size(75, 23);
            this.minus_x.TabIndex = 13;
            this.minus_x.Text = "-x";
            this.minus_x.UseVisualStyleBackColor = true;
            // 
            // abs_x
            // 
            this.abs_x.Location = new System.Drawing.Point(255, 111);
            this.abs_x.Name = "abs_x";
            this.abs_x.Size = new System.Drawing.Size(75, 23);
            this.abs_x.TabIndex = 14;
            this.abs_x.Text = "abs(x)";
            this.abs_x.UseVisualStyleBackColor = true;
            // 
            // x_inv
            // 
            this.x_inv.Location = new System.Drawing.Point(174, 111);
            this.x_inv.Name = "x_inv";
            this.x_inv.Size = new System.Drawing.Size(75, 23);
            this.x_inv.TabIndex = 15;
            this.x_inv.Text = "1/x";
            this.x_inv.UseVisualStyleBackColor = true;
            // 
            // x_pow_2
            // 
            this.x_pow_2.Location = new System.Drawing.Point(12, 111);
            this.x_pow_2.Name = "x_pow_2";
            this.x_pow_2.Size = new System.Drawing.Size(75, 23);
            this.x_pow_2.TabIndex = 16;
            this.x_pow_2.Text = "x^2";
            this.x_pow_2.UseVisualStyleBackColor = true;
            // 
            // rad_x
            // 
            this.rad_x.Location = new System.Drawing.Point(12, 140);
            this.rad_x.Name = "rad_x";
            this.rad_x.Size = new System.Drawing.Size(75, 23);
            this.rad_x.TabIndex = 17;
            this.rad_x.Text = "rad(x)";
            this.rad_x.UseVisualStyleBackColor = true;
            // 
            // deg_x
            // 
            this.deg_x.Location = new System.Drawing.Point(93, 140);
            this.deg_x.Name = "deg_x";
            this.deg_x.Size = new System.Drawing.Size(75, 23);
            this.deg_x.TabIndex = 18;
            this.deg_x.Text = "deg(x)";
            this.deg_x.UseVisualStyleBackColor = true;
            // 
            // min_x_y
            // 
            this.min_x_y.Location = new System.Drawing.Point(93, 111);
            this.min_x_y.Name = "min_x_y";
            this.min_x_y.Size = new System.Drawing.Size(75, 23);
            this.min_x_y.TabIndex = 19;
            this.min_x_y.Text = "min(x,y)";
            this.min_x_y.UseVisualStyleBackColor = true;
            // 
            // x_pow_y
            // 
            this.x_pow_y.Location = new System.Drawing.Point(174, 82);
            this.x_pow_y.Name = "x_pow_y";
            this.x_pow_y.Size = new System.Drawing.Size(75, 23);
            this.x_pow_y.TabIndex = 20;
            this.x_pow_y.Text = "x^y";
            this.x_pow_y.UseVisualStyleBackColor = true;
            // 
            // log_x_y
            // 
            this.log_x_y.Location = new System.Drawing.Point(255, 82);
            this.log_x_y.Name = "log_x_y";
            this.log_x_y.Size = new System.Drawing.Size(75, 23);
            this.log_x_y.TabIndex = 21;
            this.log_x_y.Text = "log x(y)";
            this.log_x_y.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 289);
            this.Controls.Add(this.log_x_y);
            this.Controls.Add(this.x_pow_y);
            this.Controls.Add(this.min_x_y);
            this.Controls.Add(this.deg_x);
            this.Controls.Add(this.rad_x);
            this.Controls.Add(this.x_pow_2);
            this.Controls.Add(this.x_inv);
            this.Controls.Add(this.abs_x);
            this.Controls.Add(this.minus_x);
            this.Controls.Add(this.ln_x);
            this.Controls.Add(this.btn_cos);
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
        private System.Windows.Forms.Button btn_cos;
        private System.Windows.Forms.Button ln_x;
        private System.Windows.Forms.Button minus_x;
        private System.Windows.Forms.Button abs_x;
        private System.Windows.Forms.Button x_inv;
        private System.Windows.Forms.Button x_pow_2;
        private System.Windows.Forms.Button rad_x;
        private System.Windows.Forms.Button deg_x;
        private System.Windows.Forms.Button min_x_y;
        private System.Windows.Forms.Button x_pow_y;
        private System.Windows.Forms.Button log_x_y;
    }
}

