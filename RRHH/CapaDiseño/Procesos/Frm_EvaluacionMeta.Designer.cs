﻿namespace CapaDiseño.Procesos
{
    partial class Frm_EvaluacionMeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EvaluacionMeta));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.lbl_Desempeño = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_Codigo = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Puntuacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gb_Asignacion = new System.Windows.Forms.GroupBox();
            this.Btn_CodMeta = new System.Windows.Forms.Button();
            this.Btn_CodEmp = new System.Windows.Forms.Button();
            this.Dtp_Asignacion = new System.Windows.Forms.DateTimePicker();
            this.Txt_CodMeta = new System.Windows.Forms.TextBox();
            this.Txt_CodEmpleado = new System.Windows.Forms.TextBox();
            this.Txt_Cod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Dtp_Realizacion = new System.Windows.Forms.DateTimePicker();
            this.Txt_Puntuacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_fecharealizacion = new System.Windows.Forms.Label();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.Btn_Desempeño = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.Gb_Asignacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(107)))), ((int)(((byte)(44)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lbl_Desempeño);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 1);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1072, 51);
            this.Pnl_nombreForm.TabIndex = 43;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(749, 8);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(714, 8);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // lbl_Desempeño
            // 
            this.lbl_Desempeño.AutoSize = true;
            this.lbl_Desempeño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desempeño.ForeColor = System.Drawing.Color.White;
            this.lbl_Desempeño.Location = new System.Drawing.Point(26, 12);
            this.lbl_Desempeño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Desempeño.Name = "lbl_Desempeño";
            this.lbl_Desempeño.Size = new System.Drawing.Size(272, 20);
            this.lbl_Desempeño.TabIndex = 0;
            this.lbl_Desempeño.Text = "Asignacion y Evaluacion de Meta";
            this.lbl_Desempeño.Click += new System.EventHandler(this.Lbl_procesonominal_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(787, 8);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_Codigo
            // 
            this.Lbl_Codigo.AutoSize = true;
            this.Lbl_Codigo.Location = new System.Drawing.Point(15, 37);
            this.Lbl_Codigo.Name = "Lbl_Codigo";
            this.Lbl_Codigo.Size = new System.Drawing.Size(96, 13);
            this.Lbl_Codigo.TabIndex = 44;
            this.Lbl_Codigo.Text = "Codigo Evaluacion";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Location = new System.Drawing.Point(19, 219);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(92, 13);
            this.Lbl_Fecha.TabIndex = 45;
            this.Lbl_Fecha.Text = "Fecha Asignación";
            // 
            // Lbl_Puntuacion
            // 
            this.Lbl_Puntuacion.AutoSize = true;
            this.Lbl_Puntuacion.Location = new System.Drawing.Point(14, 59);
            this.Lbl_Puntuacion.Name = "Lbl_Puntuacion";
            this.Lbl_Puntuacion.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Puntuacion.TabIndex = 46;
            this.Lbl_Puntuacion.Text = "Puntuación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Codigo Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Codigo Meta";
            // 
            // Gb_Asignacion
            // 
            this.Gb_Asignacion.Controls.Add(this.Btn_CodMeta);
            this.Gb_Asignacion.Controls.Add(this.Btn_CodEmp);
            this.Gb_Asignacion.Controls.Add(this.Dtp_Asignacion);
            this.Gb_Asignacion.Controls.Add(this.Txt_CodMeta);
            this.Gb_Asignacion.Controls.Add(this.Txt_CodEmpleado);
            this.Gb_Asignacion.Controls.Add(this.Txt_Cod);
            this.Gb_Asignacion.Controls.Add(this.Lbl_Codigo);
            this.Gb_Asignacion.Controls.Add(this.label2);
            this.Gb_Asignacion.Controls.Add(this.Lbl_Fecha);
            this.Gb_Asignacion.Controls.Add(this.label1);
            this.Gb_Asignacion.Location = new System.Drawing.Point(30, 107);
            this.Gb_Asignacion.Name = "Gb_Asignacion";
            this.Gb_Asignacion.Size = new System.Drawing.Size(394, 313);
            this.Gb_Asignacion.TabIndex = 49;
            this.Gb_Asignacion.TabStop = false;
            this.Gb_Asignacion.Text = "Asignacion";
            // 
            // Btn_CodMeta
            // 
            this.Btn_CodMeta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CodMeta.Image")));
            this.Btn_CodMeta.Location = new System.Drawing.Point(331, 144);
            this.Btn_CodMeta.Name = "Btn_CodMeta";
            this.Btn_CodMeta.Size = new System.Drawing.Size(44, 42);
            this.Btn_CodMeta.TabIndex = 54;
            this.Btn_CodMeta.UseVisualStyleBackColor = true;
            this.Btn_CodMeta.Click += new System.EventHandler(this.Btn_CodMeta_Click);
            // 
            // Btn_CodEmp
            // 
            this.Btn_CodEmp.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CodEmp.Image")));
            this.Btn_CodEmp.Location = new System.Drawing.Point(331, 79);
            this.Btn_CodEmp.Name = "Btn_CodEmp";
            this.Btn_CodEmp.Size = new System.Drawing.Size(44, 44);
            this.Btn_CodEmp.TabIndex = 53;
            this.Btn_CodEmp.UseVisualStyleBackColor = true;
            this.Btn_CodEmp.Click += new System.EventHandler(this.Btn_CodEmp_Click);
            // 
            // Dtp_Asignacion
            // 
            this.Dtp_Asignacion.Location = new System.Drawing.Point(132, 215);
            this.Dtp_Asignacion.Name = "Dtp_Asignacion";
            this.Dtp_Asignacion.Size = new System.Drawing.Size(243, 20);
            this.Dtp_Asignacion.TabIndex = 52;
            // 
            // Txt_CodMeta
            // 
            this.Txt_CodMeta.Location = new System.Drawing.Point(130, 152);
            this.Txt_CodMeta.Name = "Txt_CodMeta";
            this.Txt_CodMeta.Size = new System.Drawing.Size(187, 20);
            this.Txt_CodMeta.TabIndex = 51;
            // 
            // Txt_CodEmpleado
            // 
            this.Txt_CodEmpleado.Location = new System.Drawing.Point(130, 92);
            this.Txt_CodEmpleado.Name = "Txt_CodEmpleado";
            this.Txt_CodEmpleado.Size = new System.Drawing.Size(187, 20);
            this.Txt_CodEmpleado.TabIndex = 50;
            // 
            // Txt_Cod
            // 
            this.Txt_Cod.Location = new System.Drawing.Point(130, 30);
            this.Txt_Cod.Name = "Txt_Cod";
            this.Txt_Cod.Size = new System.Drawing.Size(187, 20);
            this.Txt_Cod.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbo_Estado);
            this.groupBox1.Controls.Add(this.Dtp_Realizacion);
            this.groupBox1.Controls.Add(this.Txt_Puntuacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Lbl_fecharealizacion);
            this.groupBox1.Controls.Add(this.Lbl_Puntuacion);
            this.groupBox1.Location = new System.Drawing.Point(461, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 312);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluacion";
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(147, 176);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(212, 21);
            this.Cbo_Estado.TabIndex = 54;
            // 
            // Dtp_Realizacion
            // 
            this.Dtp_Realizacion.Location = new System.Drawing.Point(145, 111);
            this.Dtp_Realizacion.Name = "Dtp_Realizacion";
            this.Dtp_Realizacion.Size = new System.Drawing.Size(215, 20);
            this.Dtp_Realizacion.TabIndex = 53;
            // 
            // Txt_Puntuacion
            // 
            this.Txt_Puntuacion.Location = new System.Drawing.Point(145, 52);
            this.Txt_Puntuacion.Name = "Txt_Puntuacion";
            this.Txt_Puntuacion.Size = new System.Drawing.Size(215, 20);
            this.Txt_Puntuacion.TabIndex = 50;
            this.Txt_Puntuacion.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Estado_Completado";
            // 
            // Lbl_fecharealizacion
            // 
            this.Lbl_fecharealizacion.AutoSize = true;
            this.Lbl_fecharealizacion.Location = new System.Drawing.Point(14, 114);
            this.Lbl_fecharealizacion.Name = "Lbl_fecharealizacion";
            this.Lbl_fecharealizacion.Size = new System.Drawing.Size(110, 13);
            this.Lbl_fecharealizacion.TabIndex = 47;
            this.Lbl_fecharealizacion.Text = "Fecha de Realizacion";
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.Location = new System.Drawing.Point(326, 450);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(118, 47);
            this.Btn_Insertar.TabIndex = 51;
            this.Btn_Insertar.Text = "Insertar";
            this.Btn_Insertar.UseVisualStyleBackColor = true;
            this.Btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // Btn_Desempeño
            // 
            this.Btn_Desempeño.Location = new System.Drawing.Point(595, 450);
            this.Btn_Desempeño.Name = "Btn_Desempeño";
            this.Btn_Desempeño.Size = new System.Drawing.Size(118, 47);
            this.Btn_Desempeño.TabIndex = 52;
            this.Btn_Desempeño.Text = "Desempeño Empleado";
            this.Btn_Desempeño.UseVisualStyleBackColor = true;
            this.Btn_Desempeño.Click += new System.EventHandler(this.Btn_Desempeño_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(461, 450);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(118, 47);
            this.Btn_Modificar.TabIndex = 53;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Location = new System.Drawing.Point(192, 450);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(118, 47);
            this.Btn_Ingresar.TabIndex = 54;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Frm_EvaluacionMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 527);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Desempeño);
            this.Controls.Add(this.Btn_Insertar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gb_Asignacion);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EvaluacionMeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DesempeñodeEmpleado";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.Gb_Asignacion.ResumeLayout(false);
            this.Gb_Asignacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label lbl_Desempeño;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label Lbl_Codigo;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Puntuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Gb_Asignacion;
        private System.Windows.Forms.Button Btn_CodMeta;
        private System.Windows.Forms.Button Btn_CodEmp;
        private System.Windows.Forms.DateTimePicker Dtp_Asignacion;
        private System.Windows.Forms.TextBox Txt_CodMeta;
        private System.Windows.Forms.TextBox Txt_CodEmpleado;
        private System.Windows.Forms.TextBox Txt_Cod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Puntuacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_fecharealizacion;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_Realizacion;
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.Button Btn_Desempeño;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Ingresar;
    }
}