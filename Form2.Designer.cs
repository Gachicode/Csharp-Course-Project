namespace WindowsFormsProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_equation = new System.Windows.Forms.TextBox();
            this.textBox_left = new System.Windows.Forms.TextBox();
            this.textBox_right = new System.Windows.Forms.TextBox();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.button_draw = new System.Windows.Forms.Button();
            this.total_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.total_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "f(x) = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(61, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(151, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Шаг";
            // 
            // textBox_equation
            // 
            this.textBox_equation.Location = new System.Drawing.Point(78, 322);
            this.textBox_equation.Name = "textBox_equation";
            this.textBox_equation.Size = new System.Drawing.Size(104, 20);
            this.textBox_equation.TabIndex = 5;
            // 
            // textBox_left
            // 
            this.textBox_left.Location = new System.Drawing.Point(81, 357);
            this.textBox_left.Name = "textBox_left";
            this.textBox_left.Size = new System.Drawing.Size(49, 20);
            this.textBox_left.TabIndex = 6;
            // 
            // textBox_right
            // 
            this.textBox_right.Location = new System.Drawing.Point(169, 357);
            this.textBox_right.Name = "textBox_right";
            this.textBox_right.Size = new System.Drawing.Size(49, 20);
            this.textBox_right.TabIndex = 7;
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(260, 357);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(49, 20);
            this.textBox_step.TabIndex = 8;
            // 
            // button_draw
            // 
            this.button_draw.Location = new System.Drawing.Point(207, 322);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(102, 20);
            this.button_draw.TabIndex = 9;
            this.button_draw.Text = "Построить график";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // total_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.total_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.total_chart.Legends.Add(legend1);
            this.total_chart.Location = new System.Drawing.Point(37, 10);
            this.total_chart.Name = "total_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.total_chart.Series.Add(series1);
            this.total_chart.Size = new System.Drawing.Size(423, 300);
            this.total_chart.TabIndex = 10;
            this.total_chart.Text = "chart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.total_chart);
            this.Controls.Add(this.button_draw);
            this.Controls.Add(this.textBox_step);
            this.Controls.Add(this.textBox_right);
            this.Controls.Add(this.textBox_left);
            this.Controls.Add(this.textBox_equation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.total_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_equation;
        private System.Windows.Forms.TextBox textBox_left;
        private System.Windows.Forms.TextBox textBox_right;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.DataVisualization.Charting.Chart total_chart;
    }
}