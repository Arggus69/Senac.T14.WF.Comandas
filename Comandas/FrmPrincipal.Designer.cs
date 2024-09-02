namespace Comandas
{
    partial class FrmPrincipal
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
            gpxPrincipal = new GroupBox();
            btnUsuarios = new ReaLTaiizor.Controls.Button();
            btnPedidoCozinha = new ReaLTaiizor.Controls.Button();
            btnComanda = new ReaLTaiizor.Controls.Button();
            btnCardapio = new ReaLTaiizor.Controls.Button();
            btnSair = new ReaLTaiizor.Controls.Button();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.Controls.Add(btnUsuarios);
            gpxPrincipal.Controls.Add(btnPedidoCozinha);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Location = new Point(40, 12);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(728, 401);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Transparent;
            btnUsuarios.BorderColor = Color.FromArgb(32, 34, 37);
            btnUsuarios.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnUsuarios.EnteredColor = Color.FromArgb(32, 34, 37);
            btnUsuarios.Font = new Font("Microsoft Sans Serif", 12F);
            btnUsuarios.Image = null;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.InactiveColor = Color.FromArgb(32, 34, 37);
            btnUsuarios.Location = new Point(533, 121);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnUsuarios.PressedColor = Color.FromArgb(165, 37, 37);
            btnUsuarios.Size = new Size(129, 121);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.TextAlignment = StringAlignment.Center;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.BackColor = Color.Transparent;
            btnPedidoCozinha.BorderColor = Color.FromArgb(32, 34, 37);
            btnPedidoCozinha.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnPedidoCozinha.EnteredColor = Color.FromArgb(32, 34, 37);
            btnPedidoCozinha.Font = new Font("Microsoft Sans Serif", 12F);
            btnPedidoCozinha.Image = null;
            btnPedidoCozinha.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidoCozinha.InactiveColor = Color.FromArgb(32, 34, 37);
            btnPedidoCozinha.Location = new Point(372, 121);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnPedidoCozinha.PressedColor = Color.FromArgb(165, 37, 37);
            btnPedidoCozinha.Size = new Size(129, 121);
            btnPedidoCozinha.TabIndex = 2;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.TextAlignment = StringAlignment.Center;
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.Transparent;
            btnComanda.BorderColor = Color.FromArgb(32, 34, 37);
            btnComanda.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnComanda.EnteredColor = Color.FromArgb(32, 34, 37);
            btnComanda.Font = new Font("Microsoft Sans Serif", 12F);
            btnComanda.Image = null;
            btnComanda.ImageAlign = ContentAlignment.MiddleLeft;
            btnComanda.InactiveColor = Color.FromArgb(32, 34, 37);
            btnComanda.Location = new Point(210, 121);
            btnComanda.Name = "btnComanda";
            btnComanda.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnComanda.PressedColor = Color.FromArgb(165, 37, 37);
            btnComanda.Size = new Size(129, 121);
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.TextAlignment = StringAlignment.Center;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.Transparent;
            btnCardapio.BorderColor = Color.FromArgb(32, 34, 37);
            btnCardapio.EnteredBorderColor = Color.FromArgb(64, 64, 64);
            btnCardapio.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCardapio.Font = new Font("Microsoft Sans Serif", 12F);
            btnCardapio.Image = null;
            btnCardapio.ImageAlign = ContentAlignment.MiddleLeft;
            btnCardapio.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCardapio.Location = new Point(54, 121);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.PressedBorderColor = Color.FromArgb(64, 64, 64);
            btnCardapio.PressedColor = Color.FromArgb(64, 64, 64);
            btnCardapio.Size = new Size(129, 121);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.TextAlignment = StringAlignment.Center;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.BorderColor = Color.FromArgb(32, 34, 37);
            btnSair.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSair.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSair.Font = new Font("Microsoft Sans Serif", 12F);
            btnSair.Image = null;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSair.Location = new Point(12, 395);
            btnSair.Name = "btnSair";
            btnSair.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSair.PressedColor = Color.FromArgb(165, 37, 37);
            btnSair.Size = new Size(88, 30);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.TextAlignment = StringAlignment.Center;
            btnSair.Click += btnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 437);
            Controls.Add(btnSair);
            Controls.Add(gpxPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Comandas";
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.Button btnCardapio;
        private ReaLTaiizor.Controls.Button btnUsuarios;
        private ReaLTaiizor.Controls.Button btnPedidoCozinha;
        private ReaLTaiizor.Controls.Button btnComanda;
        private ReaLTaiizor.Controls.Button btnSair;
    }
}
