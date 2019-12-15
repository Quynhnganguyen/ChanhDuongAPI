namespace ChuaNgotApp
{
    partial class ChuaNgotForm
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
            this.fibonacciButton = new System.Windows.Forms.Button();
            this.textBoxForN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xmlToJsonButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.texBoxForXml = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fibonacciButton
            // 
            this.fibonacciButton.Location = new System.Drawing.Point(458, 22);
            this.fibonacciButton.Name = "fibonacciButton";
            this.fibonacciButton.Size = new System.Drawing.Size(224, 47);
            this.fibonacciButton.TabIndex = 1;
            this.fibonacciButton.Text = "Compute Fibonancci";
            this.fibonacciButton.UseVisualStyleBackColor = true;
            this.fibonacciButton.Click += new System.EventHandler(this.FibonacciButton_Click);
            // 
            // textBoxForN
            // 
            this.textBoxForN.Location = new System.Drawing.Point(82, 25);
            this.textBoxForN.Name = "textBoxForN";
            this.textBoxForN.Size = new System.Drawing.Size(137, 26);
            this.textBoxForN.TabIndex = 2;
            this.textBoxForN.TextChanged += new System.EventHandler(this.TextBoxForN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xmlToJsonButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.texBoxForXml);
            this.groupBox1.Location = new System.Drawing.Point(31, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XmlToJson";
            // 
            // xmlToJsonButton
            // 
            this.xmlToJsonButton.Location = new System.Drawing.Point(25, 106);
            this.xmlToJsonButton.Name = "xmlToJsonButton";
            this.xmlToJsonButton.Size = new System.Drawing.Size(217, 42);
            this.xmlToJsonButton.TabIndex = 2;
            this.xmlToJsonButton.Text = "Convert To JSON";
            this.xmlToJsonButton.UseVisualStyleBackColor = true;
            this.xmlToJsonButton.Click += new System.EventHandler(this.XmlToJsonButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "XML";
            // 
            // texBoxForXml
            // 
            this.texBoxForXml.Location = new System.Drawing.Point(82, 43);
            this.texBoxForXml.Name = "texBoxForXml";
            this.texBoxForXml.Size = new System.Drawing.Size(651, 26);
            this.texBoxForXml.TabIndex = 0;
            this.texBoxForXml.TextChanged += new System.EventHandler(this.TextBoxForXml_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxForN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fibonacciButton);
            this.groupBox2.Location = new System.Drawing.Point(31, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fibonacci";
            // 
            // ChuaNgotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 377);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "ChuaNgotForm";
            this.Text = "ChuaNgotApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fibonacciButton;
        private System.Windows.Forms.TextBox textBoxForN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texBoxForXml;
        private System.Windows.Forms.Button xmlToJsonButton;
    }
}

