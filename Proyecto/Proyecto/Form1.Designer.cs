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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 1;
            // 
            // AgregarTarea
            // 
            this.AgregarTarea.Location = new System.Drawing.Point(67, 200);
            this.AgregarTarea.Name = "AgregarTarea";
            this.AgregarTarea.Size = new System.Drawing.Size(108, 37);
            this.AgregarTarea.TabIndex = 2;
            this.AgregarTarea.Text = "AgregarTarea";
            this.AgregarTarea.UseVisualStyleBackColor = true;
            this.AgregarTarea.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditarTarea
            // 
            this.EditarTarea.Location = new System.Drawing.Point(233, 200);
            this.EditarTarea.Name = "EditarTarea";
            this.EditarTarea.Size = new System.Drawing.Size(107, 37);
            this.EditarTarea.TabIndex = 3;
            this.EditarTarea.Text = "EditarTarea";
            this.EditarTarea.UseVisualStyleBackColor = true;
            this.EditarTarea.Click += new System.EventHandler(this.EditarTarea_Click);
            // 
            // EliminarTarea
            // 
            this.EliminarTarea.Location = new System.Drawing.Point(388, 200);
            this.EliminarTarea.Name = "EliminarTarea";
            this.EliminarTarea.Size = new System.Drawing.Size(113, 37);
            this.EliminarTarea.TabIndex = 4;
            this.EliminarTarea.Text = "EliminarTarea";
            this.EliminarTarea.UseVisualStyleBackColor = true;
            // 
            // AgregarEtiqueta
            // 
            this.AgregarEtiqueta.Location = new System.Drawing.Point(67, 297);
            this.AgregarEtiqueta.Name = "AgregarEtiqueta";
            this.AgregarEtiqueta.Size = new System.Drawing.Size(130, 37);
            this.AgregarEtiqueta.TabIndex = 5;
            this.AgregarEtiqueta.Text = "Consultar";
            this.AgregarEtiqueta.UseVisualStyleBackColor = true;
            this.AgregarEtiqueta.Click += new System.EventHandler(this.AgregarEtiqueta_Click);
            // 
            // AgregarResponsable
            // 
            this.AgregarResponsable.Location = new System.Drawing.Point(275, 297);
            this.AgregarResponsable.Name = "AgregarResponsable";
            this.AgregarResponsable.Size = new System.Drawing.Size(154, 37);
            this.AgregarResponsable.TabIndex = 6;
            this.AgregarResponsable.Text = "AgregarResponsable";
            this.AgregarResponsable.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(591, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(537, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(218, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

