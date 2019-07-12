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
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.lnx = new System.Windows.Forms.Button();
            this.negativex = new System.Windows.Forms.Button();
            this.absx = new System.Windows.Forms.Button();
            this.onedivx = new System.Windows.Forms.Button();
            this.xpow2 = new System.Windows.Forms.Button();
            this.radx = new System.Windows.Forms.Button();
            this.degx = new System.Windows.Forms.Button();
            this.minxy = new System.Windows.Forms.Button();
            this.xpowy = new System.Windows.Forms.Button();
            this.logxy = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.ctan = new System.Windows.Forms.Button();
            this.asin = new System.Windows.Forms.Button();
            this.acos = new System.Windows.Forms.Button();
            this.atan = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.divxony = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.geometric = new System.Windows.Forms.Button();
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
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 53);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 6;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(93, 53);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 7;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(174, 53);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 23);
            this.mul.TabIndex = 8;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(255, 53);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 9;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(12, 82);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 10;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(93, 82);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 11;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // lnx
            // 
            this.lnx.Location = new System.Drawing.Point(174, 140);
            this.lnx.Name = "lnx";
            this.lnx.Size = new System.Drawing.Size(75, 23);
            this.lnx.TabIndex = 12;
            this.lnx.Text = "ln(x)";
            this.lnx.UseVisualStyleBackColor = true;
            this.lnx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // negativex
            // 
            this.negativex.Location = new System.Drawing.Point(255, 140);
            this.negativex.Name = "negativex";
            this.negativex.Size = new System.Drawing.Size(75, 23);
            this.negativex.TabIndex = 13;
            this.negativex.Text = "-x";
            this.negativex.UseVisualStyleBackColor = true;
            this.negativex.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // absx
            // 
            this.absx.Location = new System.Drawing.Point(255, 111);
            this.absx.Name = "absx";
            this.absx.Size = new System.Drawing.Size(75, 23);
            this.absx.TabIndex = 14;
            this.absx.Text = "abs(x)";
            this.absx.UseVisualStyleBackColor = true;
            this.absx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // onedivx
            // 
            this.onedivx.Location = new System.Drawing.Point(174, 111);
            this.onedivx.Name = "onedivx";
            this.onedivx.Size = new System.Drawing.Size(75, 23);
            this.onedivx.TabIndex = 15;
            this.onedivx.Text = "1/x";
            this.onedivx.UseVisualStyleBackColor = true;
            this.onedivx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // xpow2
            // 
            this.xpow2.Location = new System.Drawing.Point(93, 111);
            this.xpow2.Name = "xpow2";
            this.xpow2.Size = new System.Drawing.Size(75, 23);
            this.xpow2.TabIndex = 16;
            this.xpow2.Text = "x^2";
            this.xpow2.UseVisualStyleBackColor = true;
            this.xpow2.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // radx
            // 
            this.radx.Location = new System.Drawing.Point(12, 140);
            this.radx.Name = "radx";
            this.radx.Size = new System.Drawing.Size(75, 23);
            this.radx.TabIndex = 17;
            this.radx.Text = "rad(x)";
            this.radx.UseVisualStyleBackColor = true;
            this.radx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // degx
            // 
            this.degx.Location = new System.Drawing.Point(93, 140);
            this.degx.Name = "degx";
            this.degx.Size = new System.Drawing.Size(75, 23);
            this.degx.TabIndex = 18;
            this.degx.Text = "deg(x)";
            this.degx.UseVisualStyleBackColor = true;
            this.degx.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // minxy
            // 
            this.minxy.Location = new System.Drawing.Point(12, 111);
            this.minxy.Name = "minxy";
            this.minxy.Size = new System.Drawing.Size(75, 23);
            this.minxy.TabIndex = 19;
            this.minxy.Text = "min(x,y)";
            this.minxy.UseVisualStyleBackColor = true;
            this.minxy.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // xpowy
            // 
            this.xpowy.Location = new System.Drawing.Point(174, 82);
            this.xpowy.Name = "xpowy";
            this.xpowy.Size = new System.Drawing.Size(75, 23);
            this.xpowy.TabIndex = 20;
            this.xpowy.Text = "x^y";
            this.xpowy.UseVisualStyleBackColor = true;
            this.xpowy.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // logxy
            // 
            this.logxy.Location = new System.Drawing.Point(255, 82);
            this.logxy.Name = "logxy";
            this.logxy.Size = new System.Drawing.Size(75, 23);
            this.logxy.TabIndex = 21;
            this.logxy.Text = "log x(y)";
            this.logxy.UseVisualStyleBackColor = true;
            this.logxy.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(12, 169);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 22;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // ctan
            // 
            this.ctan.Location = new System.Drawing.Point(93, 169);
            this.ctan.Name = "ctan";
            this.ctan.Size = new System.Drawing.Size(75, 23);
            this.ctan.TabIndex = 23;
            this.ctan.Text = "ctan";
            this.ctan.UseVisualStyleBackColor = true;
            this.ctan.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // asin
            // 
            this.asin.Location = new System.Drawing.Point(174, 169);
            this.asin.Name = "asin";
            this.asin.Size = new System.Drawing.Size(75, 23);
            this.asin.TabIndex = 25;
            this.asin.Text = "arcsin";
            this.asin.UseVisualStyleBackColor = true;
            this.asin.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // acos
            // 
            this.acos.Location = new System.Drawing.Point(253, 169);
            this.acos.Name = "acos";
            this.acos.Size = new System.Drawing.Size(75, 23);
            this.acos.TabIndex = 26;
            this.acos.Text = "arccos";
            this.acos.UseVisualStyleBackColor = true;
            this.acos.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // atan
            // 
            this.atan.Location = new System.Drawing.Point(12, 198);
            this.atan.Name = "atan";
            this.atan.Size = new System.Drawing.Size(75, 23);
            this.atan.TabIndex = 27;
            this.atan.Text = "arctan";
            this.atan.UseVisualStyleBackColor = true;
            this.atan.Click += new System.EventHandler(this.OneArgumentFunc_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(93, 198);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(75, 23);
            this.mod.TabIndex = 28;
            this.mod.Text = "mod";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // divxony
            // 
            this.divxony.Location = new System.Drawing.Point(174, 198);
            this.divxony.Name = "divxony";
            this.divxony.Size = new System.Drawing.Size(75, 23);
            this.divxony.TabIndex = 29;
            this.divxony.Text = "div";
            this.divxony.UseVisualStyleBackColor = true;
            this.divxony.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(253, 198);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 30;
            this.max.Text = "max(x,y)";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(93, 227);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(75, 23);
            this.average.TabIndex = 31;
            this.average.Text = "average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // geometric
            // 
            this.geometric.Location = new System.Drawing.Point(174, 227);
            this.geometric.Name = "geometric";
            this.geometric.Size = new System.Drawing.Size(75, 23);
            this.geometric.TabIndex = 32;
            this.geometric.Text = "geometric";
            this.geometric.UseVisualStyleBackColor = true;
            this.geometric.Click += new System.EventHandler(this.Btn_OP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.geometric);
            this.Controls.Add(this.average);
            this.Controls.Add(this.max);
            this.Controls.Add(this.divxony);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.atan);
            this.Controls.Add(this.acos);
            this.Controls.Add(this.asin);
            this.Controls.Add(this.ctan);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.logxy);
            this.Controls.Add(this.xpowy);
            this.Controls.Add(this.minxy);
            this.Controls.Add(this.degx);
            this.Controls.Add(this.radx);
            this.Controls.Add(this.xpow2);
            this.Controls.Add(this.onedivx);
            this.Controls.Add(this.absx);
            this.Controls.Add(this.negativex);
            this.Controls.Add(this.lnx);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
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
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button lnx;
        private System.Windows.Forms.Button negativex;
        private System.Windows.Forms.Button absx;
        private System.Windows.Forms.Button onedivx;
        private System.Windows.Forms.Button xpow2;
        private System.Windows.Forms.Button radx;
        private System.Windows.Forms.Button degx;
        private System.Windows.Forms.Button minxy;
        private System.Windows.Forms.Button xpowy;
        private System.Windows.Forms.Button logxy;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button ctan;
        private System.Windows.Forms.Button asin;
        private System.Windows.Forms.Button acos;
        private System.Windows.Forms.Button atan;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button divxony;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.Button geometric;
    }
}

