namespace calcular_el_area_de_una_figura
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
            circle = new Button();
            triangle = new Button();
            square = new Button();
            Basetxt = new TextBox();
            Heighttxt = new TextBox();
            Sidetxt = new TextBox();
            radiustxt = new TextBox();
            SuspendLayout();
            // 
            // circle
            // 
            circle.BackColor = SystemColors.ActiveCaption;
            circle.Location = new Point(61, 306);
            circle.Name = "circle";
            circle.Size = new Size(77, 81);
            circle.TabIndex = 0;
            circle.Text = "circle";
            circle.UseVisualStyleBackColor = false;
            circle.Click += circle_Click;
            // 
            // triangle
            // 
            triangle.BackColor = Color.Lime;
            triangle.Location = new Point(258, 306);
            triangle.Name = "triangle";
            triangle.Size = new Size(77, 81);
            triangle.TabIndex = 1;
            triangle.Text = "triangle";
            triangle.UseVisualStyleBackColor = false;
            triangle.Click += triangle_Click;
            // 
            // square
            // 
            square.BackColor = Color.DarkOrange;
            square.Location = new Point(445, 306);
            square.Name = "square";
            square.Size = new Size(77, 81);
            square.TabIndex = 2;
            square.Text = "square";
            square.UseVisualStyleBackColor = false;
            square.Click += square_Click;
            // 
            // Basetxt
            // 
            Basetxt.Location = new Point(235, 53);
            Basetxt.Name = "Basetxt";
            Basetxt.Size = new Size(118, 23);
            Basetxt.TabIndex = 3;
            Basetxt.Text = "wht is the base?";
            Basetxt.TextChanged += area_TextChanged;
            // 
            // Heighttxt
            // 
            Heighttxt.Location = new Point(235, 119);
            Heighttxt.Name = "Heighttxt";
            Heighttxt.Size = new Size(118, 23);
            Heighttxt.TabIndex = 4;
            Heighttxt.Text = "What is the Height?";
            Heighttxt.TextChanged += textBox1_TextChanged;
            // 
            // Sidetxt
            // 
            Sidetxt.Location = new Point(434, 81);
            Sidetxt.Name = "Sidetxt";
            Sidetxt.Size = new Size(100, 23);
            Sidetxt.TabIndex = 5;
            Sidetxt.Text = "Whati si the side?";
            Sidetxt.TextChanged += textBox1_TextChanged_1;
            // 
            // radiustxt
            // 
            radiustxt.Location = new Point(52, 81);
            radiustxt.Name = "radiustxt";
            radiustxt.Size = new Size(100, 23);
            radiustxt.TabIndex = 6;
            radiustxt.Text = "what si te radius?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(593, 450);
            Controls.Add(radiustxt);
            Controls.Add(Sidetxt);
            Controls.Add(Heighttxt);
            Controls.Add(Basetxt);
            Controls.Add(square);
            Controls.Add(triangle);
            Controls.Add(circle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button circle;
        private Button triangle;
        private Button square;
        private TextBox Basetxt;
        private TextBox Heighttxt;
        private TextBox Sidetxt;
        private TextBox radiustxt;
    }
}
