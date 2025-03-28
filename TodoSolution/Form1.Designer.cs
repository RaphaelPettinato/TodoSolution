namespace TodoSolution
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
            textBox1 = new TextBox();
            label1 = new Label();
            input_label = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            DeleteButton = new Button();
            UpdateButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(621, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(798, 38);
            label1.TabIndex = 1;
            label1.Text = "TODO LIST";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // input_label
            // 
            input_label.AutoSize = true;
            input_label.Location = new Point(99, 91);
            input_label.Name = "input_label";
            input_label.Size = new Size(131, 20);
            input_label.TabIndex = 2;
            input_label.Text = "Nome della Tarefa";
            // 
            // button1
            // 
            button1.Location = new Point(344, 160);
            button1.Name = "button1";
            button1.Size = new Size(112, 44);
            button1.TabIndex = 3;
            button1.Text = "Aggiungi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(99, 246);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(621, 204);
            listBox1.TabIndex = 4;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(599, 456);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(121, 54);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Cancella";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(99, 456);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(137, 54);
            UpdateButton.TabIndex = 6;
            UpdateButton.Text = "Aggiorna Stato";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 543);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(input_label);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "TO DO";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label input_label;
        private Button button1;
        private ListBox listBox1;
        private Button DeleteButton;
        private Button UpdateButton;
    }
}
