namespace ConexionPstgSQL
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
            this.btn_consulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txBox_consulta = new System.Windows.Forms.TextBox();
            this.tabla_datos = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.txtBox_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_correo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_colegiatura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txtBox_nombreEliminar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txtBox_nombreActualizar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consulta
            // 
            this.btn_consulta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consulta.Location = new System.Drawing.Point(41, 78);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(193, 44);
            this.btn_consulta.TabIndex = 2;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre a buscar:";
            // 
            // txBox_consulta
            // 
            this.txBox_consulta.Location = new System.Drawing.Point(41, 45);
            this.txBox_consulta.Name = "txBox_consulta";
            this.txBox_consulta.Size = new System.Drawing.Size(193, 27);
            this.txBox_consulta.TabIndex = 4;
            // 
            // tabla_datos
            // 
            this.tabla_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_datos.Location = new System.Drawing.Point(302, 12);
            this.tabla_datos.Name = "tabla_datos";
            this.tabla_datos.RowHeadersWidth = 51;
            this.tabla_datos.RowTemplate.Height = 29;
            this.tabla_datos.Size = new System.Drawing.Size(696, 275);
            this.tabla_datos.TabIndex = 5;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.Location = new System.Drawing.Point(41, 323);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(193, 41);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Location = new System.Drawing.Point(440, 337);
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(133, 27);
            this.txtBox_nombre.TabIndex = 8;
            // 
            // txtBox_apellido
            // 
            this.txtBox_apellido.Location = new System.Drawing.Point(595, 337);
            this.txtBox_apellido.Name = "txtBox_apellido";
            this.txtBox_apellido.Size = new System.Drawing.Size(133, 27);
            this.txtBox_apellido.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // txtBox_correo
            // 
            this.txtBox_correo.Location = new System.Drawing.Point(755, 337);
            this.txtBox_correo.Name = "txtBox_correo";
            this.txtBox_correo.Size = new System.Drawing.Size(133, 27);
            this.txtBox_correo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo";
            // 
            // txtBox_colegiatura
            // 
            this.txtBox_colegiatura.Location = new System.Drawing.Point(913, 340);
            this.txtBox_colegiatura.Name = "txtBox_colegiatura";
            this.txtBox_colegiatura.Size = new System.Drawing.Size(133, 27);
            this.txtBox_colegiatura.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(913, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio semestre";
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(279, 337);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(133, 27);
            this.txtBox_id.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar.Location = new System.Drawing.Point(41, 218);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(193, 41);
            this.btn_eliminar.TabIndex = 17;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txtBox_nombreEliminar
            // 
            this.txtBox_nombreEliminar.Location = new System.Drawing.Point(41, 185);
            this.txtBox_nombreEliminar.Name = "txtBox_nombreEliminar";
            this.txtBox_nombreEliminar.Size = new System.Drawing.Size(193, 27);
            this.txtBox_nombreEliminar.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nombre a eliminar";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_actualizar.Location = new System.Drawing.Point(535, 438);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(193, 41);
            this.btn_actualizar.TabIndex = 20;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txtBox_nombreActualizar
            // 
            this.txtBox_nombreActualizar.Location = new System.Drawing.Point(535, 405);
            this.txtBox_nombreActualizar.Name = "txtBox_nombreActualizar";
            this.txtBox_nombreActualizar.Size = new System.Drawing.Size(193, 27);
            this.txtBox_nombreActualizar.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nombre de quien desea actualizar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 509);
            this.Controls.Add(this.txtBox_nombreActualizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txtBox_nombreEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txtBox_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_colegiatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_correo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.tabla_datos);
            this.Controls.Add(this.txBox_consulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consulta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_consulta;
        private Label label1;
        private TextBox txBox_consulta;
        private DataGridView tabla_datos;
        private Button btn_agregar;
        private Label label2;
        private TextBox txtBox_nombre;
        private TextBox txtBox_apellido;
        private Label label3;
        private TextBox txtBox_correo;
        private Label label4;
        private TextBox txtBox_colegiatura;
        private Label label5;
        private TextBox txtBox_id;
        private Label label6;
        private Button btn_eliminar;
        private TextBox txtBox_nombreEliminar;
        private Label label7;
        private Button btn_actualizar;
        private TextBox txtBox_nombreActualizar;
        private Label label8;
    }
}