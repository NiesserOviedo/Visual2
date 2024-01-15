namespace Practica_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ordenTotalR = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVer = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.barradeherramientas = new System.Windows.Forms.ToolStrip();
            this.nuevo = new System.Windows.Forms.ToolStripButton();
            this.guardar = new System.Windows.Forms.ToolStripButton();
            this.cancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Busca = new System.Windows.Forms.ToolStripLabel();
            this.buscador = new System.Windows.Forms.ToolStripTextBox();
            this.buscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.barradeestado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.barradeherramientas.SuspendLayout();
            this.barradeestado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuOperaciones,
            this.menuVer,
            this.menuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenSalir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            this.menuArchivo.DropDownClosed += new System.EventHandler(this.menuArchivo_DropDownClosed);
            this.menuArchivo.DropDownOpened += new System.EventHandler(this.menuArchivo_DropDownOpened);
            this.menuArchivo.Click += new System.EventHandler(this.menuArchivo_Click);
            // 
            // ordenSalir
            // 
            this.ordenSalir.Name = "ordenSalir";
            this.ordenSalir.Size = new System.Drawing.Size(133, 22);
            this.ordenSalir.Text = "Salir Ctrl+X";
            this.ordenSalir.Click += new System.EventHandler(this.ordenSalir_Click);
            // 
            // menuOperaciones
            // 
            this.menuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenNuevo,
            this.ordenGuardar,
            this.ordenCancelar,
            this.toolStripSeparator1,
            this.ordenTotalR});
            this.menuOperaciones.Name = "menuOperaciones";
            this.menuOperaciones.Size = new System.Drawing.Size(85, 20);
            this.menuOperaciones.Text = "Operaciones";
            this.menuOperaciones.Click += new System.EventHandler(this.menuOperaciones_Click_1);
            this.menuOperaciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuOperaciones_MouseDown);
            // 
            // ordenNuevo
            // 
            this.ordenNuevo.Name = "ordenNuevo";
            this.ordenNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ordenNuevo.Size = new System.Drawing.Size(204, 22);
            this.ordenNuevo.Text = "Nuevo Producto";
            this.ordenNuevo.Click += new System.EventHandler(this.ordenNuevo_Click);
            // 
            // ordenGuardar
            // 
            this.ordenGuardar.Enabled = false;
            this.ordenGuardar.Name = "ordenGuardar";
            this.ordenGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.ordenGuardar.Size = new System.Drawing.Size(204, 22);
            this.ordenGuardar.Text = "Guardar";
            this.ordenGuardar.Click += new System.EventHandler(this.ordenGuardar_Click);
            // 
            // ordenCancelar
            // 
            this.ordenCancelar.Enabled = false;
            this.ordenCancelar.Name = "ordenCancelar";
            this.ordenCancelar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.ordenCancelar.Size = new System.Drawing.Size(204, 22);
            this.ordenCancelar.Text = "Cancelar";
            this.ordenCancelar.Click += new System.EventHandler(this.ordenCancelar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // ordenTotalR
            // 
            this.ordenTotalR.Name = "ordenTotalR";
            this.ordenTotalR.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ordenTotalR.Size = new System.Drawing.Size(204, 22);
            this.ordenTotalR.Text = "Total Recaudado";
            this.ordenTotalR.Click += new System.EventHandler(this.ordenTotalR_Click);
            // 
            // menuVer
            // 
            this.menuVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraDeHerramientasToolStripMenuItem,
            this.barraDeEstadoToolStripMenuItem});
            this.menuVer.Name = "menuVer";
            this.menuVer.Size = new System.Drawing.Size(35, 20);
            this.menuVer.Text = "Ver";
            // 
            // barraDeHerramientasToolStripMenuItem
            // 
            this.barraDeHerramientasToolStripMenuItem.Checked = true;
            this.barraDeHerramientasToolStripMenuItem.CheckOnClick = true;
            this.barraDeHerramientasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeHerramientasToolStripMenuItem.Name = "barraDeHerramientasToolStripMenuItem";
            this.barraDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.barraDeHerramientasToolStripMenuItem.Text = "Barra de herramientas";
            this.barraDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.barraDeHerramientasToolStripMenuItem_Click);
            // 
            // barraDeEstadoToolStripMenuItem
            // 
            this.barraDeEstadoToolStripMenuItem.Checked = true;
            this.barraDeEstadoToolStripMenuItem.CheckOnClick = true;
            this.barraDeEstadoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeEstadoToolStripMenuItem.Name = "barraDeEstadoToolStripMenuItem";
            this.barraDeEstadoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.barraDeEstadoToolStripMenuItem.Text = "Barra de estado";
            this.barraDeEstadoToolStripMenuItem.Click += new System.EventHandler(this.barraDeEstadoToolStripMenuItem_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenAcercade});
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "Ayuda";
            // 
            // ordenAcercade
            // 
            this.ordenAcercade.Name = "ordenAcercade";
            this.ordenAcercade.Size = new System.Drawing.Size(126, 22);
            this.ordenAcercade.Text = "Acerca de";
            this.ordenAcercade.Click += new System.EventHandler(this.ordenAcercade_Click);
            // 
            // barradeherramientas
            // 
            this.barradeherramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo,
            this.guardar,
            this.cancel,
            this.toolStripSeparator2,
            this.Busca,
            this.buscador,
            this.buscar,
            this.toolStripSeparator3,
            this.toolStripButton3});
            this.barradeherramientas.Location = new System.Drawing.Point(0, 24);
            this.barradeherramientas.Name = "barradeherramientas";
            this.barradeherramientas.Size = new System.Drawing.Size(800, 25);
            this.barradeherramientas.TabIndex = 1;
            this.barradeherramientas.Text = "toolStrip1";
            this.barradeherramientas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barradeherramientas_ItemClicked);
            // 
            // nuevo
            // 
            this.nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(23, 22);
            this.nuevo.Text = "Nuevo";
            this.nuevo.Click += new System.EventHandler(this.ordenNuevo_Click);
            // 
            // guardar
            // 
            this.guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(23, 22);
            this.guardar.Text = "Guardar";
            this.guardar.Click += new System.EventHandler(this.ordenGuardar_Click);
            // 
            // cancel
            // 
            this.cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(23, 22);
            this.cancel.Text = "Cancelar";
            this.cancel.Click += new System.EventHandler(this.ordenCancelar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Busca
            // 
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(42, 22);
            this.Busca.Text = "Buscar";
            this.Busca.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // buscador
            // 
            this.buscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(100, 25);
            this.buscador.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // buscar
            // 
            this.buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(23, 22);
            this.buscar.Text = "Buscar";
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Acerca de";
            this.toolStripButton3.Click += new System.EventHandler(this.ordenAcercade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Visible = false;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(77, 212);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(77, 271);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Location = new System.Drawing.Point(51, 343);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(57, 57);
            this.btnPrimero.TabIndex = 10;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(114, 343);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 57);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(252, 343);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 57);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Location = new System.Drawing.Point(333, 343);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(57, 57);
            this.btnUltimo.TabIndex = 13;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // barradeestado
            // 
            this.barradeestado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.barradeestado.Location = new System.Drawing.Point(0, 428);
            this.barradeestado.Name = "barradeestado";
            this.barradeestado.Size = new System.Drawing.Size(800, 22);
            this.barradeestado.TabIndex = 15;
            this.barradeestado.Text = "statusStrip1";
            this.barradeestado.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barradeestado_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(490, 17);
            this.toolStripStatusLabel2.Text = "                                                                                 " +
    "                                            Sistemas de registro.";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barradeestado);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barradeherramientas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion de Productos";
            this.Load += new System.EventHandler(this.GestionProductos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GestionProductos_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.barradeherramientas.ResumeLayout(false);
            this.barradeherramientas.PerformLayout();
            this.barradeestado.ResumeLayout(false);
            this.barradeestado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem ordenSalir;
        private System.Windows.Forms.ToolStripMenuItem menuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem ordenNuevo;
        private System.Windows.Forms.ToolStripMenuItem ordenGuardar;
        private System.Windows.Forms.ToolStripMenuItem ordenCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ordenTotalR;
        private System.Windows.Forms.ToolStripMenuItem menuVer;
        private System.Windows.Forms.ToolStripMenuItem barraDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.ToolStripMenuItem ordenAcercade;
        private System.Windows.Forms.ToolStrip barradeherramientas;
        private System.Windows.Forms.ToolStripButton cancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel Busca;
        private System.Windows.Forms.ToolStripTextBox buscador;
        private System.Windows.Forms.ToolStripButton nuevo;
        private System.Windows.Forms.ToolStripButton guardar;
        private System.Windows.Forms.ToolStripButton buscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.StatusStrip barradeestado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}

