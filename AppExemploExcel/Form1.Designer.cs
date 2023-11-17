namespace AppExemploExcel
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btExemploObjeto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(296, 64);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(192, 34);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btListar
            // 
            this.btListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.Location = new System.Drawing.Point(296, 148);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(192, 34);
            this.btListar.TabIndex = 1;
            this.btListar.Text = "LISTAR";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "LISTAR OBJETOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExemploObjeto
            // 
            this.btExemploObjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploObjeto.Location = new System.Drawing.Point(296, 316);
            this.btExemploObjeto.Name = "btExemploObjeto";
            this.btExemploObjeto.Size = new System.Drawing.Size(192, 34);
            this.btExemploObjeto.TabIndex = 3;
            this.btExemploObjeto.Text = "EXEMPLO OBJETO";
            this.btExemploObjeto.UseVisualStyleBackColor = true;
            this.btExemploObjeto.Click += new System.EventHandler(this.btExemploObjeto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExemploObjeto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btCadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btExemploObjeto;
    }
}

