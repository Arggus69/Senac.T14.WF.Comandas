namespace Comandas
{
    partial class FrmComandaCad
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
            btnVoltar = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.BorderColor = Color.FromArgb(32, 34, 37);
            btnVoltar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnVoltar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnVoltar.Font = new Font("Microsoft Sans Serif", 12F);
            btnVoltar.Image = null;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnVoltar.Location = new Point(12, 408);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnVoltar.PressedColor = Color.FromArgb(165, 37, 37);
            btnVoltar.Size = new Size(88, 30);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlignment = StringAlignment.Center;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comandas Cad";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Button btnVoltar;
    }
}