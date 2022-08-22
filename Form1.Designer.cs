
namespace WebParser
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
            this.htmlTextBox = new System.Windows.Forms.TextBox();
            this.cssTextBox = new System.Windows.Forms.TextBox();
            this.jsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HTML_Edit_Button = new System.Windows.Forms.Button();
            this.CSS_Edit_Button = new System.Windows.Forms.Button();
            this.JS_Edit_Button = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // htmlTextBox
            // 
            this.htmlTextBox.Location = new System.Drawing.Point(211, 47);
            this.htmlTextBox.Name = "htmlTextBox";
            this.htmlTextBox.Size = new System.Drawing.Size(323, 23);
            this.htmlTextBox.TabIndex = 0;
            // 
            // cssTextBox
            // 
            this.cssTextBox.Location = new System.Drawing.Point(211, 135);
            this.cssTextBox.Name = "cssTextBox";
            this.cssTextBox.Size = new System.Drawing.Size(323, 23);
            this.cssTextBox.TabIndex = 1;
            // 
            // jsTextBox
            // 
            this.jsTextBox.Location = new System.Drawing.Point(211, 231);
            this.jsTextBox.Name = "jsTextBox";
            this.jsTextBox.Size = new System.Drawing.Size(323, 23);
            this.jsTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "HTML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "JavaScript";
            // 
            // HTML_Edit_Button
            // 
            this.HTML_Edit_Button.Location = new System.Drawing.Point(636, 47);
            this.HTML_Edit_Button.Name = "HTML_Edit_Button";
            this.HTML_Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.HTML_Edit_Button.TabIndex = 6;
            this.HTML_Edit_Button.Text = "Edit";
            this.HTML_Edit_Button.UseVisualStyleBackColor = true;
            this.HTML_Edit_Button.Click += new System.EventHandler(this.HTML_Edit_Button_Click);
            // 
            // CSS_Edit_Button
            // 
            this.CSS_Edit_Button.Location = new System.Drawing.Point(636, 135);
            this.CSS_Edit_Button.Name = "CSS_Edit_Button";
            this.CSS_Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.CSS_Edit_Button.TabIndex = 7;
            this.CSS_Edit_Button.Text = "Edit";
            this.CSS_Edit_Button.UseVisualStyleBackColor = true;
            this.CSS_Edit_Button.Click += new System.EventHandler(this.CSS_Edit_Button_Click);
            // 
            // JS_Edit_Button
            // 
            this.JS_Edit_Button.Location = new System.Drawing.Point(636, 231);
            this.JS_Edit_Button.Name = "JS_Edit_Button";
            this.JS_Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.JS_Edit_Button.TabIndex = 8;
            this.JS_Edit_Button.Text = "Edit";
            this.JS_Edit_Button.UseVisualStyleBackColor = true;
            this.JS_Edit_Button.Click += new System.EventHandler(this.JS_Edit_Button_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(32, 413);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(45, 15);
            this.Output.TabIndex = 9;
            this.Output.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.JS_Edit_Button);
            this.Controls.Add(this.CSS_Edit_Button);
            this.Controls.Add(this.HTML_Edit_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jsTextBox);
            this.Controls.Add(this.cssTextBox);
            this.Controls.Add(this.htmlTextBox);
            this.Name = "Form1";
            this.Text = "WebParser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox htmlTextBox;
        private System.Windows.Forms.TextBox cssTextBox;
        private System.Windows.Forms.TextBox jsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HTML_Edit_Button;
        private System.Windows.Forms.Button CSS_Edit_Button;
        private System.Windows.Forms.Button JS_Edit_Button;
        private System.Windows.Forms.Label Output;
    }
}

