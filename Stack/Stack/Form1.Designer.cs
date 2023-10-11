namespace Stack
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
            btnPush = new Button();
            txtInsert = new TextBox();
            lblInsert = new Label();
            btnPop = new Button();
            btnPeek = new Button();
            btnDisplay = new Button();
            btnReverse = new Button();
            lbStack = new ListBox();
            SuspendLayout();
            // 
            // btnPush
            // 
            btnPush.Location = new Point(263, 61);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(106, 30);
            btnPush.TabIndex = 0;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += button1_Click;
            // 
            // txtInsert
            // 
            txtInsert.Location = new Point(120, 25);
            txtInsert.Name = "txtInsert";
            txtInsert.Size = new Size(125, 27);
            txtInsert.TabIndex = 1;
            txtInsert.TextChanged += textBox1_TextChanged;
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Location = new Point(14, 28);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(100, 20);
            lblInsert.TabIndex = 2;
            lblInsert.Text = "Push element:";
            // 
            // btnPop
            // 
            btnPop.Location = new Point(263, 97);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(106, 29);
            btnPop.TabIndex = 3;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(263, 132);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(106, 29);
            btnPeek.TabIndex = 4;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(263, 167);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(106, 29);
            btnDisplay.TabIndex = 5;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(263, 202);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(106, 29);
            btnReverse.TabIndex = 6;
            btnReverse.Text = "Reverse";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // lbStack
            // 
            lbStack.FormattingEnabled = true;
            lbStack.ItemHeight = 20;
            lbStack.Location = new Point(120, 61);
            lbStack.Name = "lbStack";
            lbStack.Size = new Size(125, 184);
            lbStack.TabIndex = 7;
            lbStack.SelectedIndexChanged += lbStack_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 287);
            Controls.Add(lbStack);
            Controls.Add(btnReverse);
            Controls.Add(btnDisplay);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(lblInsert);
            Controls.Add(txtInsert);
            Controls.Add(btnPush);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPush;
        private TextBox txtInsert;
        private Label lblInsert;
        private Button btnPop;
        private Button btnPeek;
        private Button btnDisplay;
        private Button btnReverse;
        private ListBox lbStack;
    }
}