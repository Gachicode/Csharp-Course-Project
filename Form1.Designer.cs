namespace WindowsFormsProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_solve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_equation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_left = new System.Windows.Forms.TextBox();
            this.textBox_right = new System.Windows.Forms.TextBox();
            this.textBox_epsilon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.graphics_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(209, 36);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(77, 21);
            this.button_solve.TabIndex = 0;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "f(x) =";
            // 
            // textBox_equation
            // 
            this.textBox_equation.Location = new System.Drawing.Point(73, 37);
            this.textBox_equation.Name = "textBox_equation";
            this.textBox_equation.Size = new System.Drawing.Size(130, 20);
            this.textBox_equation.TabIndex = 2;
            this.textBox_equation.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Левая граница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Правая граница";
            // 
            // textBox_left
            // 
            this.textBox_left.Location = new System.Drawing.Point(106, 69);
            this.textBox_left.Name = "textBox_left";
            this.textBox_left.Size = new System.Drawing.Size(25, 20);
            this.textBox_left.TabIndex = 5;
            this.textBox_left.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_right
            // 
            this.textBox_right.Location = new System.Drawing.Point(106, 94);
            this.textBox_right.Name = "textBox_right";
            this.textBox_right.Size = new System.Drawing.Size(25, 20);
            this.textBox_right.TabIndex = 6;
            this.textBox_right.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_epsilon
            // 
            this.textBox_epsilon.Location = new System.Drawing.Point(106, 120);
            this.textBox_epsilon.Name = "textBox_epsilon";
            this.textBox_epsilon.Size = new System.Drawing.Size(25, 20);
            this.textBox_epsilon.TabIndex = 7;
            this.textBox_epsilon.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Точность (ε)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(171, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(171, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ответ:";
            // 
            // graphics_button
            // 
            this.graphics_button.Location = new System.Drawing.Point(209, 62);
            this.graphics_button.Name = "graphics_button";
            this.graphics_button.Size = new System.Drawing.Size(77, 23);
            this.graphics_button.TabIndex = 12;
            this.graphics_button.Text = "Нарисовать";
            this.graphics_button.UseVisualStyleBackColor = true;
            this.graphics_button.Click += new System.EventHandler(this.button_graphics_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 159);
            this.Controls.Add(this.graphics_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_epsilon);
            this.Controls.Add(this.textBox_right);
            this.Controls.Add(this.textBox_left);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_equation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_solve);
            this.Name = "Form1";
            this.Text = "Решение нелинейного уравнения методом половинного деления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_equation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_left;
        private System.Windows.Forms.TextBox textBox_right;
        private System.Windows.Forms.TextBox textBox_epsilon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button graphics_button;
    }
}

