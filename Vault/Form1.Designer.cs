namespace Vault
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
            Title = new Label();
            ipBox = new TextBox();
            label2 = new Label();
            saveButton = new Button();
            run = new Button();
            selectFiles = new Button();
            portBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(328, 9);
            Title.Name = "Title";
            Title.Size = new Size(104, 50);
            Title.TabIndex = 0;
            Title.Text = "Vault";
            Title.Click += saveButton_Click;
            // 
            // ipBox
            // 
            ipBox.Location = new Point(332, 105);
            ipBox.Name = "ipBox";
            ipBox.PlaceholderText = "0.0.0.0";
            ipBox.Size = new Size(100, 23);
            ipBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 108);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "IPv4 Address:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(332, 360);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 23);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // run
            // 
            run.Location = new Point(332, 415);
            run.Name = "run";
            run.Size = new Size(100, 23);
            run.TabIndex = 4;
            run.Text = "Run";
            run.UseVisualStyleBackColor = true;
            run.Click += run_Click;
            // 
            // selectFiles
            // 
            selectFiles.Location = new Point(332, 213);
            selectFiles.Name = "selectFiles";
            selectFiles.Size = new Size(100, 23);
            selectFiles.TabIndex = 5;
            selectFiles.Text = "Select Files";
            selectFiles.UseVisualStyleBackColor = true;
            selectFiles.Click += selectFiles_Click;
            // 
            // portBox
            // 
            portBox.Location = new Point(332, 150);
            portBox.Name = "portBox";
            portBox.PlaceholderText = "0000";
            portBox.Size = new Size(100, 23);
            portBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 153);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "Port:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(portBox);
            Controls.Add(selectFiles);
            Controls.Add(run);
            Controls.Add(saveButton);
            Controls.Add(label2);
            Controls.Add(ipBox);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox ipBox;
        private Label label2;
        private Button saveButton;
        private Button run;
        private Button selectFiles;
        private TextBox portBox;
        private Label label1;
    }
}
