namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AgregarTarea = new System.Windows.Forms.Button();
            this.EditarTarea = new System.Windows.Forms.Button();
            this.EliminarTarea = new System.Windows.Forms.Button();
            this.AgregarEtiqueta = new System.Windows.Forms.Button();
            this.AgregarResponsable = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 1;
            // 
            // AgregarTarea
            // 
            this.AgregarTarea.Location = new System.Drawing.Point(67, 200);
            this.AgregarTarea.Name = "AgregarTarea";
            this.AgregarTarea.Size = new System.Drawing.Size(154, 37);
            this.AgregarTarea.TabIndex = 2;
            this.AgregarTarea.Text = "AgregarTarea";
            this.AgregarTarea.UseVisualStyleBackColor = true;
            this.AgregarTarea.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditarTarea
            // 
            this.EditarTarea.Location = new System.Drawing.Point(67, 272);
            this.EditarTarea.Name = "EditarTarea";
            this.EditarTarea.Size = new System.Drawing.Size(154, 37);
            this.EditarTarea.TabIndex = 3;
            this.EditarTarea.Text = "EditarTarea";
            this.EditarTarea.UseVisualStyleBackColor = true;
            this.EditarTarea.Click += new System.EventHandler(this.EditarTarea_Click);
            // 
            // EliminarTarea
            // 
            this.EliminarTarea.Location = new System.Drawing.Point(67, 338);
            this.EliminarTarea.Name = "EliminarTarea";
            this.EliminarTarea.Size = new System.Drawing.Size(154, 37);
            this.EliminarTarea.TabIndex = 4;
            this.EliminarTarea.Text = "EliminarTarea";
            this.EliminarTarea.UseVisualStyleBackColor = true;
            // 
            // AgregarEtiqueta
            // 
            this.AgregarEtiqueta.Location = new System.Drawing.Point(67, 391);
            this.AgregarEtiqueta.Name = "AgregarEtiqueta";
            this.AgregarEtiqueta.Size = new System.Drawing.Size(154, 37);
            this.AgregarEtiqueta.TabIndex = 5;
            this.AgregarEtiqueta.Text = "Consultar";
            this.AgregarEtiqueta.UseVisualStyleBackColor = true;
            this.AgregarEtiqueta.Click += new System.EventHandler(this.AgregarEtiqueta_Click);
            // 
            // AgregarResponsable
            // 
            this.AgregarResponsable.Location = new System.Drawing.Point(67, 457);
            this.AgregarResponsable.Name = "AgregarResponsable";
            this.AgregarResponsable.Size = new System.Drawing.Size(154, 37);
            this.AgregarResponsable.TabIndex = 6;
            this.AgregarResponsable.Text = "AgregarResponsable";
            this.AgregarResponsable.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(422, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(599, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Tarea";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prioridad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Estado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Responsable";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(411, 190);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 22);
            this.textBox5.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 536);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.AgregarResponsable);
            this.Controls.Add(this.AgregarEtiqueta);
            this.Controls.Add(this.EliminarTarea);
            this.Controls.Add(this.EditarTarea);
            this.Controls.Add(this.AgregarTarea);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AgregarTarea;
        private System.Windows.Forms.Button EditarTarea;
        private System.Windows.Forms.Button EliminarTarea;
        private System.Windows.Forms.Button AgregarEtiqueta;
        private System.Windows.Forms.Button AgregarResponsable;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
    }
}

