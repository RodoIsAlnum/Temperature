namespace Temperature
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
            BTN_F = new Button();
            BTN_C = new Button();
            tbCel = new TextBox();
            tbFar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_clear = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTN_F
            // 
            BTN_F.Location = new Point(45, 141);
            BTN_F.Margin = new Padding(3, 4, 3, 4);
            BTN_F.Name = "BTN_F";
            BTN_F.Size = new Size(109, 45);
            BTN_F.TabIndex = 0;
            BTN_F.Text = "To Celcius";
            BTN_F.UseVisualStyleBackColor = true;
            BTN_F.Click += buttonf_Click;
            // 
            // BTN_C
            // 
            BTN_C.Location = new Point(189, 141);
            BTN_C.Margin = new Padding(3, 4, 3, 4);
            BTN_C.Name = "BTN_C";
            BTN_C.Size = new Size(105, 45);
            BTN_C.TabIndex = 1;
            BTN_C.Text = "To Farenheit";
            BTN_C.UseVisualStyleBackColor = true;
            BTN_C.Click += buttonc_Click;
            // 
            // tbCel
            // 
            tbCel.Location = new Point(49, 97);
            tbCel.Margin = new Padding(3, 4, 3, 4);
            tbCel.Name = "tbCel";
            tbCel.Size = new Size(105, 27);
            tbCel.TabIndex = 2;
            // 
            // tbFar
            // 
            tbFar.Location = new Point(189, 97);
            tbFar.Margin = new Padding(3, 4, 3, 4);
            tbFar.Name = "tbFar";
            tbFar.Size = new Size(104, 27);
            tbFar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 73);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 4;
            label1.Text = "Degrees on F";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 73);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 5;
            label2.Text = "Degrees on C";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(45, 195);
            btn_clear.Margin = new Padding(3, 4, 3, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(249, 31);
            btn_clear.TabIndex = 6;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.portadita;
            pictureBox1.Location = new Point(21, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 34);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 268);
            Controls.Add(pictureBox1);
            Controls.Add(btn_clear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbFar);
            Controls.Add(tbCel);
            Controls.Add(BTN_C);
            Controls.Add(BTN_F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Temperature converter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_F;
        private Button BTN_C;
        private TextBox tbCel;
        private TextBox tbFar;
        private Label label1;
        private Label label2;
        private Button btn_clear;
        private PictureBox pictureBox1;
    }
}
