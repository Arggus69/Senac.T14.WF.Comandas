namespace Comandas
{
    partial class FrmCardapioCad
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
            thunderGroupBox1 = new ReaLTaiizor.Controls.ThunderGroupBox();
            chkPreparo = new ReaLTaiizor.Controls.CyberCheckBox();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            id = new ReaLTaiizor.Controls.ThunderLabel();
            txtDescricao = new ReaLTaiizor.Controls.CrownTextBox();
            txtPreco = new ReaLTaiizor.Controls.CrownTextBox();
            txtTitulo = new ReaLTaiizor.Controls.CrownTextBox();
            btnCancelar = new ReaLTaiizor.Controls.Button();
            btnSalvar = new ReaLTaiizor.Controls.Button();
            txtId = new ReaLTaiizor.Controls.CrownTextBox();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // thunderGroupBox1
            // 
            thunderGroupBox1.BackColor = Color.Transparent;
            thunderGroupBox1.BodyColorA = Color.FromArgb(26, 26, 26);
            thunderGroupBox1.BodyColorB = Color.FromArgb(30, 30, 30);
            thunderGroupBox1.BodyColorC = Color.FromArgb(46, 46, 46);
            thunderGroupBox1.BodyColorD = Color.FromArgb(50, 55, 58);
            thunderGroupBox1.Controls.Add(thunderLabel3);
            thunderGroupBox1.Controls.Add(txtId);
            thunderGroupBox1.Controls.Add(chkPreparo);
            thunderGroupBox1.Controls.Add(thunderLabel2);
            thunderGroupBox1.Controls.Add(thunderLabel1);
            thunderGroupBox1.Controls.Add(id);
            thunderGroupBox1.Controls.Add(txtDescricao);
            thunderGroupBox1.Controls.Add(txtPreco);
            thunderGroupBox1.Controls.Add(txtTitulo);
            thunderGroupBox1.ForeColor = Color.WhiteSmoke;
            thunderGroupBox1.Location = new Point(33, 24);
            thunderGroupBox1.Name = "thunderGroupBox1";
            thunderGroupBox1.Size = new Size(592, 337);
            thunderGroupBox1.TabIndex = 3;
            // 
            // chkPreparo
            // 
            chkPreparo.BackColor = Color.Transparent;
            chkPreparo.Background = true;
            chkPreparo.Background_WidthPen = 2F;
            chkPreparo.BackgroundPen = true;
            chkPreparo.Checked = false;
            chkPreparo.ColorBackground = SystemColors.WindowText;
            chkPreparo.ColorBackground_1 = Color.Black;
            chkPreparo.ColorBackground_2 = Color.Black;
            chkPreparo.ColorBackground_Pen = Color.Gray;
            chkPreparo.ColorChecked = Color.Gray;
            chkPreparo.ColorPen_1 = Color.DimGray;
            chkPreparo.ColorPen_2 = Color.Black;
            chkPreparo.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            chkPreparo.Effect_1_ColorBackground = Color.Gray;
            chkPreparo.Effect_1_Transparency = 25;
            chkPreparo.Effect_2 = true;
            chkPreparo.Effect_2_ColorBackground = Color.White;
            chkPreparo.Effect_2_Transparency = 15;
            chkPreparo.Font = new Font("Arial", 11F);
            chkPreparo.ForeColor = Color.FromArgb(245, 245, 245);
            chkPreparo.LinearGradient_Background = false;
            chkPreparo.LinearGradientPen = false;
            chkPreparo.Location = new Point(36, 278);
            chkPreparo.Name = "chkPreparo";
            chkPreparo.RGB = false;
            chkPreparo.Rounding = true;
            chkPreparo.RoundingInt = 100;
            chkPreparo.Size = new Size(255, 45);
            chkPreparo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            chkPreparo.TabIndex = 17;
            chkPreparo.Tag = "Cyber";
            chkPreparo.TextButton = "Possui Preparo?";
            chkPreparo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chkPreparo.Timer_Effect_1 = 1;
            chkPreparo.Timer_RGB = 300;
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(55, 117);
            thunderLabel2.Margin = new Padding(2, 4, 2, 4);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(98, 31);
            thunderLabel2.TabIndex = 16;
            thunderLabel2.Text = "Descrição";
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(55, 193);
            thunderLabel1.Margin = new Padding(2, 4, 2, 4);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(98, 31);
            thunderLabel1.TabIndex = 16;
            thunderLabel1.Text = "Preço";
            // 
            // id
            // 
            id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            id.BackColor = Color.Transparent;
            id.ForeColor = Color.WhiteSmoke;
            id.Location = new Point(55, 41);
            id.Margin = new Padding(2, 4, 2, 4);
            id.Name = "id";
            id.Size = new Size(98, 31);
            id.TabIndex = 15;
            id.Text = "Titulo";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.FromArgb(69, 73, 74);
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.ForeColor = Color.FromArgb(220, 220, 220);
            txtDescricao.Location = new Point(36, 155);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(507, 31);
            txtDescricao.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.FromArgb(69, 73, 74);
            txtPreco.BorderStyle = BorderStyle.FixedSingle;
            txtPreco.ForeColor = Color.FromArgb(220, 220, 220);
            txtPreco.Location = new Point(36, 231);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(144, 31);
            txtPreco.TabIndex = 1;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.FromArgb(69, 73, 74);
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.ForeColor = Color.FromArgb(220, 220, 220);
            txtTitulo.Location = new Point(36, 79);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(507, 31);
            txtTitulo.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.BorderColor = Color.FromArgb(165, 37, 37);
            btnCancelar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnCancelar.EnteredColor = Color.FromArgb(165, 37, 37);
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Image = null;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.InactiveColor = Color.Red;
            btnCancelar.Location = new Point(262, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancelar.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancelar.Size = new Size(159, 41);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.BorderColor = Color.LimeGreen;
            btnSalvar.EnteredBorderColor = Color.LimeGreen;
            btnSalvar.EnteredColor = Color.LimeGreen;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F);
            btnSalvar.Image = null;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.InactiveColor = Color.Lime;
            btnSalvar.Location = new Point(452, 397);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PressedBorderColor = Color.LimeGreen;
            btnSalvar.PressedColor = Color.LimeGreen;
            btnSalvar.Size = new Size(159, 41);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlignment = StringAlignment.Center;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(69, 73, 74);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.ForeColor = Color.FromArgb(220, 220, 220);
            txtId.Location = new Point(214, 231);
            txtId.Name = "txtId";
            txtId.Size = new Size(87, 31);
            txtId.TabIndex = 18;
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(214, 193);
            thunderLabel3.Margin = new Padding(2, 4, 2, 4);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(98, 31);
            thunderLabel3.TabIndex = 19;
            thunderLabel3.Text = "Id";
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(thunderGroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cardápio Cad";
            thunderGroupBox1.ResumeLayout(false);
            thunderGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.ThunderGroupBox thunderGroupBox1;
        private ReaLTaiizor.Controls.CrownTextBox txtDescricao;
        private ReaLTaiizor.Controls.CrownTextBox txtPreco;
        private ReaLTaiizor.Controls.CrownTextBox txtTitulo;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private ReaLTaiizor.Controls.ThunderLabel id;
        private ReaLTaiizor.Controls.Button btnCancelar;
        private ReaLTaiizor.Controls.Button btnSalvar;
        private ReaLTaiizor.Controls.CyberCheckBox chkPreparo;
        private ReaLTaiizor.Controls.CrownTextBox txtId;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
    }
}