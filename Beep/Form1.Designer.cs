namespace Beep
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
            BtnBeep = new Button();
            SuspendLayout();
            // 
            // BtnBeep
            // 
            BtnBeep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnBeep.Location = new Point(12, 12);
            BtnBeep.Name = "BtnBeep";
            BtnBeep.Size = new Size(160, 137);
            BtnBeep.TabIndex = 0;
            BtnBeep.Text = "Beep";
            BtnBeep.UseVisualStyleBackColor = true;
            BtnBeep.Click += BtnBeep_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 161);
            Controls.Add(BtnBeep);
            Name = "Form1";
            Text = "Beep";
            ResumeLayout(false);

        }

        #endregion

        private Button BtnBeep;
    }
}
