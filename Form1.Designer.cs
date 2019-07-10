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
            this.btn_lnx = new System.Windows.Forms.Button();
            this.btn_negativex = new System.Windows.Forms.Button();
            this.btn_absx = new System.Windows.Forms.Button();
            this.btn_1divx = new System.Windows.Forms.Button();
            this.btn_xpow2 = new System.Windows.Forms.Button();
            this.btn_radx = new System.Windows.Forms.Button();
            this.btn_degx = new System.Windows.Forms.Button();
            this.btn_minxy = new System.Windows.Forms.Button();
            this.btn_xpowy = new System.Windows.Forms.Button();
            this.btn_logxy = new System.Windows.Forms.Button();
            this.btn_tan = new System.Windows.Forms.Button();
            this.btn_ctan = new System.Windows.Forms.Button();
            this.btn_asin = new System.Windows.Forms.Button();
            this.btn_acos = new System.Windows.Forms.Button();
            this.btn_atan = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_divxony = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_average = new System.Windows.Forms.Button();
            this.btn_geometric = new System.Windows.Forms.Button();
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
            // btn_lnx
            // 
            this.btn_lnx.Location = new System.Drawing.Point(174, 140);
            this.btn_lnx.Name = "btn_lnx";
            this.btn_lnx.Size = new System.Drawing.Size(75, 23);
            this.btn_lnx.TabIndex = 12;
            this.btn_lnx.Text = "ln(x)";
            this.btn_lnx.UseVisualStyleBackColor = true;
            this.btn_lnx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_negativex
            // 
            this.btn_negativex.Location = new System.Drawing.Point(255, 140);
            this.btn_negativex.Name = "btn_negativex";
            this.btn_negativex.Size = new System.Drawing.Size(75, 23);
            this.btn_negativex.TabIndex = 13;
            this.btn_negativex.Text = "-x";
            this.btn_negativex.UseVisualStyleBackColor = true;
            this.btn_negativex.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_absx
            // 
            this.btn_absx.Location = new System.Drawing.Point(255, 111);
            this.btn_absx.Name = "btn_absx";
            this.btn_absx.Size = new System.Drawing.Size(75, 23);
            this.btn_absx.TabIndex = 14;
            this.btn_absx.Text = "abs(x)";
            this.btn_absx.UseVisualStyleBackColor = true;
            this.btn_absx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_1divx
            // 
            this.btn_1divx.Location = new System.Drawing.Point(174, 111);
            this.btn_1divx.Name = "btn_1divx";
            this.btn_1divx.Size = new System.Drawing.Size(75, 23);
            this.btn_1divx.TabIndex = 15;
            this.btn_1divx.Text = "1/x";
            this.btn_1divx.UseVisualStyleBackColor = true;
            this.btn_1divx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_xpow2
            // 
            this.btn_xpow2.Location = new System.Drawing.Point(93, 111);
            this.btn_xpow2.Name = "btn_xpow2";
            this.btn_xpow2.Size = new System.Drawing.Size(75, 23);
            this.btn_xpow2.TabIndex = 16;
            this.btn_xpow2.Text = "x^2";
            this.btn_xpow2.UseVisualStyleBackColor = true;
            this.btn_xpow2.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_radx
            // 
            this.btn_radx.Location = new System.Drawing.Point(12, 140);
            this.btn_radx.Name = "btn_radx";
            this.btn_radx.Size = new System.Drawing.Size(75, 23);
            this.btn_radx.TabIndex = 17;
            this.btn_radx.Text = "rad(x)";
            this.btn_radx.UseVisualStyleBackColor = true;
            this.btn_radx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_degx
            // 
            this.btn_degx.Location = new System.Drawing.Point(93, 140);
            this.btn_degx.Name = "btn_degx";
            this.btn_degx.Size = new System.Drawing.Size(75, 23);
            this.btn_degx.TabIndex = 18;
            this.btn_degx.Text = "deg(x)";
            this.btn_degx.UseVisualStyleBackColor = true;
            this.btn_degx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_minxy
            // 
            this.btn_minxy.Location = new System.Drawing.Point(12, 111);
            this.btn_minxy.Name = "btn_minxy";
            this.btn_minxy.Size = new System.Drawing.Size(75, 23);
            this.btn_minxy.TabIndex = 19;
            this.btn_minxy.Text = "min(x,y)";
            this.btn_minxy.UseVisualStyleBackColor = true;
            this.btn_minxy.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_xpowy
            // 
            this.btn_xpowy.Location = new System.Drawing.Point(174, 82);
            this.btn_xpowy.Name = "btn_xpowy";
            this.btn_xpowy.Size = new System.Drawing.Size(75, 23);
            this.btn_xpowy.TabIndex = 20;
            this.btn_xpowy.Text = "x^y";
            this.btn_xpowy.UseVisualStyleBackColor = true;
            this.btn_xpowy.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_logxy
            // 
            this.btn_logxy.Location = new System.Drawing.Point(255, 82);
            this.btn_logxy.Name = "btn_logxy";
            this.btn_logxy.Size = new System.Drawing.Size(75, 23);
            this.btn_logxy.TabIndex = 21;
            this.btn_logxy.Text = "log x(y)";
            this.btn_logxy.UseVisualStyleBackColor = true;
            this.btn_logxy.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_tan
            // 
            this.btn_tan.Location = new System.Drawing.Point(12, 169);
            this.btn_tan.Name = "btn_tan";
            this.btn_tan.Size = new System.Drawing.Size(75, 23);
            this.btn_tan.TabIndex = 22;
            this.btn_tan.Text = "tan";
            this.btn_tan.UseVisualStyleBackColor = true;
            this.btn_tan.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_ctan
            // 
            this.btn_ctan.Location = new System.Drawing.Point(93, 169);
            this.btn_ctan.Name = "btn_ctan";
            this.btn_ctan.Size = new System.Drawing.Size(75, 23);
            this.btn_ctan.TabIndex = 23;
            this.btn_ctan.Text = "ctan";
            this.btn_ctan.UseVisualStyleBackColor = true;
            this.btn_ctan.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_asin
            // 
            this.btn_asin.Location = new System.Drawing.Point(174, 169);
            this.btn_asin.Name = "btn_asin";
            this.btn_asin.Size = new System.Drawing.Size(75, 23);
            this.btn_asin.TabIndex = 25;
            this.btn_asin.Text = "arcsin";
            this.btn_asin.UseVisualStyleBackColor = true;
            this.btn_asin.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_acos
            // 
            this.btn_acos.Location = new System.Drawing.Point(253, 169);
            this.btn_acos.Name = "btn_acos";
            this.btn_acos.Size = new System.Drawing.Size(75, 23);
            this.btn_acos.TabIndex = 26;
            this.btn_acos.Text = "arccos";
            this.btn_acos.UseVisualStyleBackColor = true;
            this.btn_acos.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_atan
            // 
            this.btn_atan.Location = new System.Drawing.Point(12, 198);
            this.btn_atan.Name = "btn_atan";
            this.btn_atan.Size = new System.Drawing.Size(75, 23);
            this.btn_atan.TabIndex = 27;
            this.btn_atan.Text = "arctan";
            this.btn_atan.UseVisualStyleBackColor = true;
            this.btn_atan.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(93, 198);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 23);
            this.btn_mod.TabIndex = 28;
            this.btn_mod.Text = "mod";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_divxony
            // 
            this.btn_divxony.Location = new System.Drawing.Point(174, 198);
            this.btn_divxony.Name = "btn_divxony";
            this.btn_divxony.Size = new System.Drawing.Size(75, 23);
            this.btn_divxony.TabIndex = 29;
            this.btn_divxony.Text = "div";
            this.btn_divxony.UseVisualStyleBackColor = true;
            this.btn_divxony.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(253, 198);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(75, 23);
            this.btn_max.TabIndex = 30;
            this.btn_max.Text = "max(x,y)";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_average
            // 
            this.btn_average.Location = new System.Drawing.Point(93, 227);
            this.btn_average.Name = "btn_average";
            this.btn_average.Size = new System.Drawing.Size(75, 23);
            this.btn_average.TabIndex = 31;
            this.btn_average.Text = "average";
            this.btn_average.UseVisualStyleBackColor = true;
            this.btn_average.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // btn_geometric
            // 
            this.btn_geometric.Location = new System.Drawing.Point(174, 227);
            this.btn_geometric.Name = "btn_geometric";
            this.btn_geometric.Size = new System.Drawing.Size(75, 23);
            this.btn_geometric.TabIndex = 32;
            this.btn_geometric.Text = "geometric";
            this.btn_geometric.UseVisualStyleBackColor = true;
            this.btn_geometric.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.btn_geometric);
            this.Controls.Add(this.btn_average);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_divxony);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_atan);
            this.Controls.Add(this.btn_acos);
            this.Controls.Add(this.btn_asin);
            this.Controls.Add(this.btn_ctan);
            this.Controls.Add(this.btn_tan);
            this.Controls.Add(this.btn_logxy);
            this.Controls.Add(this.btn_xpowy);
            this.Controls.Add(this.btn_minxy);
            this.Controls.Add(this.btn_degx);
            this.Controls.Add(this.btn_radx);
            this.Controls.Add(this.btn_xpow2);
            this.Controls.Add(this.btn_1divx);
            this.Controls.Add(this.btn_absx);
            this.Controls.Add(this.btn_negativex);
            this.Controls.Add(this.btn_lnx);
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
        private System.Windows.Forms.Button btn_lnx;
        private System.Windows.Forms.Button btn_negativex;
        private System.Windows.Forms.Button btn_absx;
        private System.Windows.Forms.Button btn_1divx;
        private System.Windows.Forms.Button btn_xpow2;
        private System.Windows.Forms.Button btn_radx;
        private System.Windows.Forms.Button btn_degx;
        private System.Windows.Forms.Button btn_minxy;
        private System.Windows.Forms.Button btn_xpowy;
        private System.Windows.Forms.Button btn_logxy;
        private System.Windows.Forms.Button btn_tan;
        private System.Windows.Forms.Button btn_ctan;
        private System.Windows.Forms.Button btn_asin;
        private System.Windows.Forms.Button btn_acos;
        private System.Windows.Forms.Button btn_atan;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_divxony;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_average;
        private System.Windows.Forms.Button btn_geometric;
    }
}

