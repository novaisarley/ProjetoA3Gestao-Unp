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
            this.btnCreateUsuario = new System.Windows.Forms.Button();
            this.btnUpdateUsuario = new System.Windows.Forms.Button();
            this.btnDeleteUsuario = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtNumeroTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreateUsuario
            // 
            this.btnCreateUsuario.Location = new System.Drawing.Point(12, 226);
            this.btnCreateUsuario.Name = "btnCreateUsuario";
            this.btnCreateUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCreateUsuario.TabIndex = 0;
            this.btnCreateUsuario.Text = "Create";
            this.btnCreateUsuario.UseVisualStyleBackColor = true;
            this.btnCreateUsuario.Click += new System.EventHandler(this.btnCreateUsuario_Click);
            // 
            // btnUpdateUsuario
            // 
            this.btnUpdateUsuario.Location = new System.Drawing.Point(93, 226);
            this.btnUpdateUsuario.Name = "btnUpdateUsuario";
            this.btnUpdateUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUsuario.TabIndex = 1;
            this.btnUpdateUsuario.Text = "Update";
            this.btnUpdateUsuario.UseVisualStyleBackColor = true;
            this.btnUpdateUsuario.Click += new System.EventHandler(this.btnUpdateUsuario_Click);
            // 
            // btnDeleteUsuario
            // 
            this.btnDeleteUsuario.Location = new System.Drawing.Point(174, 226);
            this.btnDeleteUsuario.Name = "btnDeleteUsuario";
            this.btnDeleteUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUsuario.TabIndex = 2;
            this.btnDeleteUsuario.Text = "Delete";
            this.btnDeleteUsuario.UseVisualStyleBackColor = true;
            this.btnDeleteUsuario.Click += new System.EventHandler(this.btnDeleteUsuario_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(237, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 64);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(237, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(12, 90);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(237, 20);
            this.txtCep.TabIndex = 6;
            // 
            // txtNumeroTelefone
            // 
            this.txtNumeroTelefone.Location = new System.Drawing.Point(12, 116);
            this.txtNumeroTelefone.Name = "txtNumeroTelefone";
            this.txtNumeroTelefone.Size = new System.Drawing.Size(237, 20);
            this.txtNumeroTelefone.TabIndex = 7;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(12, 142);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(237, 20);
            this.txtCpf.TabIndex = 8;
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(12, 168);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(237, 52);
            this.lstUsuarios.TabIndex = 9;
            this.lstUsuarios.SelectedIndexChanged += new System.EventHandler(this.lstUsuarios_SelectedIndexChanged);
            // 
            // UsuarioForm
            // 
            this.ClientSize = new System.Drawing.Size(261, 261);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNumeroTelefone);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnDeleteUsuario);
            this.Controls.Add(this.btnUpdateUsuario);
            this.Controls.Add(this.btnCreateUsuario);
            this.Name = "UsuarioForm";
            this.Text = "User Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}