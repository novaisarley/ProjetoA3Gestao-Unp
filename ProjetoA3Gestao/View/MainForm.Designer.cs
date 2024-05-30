namespace ProjetoA3Gestao.View
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
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(12, 12);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(260, 23);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Gerenciar Usuários";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageTickets
            // 
            this.btnManageTickets.Location = new System.Drawing.Point(12, 41);
            this.btnManageTickets.Name = "btnManageTickets";
            this.btnManageTickets.Size = new System.Drawing.Size(260, 23);
            this.btnManageTickets.TabIndex = 1;
            this.btnManageTickets.Text = "Gerenciar Tickets";
            this.btnManageTickets.UseVisualStyleBackColor = true;
            this.btnManageTickets.Click += new System.EventHandler(this.btnManageTickets_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnManageTickets);
            this.Controls.Add(this.btnManageUsers);
            this.Name = "MainForm";
            this.Text = "Gerenciador";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageTickets;
    }
}
