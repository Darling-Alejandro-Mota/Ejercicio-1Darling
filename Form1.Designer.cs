namespace Ejercicio_1Darling
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
            btn_Motrar = new Button();
            btn_Limpiar = new Button();
            lbl_Datos = new Label();
            txt_Datos = new TextBox();
            txt_Apellido = new TextBox();
            txt_Carrera = new TextBox();
            txt_Matricula = new TextBox();
            txt_Edad = new TextBox();
            txt_Nombre = new TextBox();
            btn_Salir = new Button();
            lbl_carrera = new Label();
            lbl_Matricula = new Label();
            lbl_Edad = new Label();
            lbl_Apellidos = new Label();
            lbl_nombre = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Motrar
            // 
            btn_Motrar.BackColor = SystemColors.Window;
            btn_Motrar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Motrar.Location = new Point(360, 216);
            btn_Motrar.Name = "btn_Motrar";
            btn_Motrar.Size = new Size(75, 43);
            btn_Motrar.TabIndex = 31;
            btn_Motrar.Text = "Mostrar";
            btn_Motrar.UseVisualStyleBackColor = false;
            btn_Motrar.Click += btn_Motrar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.Window;
            btn_Limpiar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Limpiar.Location = new Point(360, 123);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(75, 39);
            btn_Limpiar.TabIndex = 30;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // lbl_Datos
            // 
            lbl_Datos.AutoSize = true;
            lbl_Datos.Location = new Point(30, 316);
            lbl_Datos.Name = "lbl_Datos";
            lbl_Datos.Size = new Size(37, 15);
            lbl_Datos.TabIndex = 29;
            lbl_Datos.Text = "Datos";
            // 
            // txt_Datos
            // 
            txt_Datos.Location = new Point(84, 313);
            txt_Datos.Name = "txt_Datos";
            txt_Datos.Size = new Size(233, 23);
            txt_Datos.TabIndex = 28;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(217, 132);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(100, 23);
            txt_Apellido.TabIndex = 27;
            // 
            // txt_Carrera
            // 
            txt_Carrera.Location = new Point(217, 264);
            txt_Carrera.Name = "txt_Carrera";
            txt_Carrera.Size = new Size(100, 23);
            txt_Carrera.TabIndex = 26;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(217, 216);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(100, 23);
            txt_Matricula.TabIndex = 25;
            // 
            // txt_Edad
            // 
            txt_Edad.Location = new Point(217, 177);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(100, 23);
            txt_Edad.TabIndex = 24;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(217, 90);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 23;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = SystemColors.Window;
            btn_Salir.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Salir.Location = new Point(30, 22);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(75, 37);
            btn_Salir.TabIndex = 22;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // lbl_carrera
            // 
            lbl_carrera.AutoSize = true;
            lbl_carrera.Location = new Point(68, 267);
            lbl_carrera.Name = "lbl_carrera";
            lbl_carrera.Size = new Size(45, 15);
            lbl_carrera.TabIndex = 21;
            lbl_carrera.Text = "Carrera";
            // 
            // lbl_Matricula
            // 
            lbl_Matricula.AutoSize = true;
            lbl_Matricula.Location = new Point(68, 224);
            lbl_Matricula.Name = "lbl_Matricula";
            lbl_Matricula.Size = new Size(57, 15);
            lbl_Matricula.TabIndex = 20;
            lbl_Matricula.Text = "Matricula";
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Location = new Point(68, 177);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(33, 15);
            lbl_Edad.TabIndex = 19;
            lbl_Edad.Text = "Edad";
            // 
            // lbl_Apellidos
            // 
            lbl_Apellidos.AutoSize = true;
            lbl_Apellidos.Location = new Point(68, 132);
            lbl_Apellidos.Name = "lbl_Apellidos";
            lbl_Apellidos.Size = new Size(59, 15);
            lbl_Apellidos.TabIndex = 18;
            lbl_Apellidos.Text = "Apellidos ";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(68, 93);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 17;
            lbl_nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 22);
            label1.Name = "label1";
            label1.Size = new Size(189, 29);
            label1.TabIndex = 32;
            label1.Text = "Estudiante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(469, 367);
            Controls.Add(label1);
            Controls.Add(btn_Motrar);
            Controls.Add(btn_Limpiar);
            Controls.Add(lbl_Datos);
            Controls.Add(txt_Datos);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Carrera);
            Controls.Add(txt_Matricula);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Nombre);
            Controls.Add(btn_Salir);
            Controls.Add(lbl_carrera);
            Controls.Add(lbl_Matricula);
            Controls.Add(lbl_Edad);
            Controls.Add(lbl_Apellidos);
            Controls.Add(lbl_nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Motrar;
        private Button btn_Limpiar;
        private Label lbl_Datos;
        private TextBox txt_Datos;
        private TextBox txt_Apellido;
        private TextBox txt_Carrera;
        private TextBox txt_Matricula;
        private TextBox txt_Edad;
        private TextBox txt_Nombre;
        private Button btn_Salir;
        private Label lbl_carrera;
        private Label lbl_Matricula;
        private Label lbl_Edad;
        private Label lbl_Apellidos;
        private Label lbl_nombre;
        private Label label1;
    }
}
