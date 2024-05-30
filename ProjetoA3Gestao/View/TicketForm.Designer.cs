namespace ProjetoA3Gestao
{
    partial class TicketForm
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
            btnCreateTicket = new Button();
            btnUpdateTicket = new Button();
            btnDeleteTicket = new Button();
            txtTitulo = new TextBox();
            txtDescricao = new TextBox();
            cmbStatus = new ComboBox();
            cmbPrioridade = new ComboBox();
            lstTickets = new ListBox();
            cmbUsuarios = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnCreateTicket
            // 
            btnCreateTicket.Location = new Point(12, 371);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.Size = new Size(75, 25);
            btnCreateTicket.TabIndex = 0;
            btnCreateTicket.Text = "Create";
            btnCreateTicket.UseVisualStyleBackColor = true;
            btnCreateTicket.Click += btnCreateTicket_Click;
            // 
            // btnUpdateTicket
            // 
            btnUpdateTicket.Location = new Point(93, 371);
            btnUpdateTicket.Name = "btnUpdateTicket";
            btnUpdateTicket.Size = new Size(75, 25);
            btnUpdateTicket.TabIndex = 1;
            btnUpdateTicket.Text = "Update";
            btnUpdateTicket.UseVisualStyleBackColor = true;
            btnUpdateTicket.Click += btnUpdateTicket_Click;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Location = new Point(174, 371);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(75, 25);
            btnDeleteTicket.TabIndex = 2;
            btnDeleteTicket.Text = "Delete";
            btnDeleteTicket.UseVisualStyleBackColor = true;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 26);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(237, 23);
            txtTitulo.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 114);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(237, 23);
            txtDescricao.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.Location = new Point(12, 160);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(237, 23);
            cmbStatus.TabIndex = 5;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.Location = new Point(12, 203);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(237, 23);
            cmbPrioridade.TabIndex = 6;
            // 
            // lstTickets
            // 
            lstTickets.FormattingEnabled = true;
            lstTickets.ItemHeight = 15;
            lstTickets.Location = new Point(12, 263);
            lstTickets.Name = "lstTickets";
            lstTickets.Size = new Size(237, 94);
            lstTickets.TabIndex = 7;
            lstTickets.SelectedIndexChanged += lstTickets_SelectedIndexChanged;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(12, 69);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(237, 23);
            cmbUsuarios.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 9;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 10;
            label2.Text = "Responsável";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 12;
            label4.Text = "Prioridade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 142);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 14;
            label6.Text = "Tickets";
            // 
            // TicketForm
            // 
            ClientSize = new Size(269, 412);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbUsuarios);
            Controls.Add(lstTickets);
            Controls.Add(cmbPrioridade);
            Controls.Add(cmbStatus);
            Controls.Add(txtDescricao);
            Controls.Add(txtTitulo);
            Controls.Add(btnDeleteTicket);
            Controls.Add(btnUpdateTicket);
            Controls.Add(btnCreateTicket);
            Name = "TicketForm";
            Text = "Ticket Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.ComboBox cmbUsuarios; // Novo ComboBox para selecionar usuário
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
