namespace ProjetoSQL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTarefas = new System.Windows.Forms.DataGridView();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.chkCompleta = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Gadugi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarefas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(98, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(98, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = " Título da Taefa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(98, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição da tarefa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(670, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tarefa";
            // 
            // dataGridViewTarefas
            // 
            this.dataGridViewTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarefas.Location = new System.Drawing.Point(563, 168);
            this.dataGridViewTarefas.Name = "dataGridViewTarefas";
            this.dataGridViewTarefas.Size = new System.Drawing.Size(269, 130);
            this.dataGridViewTarefas.TabIndex = 5;
            this.dataGridViewTarefas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarefas_CellClick);
            this.dataGridViewTarefas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarefas_CellClick);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(102, 204);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(254, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 140);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(52, 25);
            this.txtID.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(102, 275);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(254, 108);
            this.txtDescricao.TabIndex = 8;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.Green;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInserir.Location = new System.Drawing.Point(127, 389);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(67, 50);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Maroon;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(251, 389);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 50);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualizar.Location = new System.Drawing.Point(674, 304);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(56, 51);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // chkCompleta
            // 
            this.chkCompleta.AutoSize = true;
            this.chkCompleta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkCompleta.Location = new System.Drawing.Point(379, 364);
            this.chkCompleta.Name = "chkCompleta";
            this.chkCompleta.Size = new System.Drawing.Size(70, 17);
            this.chkCompleta.TabIndex = 13;
            this.chkCompleta.Text = "Completa";
            this.chkCompleta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 610);
            this.Controls.Add(this.chkCompleta);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.dataGridViewTarefas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewTarefas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.CheckBox chkCompleta;
    }
}

