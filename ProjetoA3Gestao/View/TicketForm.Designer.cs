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
            dgvTickets = new DataGridView();
            cmbUsuarios = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // btnCreateTicket
            // 
            btnCreateTicket.Location = new Point(12, 361);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.Size = new Size(120, 42);
            btnCreateTicket.TabIndex = 0;
            btnCreateTicket.Text = "Create";
            btnCreateTicket.UseVisualStyleBackColor = true;
            btnCreateTicket.Click += btnCreateTicket_Click;
            // 
            // btnUpdateTicket
            // 
            btnUpdateTicket.Location = new Point(213, 361);
            btnUpdateTicket.Name = "btnUpdateTicket";
            btnUpdateTicket.Size = new Size(120, 42);
            btnUpdateTicket.TabIndex = 1;
            btnUpdateTicket.Text = "Update";
            btnUpdateTicket.UseVisualStyleBackColor = true;
            btnUpdateTicket.Click += btnUpdateTicket_Click;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Location = new Point(413, 361);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(120, 42);
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
            txtDescricao.Location = new Point(12, 79);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(521, 23);
            txtDescricao.TabIndex = 4;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(10, 132);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(237, 23);
            cmbStatus.TabIndex = 5;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridade.Location = new Point(296, 131);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(237, 23);
            cmbPrioridade.TabIndex = 6;
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(12, 191);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.Size = new Size(521, 157);
            dgvTickets.TabIndex = 7;
            dgvTickets.SelectionChanged += dgvTickets_SelectionChanged;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(296, 26);
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
            label2.Location = new Point(296, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 10;
            label2.Text = "Responsável";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 114);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 12;
            label4.Text = "Prioridade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 114);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 168);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 14;
            label6.Text = "Tickets";
            // 
            // TicketForm
            // 
            ClientSize = new Size(569, 462);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbUsuarios);
            Controls.Add(dgvTickets);
            Controls.Add(cmbPrioridade);
            Controls.Add(cmbStatus);
            Controls.Add(txtDescricao);
            Controls.Add(txtTitulo);
            Controls.Add(btnDeleteTicket);
            Controls.Add(btnUpdateTicket);
            Controls.Add(btnCreateTicket);
            Name = "TicketForm";
            Text = "Ticket Manager";
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCreateTicket;
        private Button btnUpdateTicket;
        private Button btnDeleteTicket;
        private TextBox txtTitulo;
        private TextBox txtDescricao;
        private ComboBox cmbStatus;
        private ComboBox cmbPrioridade;
        private DataGridView dgvTickets;
        private ComboBox cmbUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
