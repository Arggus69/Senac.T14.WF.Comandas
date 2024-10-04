namespace Comandas
{
    partial class FrmCardapio
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
            textPesquisar = new ReaLTaiizor.Controls.CrownTextBox();
            btnExcluir = new ReaLTaiizor.Controls.Button();
            btnEditar = new ReaLTaiizor.Controls.Button();
            btnNovo = new ReaLTaiizor.Controls.Button();
            dgvCardapio = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Silver;
            btnVoltar.BorderColor = Color.Black;
            btnVoltar.EnteredBorderColor = Color.Black;
            btnVoltar.EnteredColor = Color.Black;
            btnVoltar.Font = new Font("Microsoft Sans Serif", 12F);
            btnVoltar.Image = null;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.InactiveColor = Color.Black;
            btnVoltar.Location = new Point(11, 407);
            btnVoltar.Margin = new Padding(2, 4, 2, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PressedBorderColor = Color.Black;
            btnVoltar.PressedColor = Color.Black;
            btnVoltar.Size = new Size(89, 30);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextAlignment = StringAlignment.Center;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // textPesquisar
            // 
            textPesquisar.BackColor = Color.Silver;
            textPesquisar.BorderStyle = BorderStyle.FixedSingle;
            textPesquisar.Enabled = false;
            textPesquisar.ForeColor = Color.FromArgb(220, 220, 220);
            textPesquisar.Location = new Point(28, 13);
            textPesquisar.Margin = new Padding(2, 4, 2, 4);
            textPesquisar.Name = "textPesquisar";
            textPesquisar.Size = new Size(749, 31);
            textPesquisar.TabIndex = 11;
            textPesquisar.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.BorderColor = Color.FromArgb(165, 37, 37);
            btnExcluir.Enabled = false;
            btnExcluir.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnExcluir.EnteredColor = Color.FromArgb(165, 37, 37);
            btnExcluir.Font = new Font("Microsoft Sans Serif", 12F);
            btnExcluir.Image = null;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.InactiveColor = Color.Red;
            btnExcluir.Location = new Point(473, 402);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PressedBorderColor = Color.FromArgb(192, 0, 0);
            btnExcluir.PressedColor = Color.FromArgb(165, 37, 37);
            btnExcluir.Size = new Size(136, 35);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlignment = StringAlignment.Center;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Lime;
            btnEditar.BorderColor = Color.LimeGreen;
            btnEditar.Enabled = false;
            btnEditar.EnteredBorderColor = Color.LimeGreen;
            btnEditar.EnteredColor = Color.LimeGreen;
            btnEditar.Font = new Font("Microsoft Sans Serif", 12F);
            btnEditar.Image = null;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.InactiveColor = Color.Lime;
            btnEditar.Location = new Point(641, 402);
            btnEditar.Name = "btnEditar";
            btnEditar.PressedBorderColor = Color.LimeGreen;
            btnEditar.PressedColor = Color.LimeGreen;
            btnEditar.Size = new Size(136, 35);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.TextAlignment = StringAlignment.Center;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.BorderColor = Color.FromArgb(32, 34, 37);
            btnNovo.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnNovo.EnteredColor = Color.FromArgb(32, 34, 37);
            btnNovo.Font = new Font("Microsoft Sans Serif", 12F);
            btnNovo.Image = null;
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.InactiveColor = Color.FromArgb(32, 34, 37);
            btnNovo.Location = new Point(28, 61);
            btnNovo.Name = "btnNovo";
            btnNovo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnNovo.PressedColor = Color.FromArgb(165, 37, 37);
            btnNovo.Size = new Size(265, 41);
            btnNovo.TabIndex = 14;
            btnNovo.Text = "+ Novo item Cardapio";
            btnNovo.TextAlignment = StringAlignment.Center;
            btnNovo.Click += btnNovo_Click;
            // 
            // dgvCardapio
            // 
            dgvCardapio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCardapio.Location = new Point(28, 120);
            dgvCardapio.Name = "dgvCardapio";
            dgvCardapio.RowHeadersWidth = 62;
            dgvCardapio.Size = new Size(749, 276);
            dgvCardapio.TabIndex = 15;
            dgvCardapio.CellClick += dgvCardapio_CellClick;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCardapio);
            Controls.Add(btnNovo);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(textPesquisar);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cardápio";
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button btnVoltar;
        private ReaLTaiizor.Controls.CrownTextBox textPesquisar;
        private ReaLTaiizor.Controls.Button btnExcluir;
        private ReaLTaiizor.Controls.Button btnEditar;
        private ReaLTaiizor.Controls.Button btnNovo;
        private DataGridView dgvCardapio;
    }
}