namespace aula1PRJ
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
            TXTlogin = new TextBox();
            TXTsenha = new TextBox();
            LBLlogin = new Label();
            LBLsenha = new Label();
            BTlogar = new Button();
            LBLloginmensagem = new Label();
            SuspendLayout();
            // 
            // TXTlogin
            // 
            TXTlogin.BackColor = Color.DarkGray;
            TXTlogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXTlogin.Location = new Point(211, 101);
            TXTlogin.MaxLength = 11;
            TXTlogin.Name = "TXTlogin";
            TXTlogin.Size = new Size(204, 40);
            TXTlogin.TabIndex = 0;
            TXTlogin.TextChanged += textBox1_TextChanged;
            // 
            // TXTsenha
            // 
            TXTsenha.BackColor = Color.DarkGray;
            TXTsenha.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXTsenha.Location = new Point(211, 162);
            TXTsenha.MaxLength = 6;
            TXTsenha.Name = "TXTsenha";
            TXTsenha.Size = new Size(204, 40);
            TXTsenha.TabIndex = 1;
            TXTsenha.UseSystemPasswordChar = true;
            // 
            // LBLlogin
            // 
            LBLlogin.AutoSize = true;
            LBLlogin.BackColor = Color.LightSlateGray;
            LBLlogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBLlogin.Location = new Point(134, 101);
            LBLlogin.Name = "LBLlogin";
            LBLlogin.Size = new Size(59, 25);
            LBLlogin.TabIndex = 3;
            LBLlogin.Text = "Login";
            LBLlogin.Click += label1_Click;
            // 
            // LBLsenha
            // 
            LBLsenha.AutoSize = true;
            LBLsenha.BackColor = Color.LightSlateGray;
            LBLsenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBLsenha.Location = new Point(134, 162);
            LBLsenha.Name = "LBLsenha";
            LBLsenha.Size = new Size(65, 25);
            LBLsenha.TabIndex = 4;
            LBLsenha.Text = "Senha";
            LBLsenha.Click += label2_Click;
            // 
            // BTlogar
            // 
            BTlogar.BackColor = SystemColors.ActiveBorder;
            BTlogar.BackgroundImageLayout = ImageLayout.None;
            BTlogar.Cursor = Cursors.Hand;
            BTlogar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTlogar.Location = new Point(264, 246);
            BTlogar.Name = "BTlogar";
            BTlogar.Size = new Size(107, 46);
            BTlogar.TabIndex = 6;
            BTlogar.Text = "Logar";
            BTlogar.UseVisualStyleBackColor = false;
            BTlogar.Click += BTlogar_Click;
            // 
            // LBLloginmensagem
            // 
            LBLloginmensagem.AutoSize = true;
            LBLloginmensagem.BackColor = Color.LightSlateGray;
            LBLloginmensagem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBLloginmensagem.Location = new Point(211, 205);
            LBLloginmensagem.Name = "LBLloginmensagem";
            LBLloginmensagem.Size = new Size(107, 25);
            LBLloginmensagem.TabIndex = 7;
            LBLloginmensagem.Text = "mensagem";
            LBLloginmensagem.Click += LBLloginmensagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(596, 416);
            Controls.Add(LBLloginmensagem);
            Controls.Add(BTlogar);
            Controls.Add(LBLsenha);
            Controls.Add(LBLlogin);
            Controls.Add(TXTsenha);
            Controls.Add(TXTlogin);
            Name = "Form1";
            Text = " jucasbank -- login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXTlogin;
        private TextBox TXTsenha;
        private Label LBLlogin;
        private Label LBLsenha;
        private Button BTlogar;
        private Label LBLloginmensagem;
    }
}