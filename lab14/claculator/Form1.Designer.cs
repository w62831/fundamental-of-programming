namespace calculator
{
    partial class Form1
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
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(15, 77);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(32, 23);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(53, 77);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(28, 23);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(87, 77);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(28, 23);
            this.divide.TabIndex = 2;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(121, 77);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(26, 23);
            this.multiply.TabIndex = 3;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "1st number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "2nd number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "result";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(117, 106);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 7;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(117, 36);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 8;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(117, 6);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num1;
    }
}

