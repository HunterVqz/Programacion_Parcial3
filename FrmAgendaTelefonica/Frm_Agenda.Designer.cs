namespace FrmAgenda
{
    partial class Frm_Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Agenda));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            dtgAgenda = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtObservaciones = new TextBox();
            rdbMasculino = new RadioButton();
            label9 = new Label();
            rdbFemenino = new RadioButton();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgAgenda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(482, 25);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 0;
            label1.Text = "Agenda Telefónica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 112);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 155);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 1;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 197);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 1;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 240);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 1;
            label5.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 283);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 1;
            label6.Text = "Correo Electrónico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 325);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 1;
            label7.Text = "Dirección:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 368);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 1;
            label8.Text = "Observaciones:";
            // 
            // txtID
            // 
            txtID.Location = new Point(147, 101);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(303, 27);
            txtID.TabIndex = 1;
            // 
            // dtgAgenda
            // 
            dtgAgenda.AllowUserToAddRows = false;
            dtgAgenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAgenda.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, Teléfono, Correo, Direccion, Genero });
            dtgAgenda.Location = new Point(456, 95);
            dtgAgenda.Margin = new Padding(3, 4, 3, 4);
            dtgAgenda.Name = "dtgAgenda";
            dtgAgenda.ReadOnly = true;
            dtgAgenda.RowHeadersVisible = false;
            dtgAgenda.RowHeadersWidth = 51;
            dtgAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAgenda.Size = new Size(816, 326);
            dtgAgenda.TabIndex = 14;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Teléfono
            // 
            Teléfono.HeaderText = "Teléfono";
            Teléfono.MinimumWidth = 6;
            Teléfono.Name = "Teléfono";
            Teléfono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 6;
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 144);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(303, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(147, 187);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(303, 27);
            txtApellido.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(147, 229);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(303, 27);
            txtTelefono.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(147, 272);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(303, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(147, 315);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(303, 27);
            txtDireccion.TabIndex = 6;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(147, 357);
            txtObservaciones.Margin = new Padding(3, 4, 3, 4);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(303, 27);
            txtObservaciones.TabIndex = 7;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(179, 397);
            rdbMasculino.Margin = new Padding(3, 4, 3, 4);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(97, 24);
            rdbMasculino.TabIndex = 8;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(86, 401);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 1;
            label9.Text = "Género:";
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(324, 396);
            rdbFemenino.Margin = new Padding(3, 4, 3, 4);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(95, 24);
            rdbFemenino.TabIndex = 9;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Image = Properties.Resources.Update;
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.Location = new Point(72, 522);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(166, 63);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources.Delete;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(277, 451);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(166, 63);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources.Exit;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(277, 522);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(166, 63);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(72, 451);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(166, 63);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Frm_Agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 600);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(rdbFemenino);
            Controls.Add(rdbMasculino);
            Controls.Add(dtgAgenda);
            Controls.Add(txtObservaciones);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)dtgAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtID;
        private DataGridView dtgAgenda;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtObservaciones;
        private RadioButton rdbMasculino;
        private Label label9;
        private RadioButton rdbFemenino;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Genero;
        private Button btnAgregar;
    }
}
