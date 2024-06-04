namespace ProjetoA3Gestao.View
{
    partial class UsuarioForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCreateUsuario = new Button();
            btnUpdateUsuario = new Button();
            btnDeleteUsuario = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            txtCep = new TextBox();
            txtNumeroTelefone = new TextBox();
            txtCpf = new TextBox();
            lstUsuarios = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnCreateUsuario
            // 
            btnCreateUsuario.Location = new Point(12, 378);
            btnCreateUsuario.Name = "btnCreateUsuario";
            btnCreateUsuario.Size = new Size(75, 23);
            btnCreateUsuario.TabIndex = 0;
            btnCreateUsuario.Text = "Create";
            btnCreateUsuario.UseVisualStyleBackColor = true;
            btnCreateUsuario.Click += btnCreateUsuario_Click;
            // 
            // btnUpdateUsuario
            // 
            btnUpdateUsuario.Location = new Point(93, 378);
            btnUpdateUsuario.Name = "btnUpdateUsuario";
            btnUpdateUsuario.Size = new Size(75, 23);
            btnUpdateUsuario.TabIndex = 1;
            btnUpdateUsuario.Text = "Update";
            btnUpdateUsuario.UseVisualStyleBackColor = true;
            btnUpdateUsuario.Click += btnUpdateUsuario_Click;
            // 
            // btnDeleteUsuario
            // 
            btnDeleteUsuario.Location = new Point(174, 378);
            btnDeleteUsuario.Name = "btnDeleteUsuario";
            btnDeleteUsuario.Size = new Size(75, 23);
            btnDeleteUsuario.TabIndex = 2;
            btnDeleteUsuario.Text = "Delete";
            btnDeleteUsuario.UseVisualStyleBackColor = true;
            btnDeleteUsuario.Click += btnDeleteUsuario_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(237, 23);
            txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(12, 120);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(237, 23);
            txtEndereco.TabIndex = 5;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(12, 165);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(237, 23);
            txtCep.TabIndex = 6;
            // 
            // txtNumeroTelefone
            // 
            txtNumeroTelefone.Location = new Point(12, 210);
            txtNumeroTelefone.Name = "txtNumeroTelefone";
            txtNumeroTelefone.Size = new Size(237, 23);
            txtNumeroTelefone.TabIndex = 7;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 256);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(237, 23);
            txtCpf.TabIndex = 8;
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(12, 316);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(237, 49);
            lstUsuarios.TabIndex = 9;
            lstUsuarios.SelectedIndexChanged += lstUsuarios_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 12;
            label3.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 13;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 14;
            label5.Text = "Nº Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 238);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 15;
            label6.Text = "CPF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 290);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 16;
            label7.Text = "Usuários";
            // 
            // UsuarioForm
            // 
            ClientSize = new Size(267, 437);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstUsuarios);
            Controls.Add(txtCpf);
            Controls.Add(txtNumeroTelefone);
            Controls.Add(txtCep);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnDeleteUsuario);
            Controls.Add(btnUpdateUsuario);
            Controls.Add(btnCreateUsuario);
            Name = "UsuarioForm";
            Text = "User Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnCreateUsuario;
        private System.Windows.Forms.Button btnUpdateUsuario;
        private System.Windows.Forms.Button btnDeleteUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtNumeroTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.ListBox lstUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}