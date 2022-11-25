namespace Benjamin_Miranda_PRUEBA
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.cmbox_Hora = new System.Windows.Forms.ComboBox();
            this.mthCa_Fecha = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cmbox_Rut_E = new System.Windows.Forms.ComboBox();
            this.txbox_Email_E = new System.Windows.Forms.TextBox();
            this.txbox_Celular_E = new System.Windows.Forms.TextBox();
            this.txbox_Nombre_E = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbox_Email = new System.Windows.Forms.TextBox();
            this.txbox_Celular = new System.Windows.Forms.TextBox();
            this.txbox_Nombre = new System.Windows.Forms.TextBox();
            this.txbox_Rut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbox_Barba = new System.Windows.Forms.CheckBox();
            this.chbox_Cabello = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lst_Mostrar = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAficheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barberiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(63, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 631);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Ingresar);
            this.tabPage1.Controls.Add(this.btn_Salir);
            this.tabPage1.Controls.Add(this.btn_Limpiar);
            this.tabPage1.Controls.Add(this.cmbox_Hora);
            this.tabPage1.Controls.Add(this.mthCa_Fecha);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chbox_Barba);
            this.tabPage1.Controls.Add(this.chbox_Cabello);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Reservas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(487, 140);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(304, 48);
            this.btn_Ingresar.TabIndex = 31;
            this.btn_Ingresar.Text = "Ingresar Reserva";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(669, 206);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(122, 35);
            this.btn_Salir.TabIndex = 30;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(487, 206);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(129, 35);
            this.btn_Limpiar.TabIndex = 29;
            this.btn_Limpiar.Text = "Limpiar Formulario";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // cmbox_Hora
            // 
            this.cmbox_Hora.FormattingEnabled = true;
            this.cmbox_Hora.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            ""});
            this.cmbox_Hora.Location = new System.Drawing.Point(487, 68);
            this.cmbox_Hora.Name = "cmbox_Hora";
            this.cmbox_Hora.Size = new System.Drawing.Size(121, 24);
            this.cmbox_Hora.TabIndex = 28;
            this.cmbox_Hora.Text = "HORA:";
            // 
            // mthCa_Fecha
            // 
            this.mthCa_Fecha.Location = new System.Drawing.Point(113, 68);
            this.mthCa_Fecha.Name = "mthCa_Fecha";
            this.mthCa_Fecha.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Buscar);
            this.groupBox3.Controls.Add(this.cmbox_Rut_E);
            this.groupBox3.Controls.Add(this.txbox_Email_E);
            this.groupBox3.Controls.Add(this.txbox_Celular_E);
            this.groupBox3.Controls.Add(this.txbox_Nombre_E);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(487, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 256);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente Existente";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(274, 37);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 16;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cmbox_Rut_E
            // 
            this.cmbox_Rut_E.FormattingEnabled = true;
            this.cmbox_Rut_E.Location = new System.Drawing.Point(122, 37);
            this.cmbox_Rut_E.Name = "cmbox_Rut_E";
            this.cmbox_Rut_E.Size = new System.Drawing.Size(121, 24);
            this.cmbox_Rut_E.TabIndex = 15;
            // 
            // txbox_Email_E
            // 
            this.txbox_Email_E.Location = new System.Drawing.Point(122, 168);
            this.txbox_Email_E.Name = "txbox_Email_E";
            this.txbox_Email_E.Size = new System.Drawing.Size(201, 22);
            this.txbox_Email_E.TabIndex = 14;
            // 
            // txbox_Celular_E
            // 
            this.txbox_Celular_E.Location = new System.Drawing.Point(122, 128);
            this.txbox_Celular_E.Name = "txbox_Celular_E";
            this.txbox_Celular_E.Size = new System.Drawing.Size(122, 22);
            this.txbox_Celular_E.TabIndex = 13;
            // 
            // txbox_Nombre_E
            // 
            this.txbox_Nombre_E.Location = new System.Drawing.Point(122, 82);
            this.txbox_Nombre_E.Name = "txbox_Nombre_E";
            this.txbox_Nombre_E.Size = new System.Drawing.Size(201, 22);
            this.txbox_Nombre_E.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "E-Mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "RUT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Celular";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbox_Email);
            this.groupBox1.Controls.Add(this.txbox_Celular);
            this.groupBox1.Controls.Add(this.txbox_Nombre);
            this.groupBox1.Controls.Add(this.txbox_Rut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(19, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 256);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente Nuevo";
            // 
            // txbox_Email
            // 
            this.txbox_Email.Location = new System.Drawing.Point(116, 168);
            this.txbox_Email.Name = "txbox_Email";
            this.txbox_Email.Size = new System.Drawing.Size(201, 22);
            this.txbox_Email.TabIndex = 14;
            // 
            // txbox_Celular
            // 
            this.txbox_Celular.Location = new System.Drawing.Point(116, 128);
            this.txbox_Celular.Name = "txbox_Celular";
            this.txbox_Celular.Size = new System.Drawing.Size(122, 22);
            this.txbox_Celular.TabIndex = 13;
            // 
            // txbox_Nombre
            // 
            this.txbox_Nombre.Location = new System.Drawing.Point(116, 82);
            this.txbox_Nombre.Name = "txbox_Nombre";
            this.txbox_Nombre.Size = new System.Drawing.Size(201, 22);
            this.txbox_Nombre.TabIndex = 12;
            // 
            // txbox_Rut
            // 
            this.txbox_Rut.Location = new System.Drawing.Point(116, 39);
            this.txbox_Rut.Name = "txbox_Rut";
            this.txbox_Rut.Size = new System.Drawing.Size(122, 22);
            this.txbox_Rut.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "RUT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha y Hora:";
            // 
            // chbox_Barba
            // 
            this.chbox_Barba.AutoSize = true;
            this.chbox_Barba.Location = new System.Drawing.Point(510, 12);
            this.chbox_Barba.Name = "chbox_Barba";
            this.chbox_Barba.Size = new System.Drawing.Size(66, 20);
            this.chbox_Barba.TabIndex = 23;
            this.chbox_Barba.Text = "Barba";
            this.chbox_Barba.UseVisualStyleBackColor = true;
            // 
            // chbox_Cabello
            // 
            this.chbox_Cabello.AutoSize = true;
            this.chbox_Cabello.Location = new System.Drawing.Point(385, 12);
            this.chbox_Cabello.Name = "chbox_Cabello";
            this.chbox_Cabello.Size = new System.Drawing.Size(76, 20);
            this.chbox_Cabello.TabIndex = 22;
            this.chbox_Cabello.Text = "Cabello";
            this.chbox_Cabello.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo de Atención:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lst_Mostrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(883, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mostrar Reservas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lst_Mostrar
            // 
            this.lst_Mostrar.HideSelection = false;
            this.lst_Mostrar.Location = new System.Drawing.Point(3, 6);
            this.lst_Mostrar.Name = "lst_Mostrar";
            this.lst_Mostrar.Size = new System.Drawing.Size(874, 590);
            this.lst_Mostrar.TabIndex = 0;
            this.lst_Mostrar.UseCompatibleStateImageBehavior = false;
            this.lst_Mostrar.View = System.Windows.Forms.View.List;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.publicidadToolStripMenuItem,
            this.barberiaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.atencionesToolStripMenuItem});
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // atencionesToolStripMenuItem
            // 
            this.atencionesToolStripMenuItem.Name = "atencionesToolStripMenuItem";
            this.atencionesToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.atencionesToolStripMenuItem.Text = "Atenciones";
            this.atencionesToolStripMenuItem.Click += new System.EventHandler(this.atencionesToolStripMenuItem_Click);
            // 
            // publicidadToolStripMenuItem
            // 
            this.publicidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAficheToolStripMenuItem});
            this.publicidadToolStripMenuItem.Name = "publicidadToolStripMenuItem";
            this.publicidadToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.publicidadToolStripMenuItem.Text = "Publicidad";
            // 
            // crearAficheToolStripMenuItem
            // 
            this.crearAficheToolStripMenuItem.Name = "crearAficheToolStripMenuItem";
            this.crearAficheToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.crearAficheToolStripMenuItem.Text = "Crear Afiche";
            this.crearAficheToolStripMenuItem.Click += new System.EventHandler(this.crearAficheToolStripMenuItem_Click);
            // 
            // barberiaToolStripMenuItem
            // 
            this.barberiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.barberiaToolStripMenuItem.Name = "barberiaToolStripMenuItem";
            this.barberiaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.barberiaToolStripMenuItem.Text = "Barberia";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Barbería";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ComboBox cmbox_Hora;
        private System.Windows.Forms.MonthCalendar mthCa_Fecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cmbox_Rut_E;
        private System.Windows.Forms.TextBox txbox_Email_E;
        private System.Windows.Forms.TextBox txbox_Celular_E;
        private System.Windows.Forms.TextBox txbox_Nombre_E;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbox_Email;
        private System.Windows.Forms.TextBox txbox_Celular;
        private System.Windows.Forms.TextBox txbox_Nombre;
        private System.Windows.Forms.TextBox txbox_Rut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbox_Barba;
        private System.Windows.Forms.CheckBox chbox_Cabello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lst_Mostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atencionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barberiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAficheToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

