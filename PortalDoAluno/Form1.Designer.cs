namespace PortalDoAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label_titulo = new Label();
            label_nome = new Label();
            label_idade = new Label();
            label_curso = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lv_alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            txt_nome = new TextBox();
            txt_idade = new TextBox();
            txt_curso = new TextBox();
            btn_confirmar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.BackColor = Color.Transparent;
            label_titulo.Font = new Font("Segoe UI", 16F);
            label_titulo.Location = new Point(25, 23);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(118, 30);
            label_titulo.TabIndex = 0;
            label_titulo.Text = "Formulario";
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.BackColor = Color.Transparent;
            label_nome.Font = new Font("Segoe UI", 12F);
            label_nome.Location = new Point(25, 68);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(53, 21);
            label_nome.TabIndex = 1;
            label_nome.Text = "Nome";
            label_nome.Click += label2_Click;
            // 
            // label_idade
            // 
            label_idade.AutoSize = true;
            label_idade.BackColor = Color.Transparent;
            label_idade.Font = new Font("Segoe UI", 12F);
            label_idade.Location = new Point(30, 126);
            label_idade.Name = "label_idade";
            label_idade.Size = new Size(48, 21);
            label_idade.TabIndex = 2;
            label_idade.Text = "Idade";
            label_idade.Click += label3_Click;
            // 
            // label_curso
            // 
            label_curso.AutoSize = true;
            label_curso.BackColor = Color.Transparent;
            label_curso.Font = new Font("Segoe UI", 12F);
            label_curso.Location = new Point(30, 187);
            label_curso.Name = "label_curso";
            label_curso.Size = new Size(51, 21);
            label_curso.TabIndex = 3;
            label_curso.Text = "Curso";
            label_curso.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(352, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 455);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(15, 26);
            label5.Name = "label5";
            label5.Size = new Size(154, 30);
            label5.TabIndex = 9;
            label5.Text = "Lista de alunos";
            label5.Click += label5_Click;
            // 
            // lv_alunos
            // 
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv_alunos.Location = new Point(15, 95);
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(421, 346);
            lv_alunos.TabIndex = 0;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 120;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 120;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(30, 92);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(164, 23);
            txt_nome.TabIndex = 9;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(30, 150);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(164, 23);
            txt_idade.TabIndex = 10;
            // 
            // txt_curso
            // 
            txt_curso.Location = new Point(30, 211);
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(164, 23);
            txt_curso.TabIndex = 11;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(68, 290);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(75, 23);
            btn_confirmar.TabIndex = 12;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_confirmar);
            Controls.Add(txt_curso);
            Controls.Add(txt_idade);
            Controls.Add(txt_nome);
            Controls.Add(panel1);
            Controls.Add(label_curso);
            Controls.Add(label_idade);
            Controls.Add(label_nome);
            Controls.Add(label_titulo);
            Name = "Form1";
            Text = "Formulario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo;
        private Label label_nome;
        private Label label_idade;
        private Label label_curso;
        private Panel panel1;
        private Label label5;
        private ListView lv_alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_curso;
        private Button btn_confirmar;
    }
}
