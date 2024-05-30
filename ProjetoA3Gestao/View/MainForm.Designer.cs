namespace ProjetoA3Gestao
{
    partial class MainForm
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
            btnManageUsers = new Button();
            btnCreateTicket = new Button();
            btnUpdateTicket = new Button();
            btnDeleteTicket = new Button();
            txtTitulo = new TextBox();
            txtDescricao = new TextBox();
            txtStatus = new TextBox();
            txtPrioridade = new TextBox();
            lstTickets = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbUsuarios = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(11, 406);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(94, 23);
            btnManageUsers.TabIndex = 8;
            btnManageUsers.Text = "Criar Usuários";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnCreateTicket
            // 
            btnCreateTicket.Location = new Point(11, 365);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.Size = new Size(75, 23);
            btnCreateTicket.TabIndex = 0;
            btnCreateTicket.Text = "Create";
            btnCreateTicket.UseVisualStyleBackColor = true;
            btnCreateTicket.Click += btnCreateTicket_Click;
            // 
            // btnUpdateTicket
            // 
            btnUpdateTicket.Location = new Point(201, 365);
            btnUpdateTicket.Name = "btnUpdateTicket";
            btnUpdateTicket.Size = new Size(75, 23);
            btnUpdateTicket.TabIndex = 1;
            btnUpdateTicket.Text = "Update";
            btnUpdateTicket.UseVisualStyleBackColor = true;
            btnUpdateTicket.Click += btnUpdateTicket_Click;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Location = new Point(377, 365);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(75, 23);
            btnDeleteTicket.TabIndex = 2;
            btnDeleteTicket.Text = "Delete";
            btnDeleteTicket.UseVisualStyleBackColor = true;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(11, 89);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(440, 23);
            txtTitulo.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(11, 133);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(440, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(11, 177);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(440, 23);
            txtStatus.TabIndex = 5;
            // 
            // txtPrioridade
            // 
            txtPrioridade.Location = new Point(11, 221);
            txtPrioridade.Name = "txtPrioridade";
            txtPrioridade.Size = new Size(440, 23);
            txtPrioridade.TabIndex = 6;
            // 
            // lstTickets
            // 
            lstTickets.FormattingEnabled = true;
            lstTickets.ItemHeight = 15;
            lstTickets.Location = new Point(11, 265);
            lstTickets.Name = "lstTickets";
            lstTickets.Size = new Size(440, 94);
            lstTickets.TabIndex = 7;
            lstTickets.SelectedIndexChanged += lstTickets_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 8;
            label1.Text = "Titulo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 115);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 159);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 203);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 11;
            label4.Text = "Prioridade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 247);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 12;
            label5.Text = "Lista de Tickets";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(12, 39);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(237, 23);
            cmbUsuarios.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 13;
            label6.Text = "Usuario";
            // 
            // MainForm
            // 
            ClientSize = new Size(570, 460);
            Controls.Add(label6);
            Controls.Add(cmbUsuarios);
            Controls.Add(btnManageUsers);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstTickets);
            Controls.Add(txtPrioridade);
            Controls.Add(txtStatus);
            Controls.Add(txtDescricao);
            Controls.Add(txtTitulo);
            Controls.Add(btnDeleteTicket);
            Controls.Add(btnUpdateTicket);
            Controls.Add(btnCreateTicket);
            Name = "MainForm";
            Text = "Central de Tickets";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPrioridade;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
