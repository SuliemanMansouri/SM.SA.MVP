namespace SM.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private readonly System.ComponentModel.IContainer components = null;

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
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.SecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.Location = new System.Drawing.Point(64, 12);
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            this.FirstNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.FirstNumberTextBox.TabIndex = 0;
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.Location = new System.Drawing.Point(64, 41);
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            this.SecondNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.SecondNumberTextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(64, 70);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 23);
            this.ResultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(170, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(170, 41);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 7;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 148);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SecondNumberTextBox);
            this.Controls.Add(this.FirstNumberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstNumberTextBox;
        private TextBox SecondNumberTextBox;
        private TextBox ResultTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddButton;
        private Button DivideButton;
    }
}