namespace T2
{
    partial class T2_FP_G25
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
            this.TextoBienvenida = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.cat = new System.Windows.Forms.Label();
            this.prec = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.Label();
            this.txtNombr = new System.Windows.Forms.TextBox();
            this.RegistBusq = new System.Windows.Forms.GroupBox();
            this.lblsumatot = new System.Windows.Forms.Label();
            this.lbltotalst = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtcater = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Label();
            this.buscp = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.busc = new System.Windows.Forms.Button();
            this.busq = new System.Windows.Forms.Label();
            this.regis = new System.Windows.Forms.Button();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtPrec = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.listaproductos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndescend = new System.Windows.Forms.Button();
            this.btnascend = new System.Windows.Forms.Button();
            this.lblorden = new System.Windows.Forms.Label();
            this.RegistBusq.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextoBienvenida
            // 
            this.TextoBienvenida.AutoSize = true;
            this.TextoBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoBienvenida.Location = new System.Drawing.Point(12, 9);
            this.TextoBienvenida.Name = "TextoBienvenida";
            this.TextoBienvenida.Size = new System.Drawing.Size(146, 29);
            this.TextoBienvenida.TabIndex = 0;
            this.TextoBienvenida.Text = "¡Bienvenido!";
            this.TextoBienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(6, 30);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(47, 13);
            this.c.TabIndex = 1;
            this.c.Text = "Nombre:";
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Location = new System.Drawing.Point(6, 59);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(57, 13);
            this.cat.TabIndex = 2;
            this.cat.Text = "Categoría:";
            this.cat.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // prec
            // 
            this.prec.AutoSize = true;
            this.prec.Location = new System.Drawing.Point(6, 87);
            this.prec.Name = "prec";
            this.prec.Size = new System.Drawing.Size(40, 13);
            this.prec.TabIndex = 3;
            this.prec.Text = "Precio:";
            // 
            // cant
            // 
            this.cant.AutoSize = true;
            this.cant.Location = new System.Drawing.Point(6, 116);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(52, 13);
            this.cant.TabIndex = 4;
            this.cant.Text = "Cantidad:";
            // 
            // txtNombr
            // 
            this.txtNombr.Location = new System.Drawing.Point(71, 27);
            this.txtNombr.Name = "txtNombr";
            this.txtNombr.Size = new System.Drawing.Size(123, 20);
            this.txtNombr.TabIndex = 5;
            this.txtNombr.TextChanged += new System.EventHandler(this.txtNombr_TextChanged);
            // 
            // RegistBusq
            // 
            this.RegistBusq.Controls.Add(this.lblsumatot);
            this.RegistBusq.Controls.Add(this.lbltotalst);
            this.RegistBusq.Controls.Add(this.btnSuma);
            this.RegistBusq.Controls.Add(this.txtcater);
            this.RegistBusq.Controls.Add(this.label1);
            this.RegistBusq.Controls.Add(this.suma);
            this.RegistBusq.Controls.Add(this.buscp);
            this.RegistBusq.Controls.Add(this.txtbuscar);
            this.RegistBusq.Controls.Add(this.busc);
            this.RegistBusq.Controls.Add(this.busq);
            this.RegistBusq.Controls.Add(this.regis);
            this.RegistBusq.Controls.Add(this.txtcant);
            this.RegistBusq.Controls.Add(this.txtPrec);
            this.RegistBusq.Controls.Add(this.txtCat);
            this.RegistBusq.Controls.Add(this.c);
            this.RegistBusq.Controls.Add(this.txtNombr);
            this.RegistBusq.Controls.Add(this.cat);
            this.RegistBusq.Controls.Add(this.cant);
            this.RegistBusq.Controls.Add(this.prec);
            this.RegistBusq.Location = new System.Drawing.Point(17, 59);
            this.RegistBusq.Name = "RegistBusq";
            this.RegistBusq.Size = new System.Drawing.Size(287, 448);
            this.RegistBusq.TabIndex = 6;
            this.RegistBusq.TabStop = false;
            this.RegistBusq.Text = "Registro y Búsqueda";
            this.RegistBusq.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lblsumatot
            // 
            this.lblsumatot.AutoSize = true;
            this.lblsumatot.Location = new System.Drawing.Point(213, 347);
            this.lblsumatot.Name = "lblsumatot";
            this.lblsumatot.Size = new System.Drawing.Size(16, 13);
            this.lblsumatot.TabIndex = 19;
            this.lblsumatot.Text = "...";
            this.lblsumatot.Click += new System.EventHandler(this.lblsumatot_Click);
            // 
            // lbltotalst
            // 
            this.lbltotalst.AutoSize = true;
            this.lbltotalst.Location = new System.Drawing.Point(192, 324);
            this.lbltotalst.Name = "lbltotalst";
            this.lbltotalst.Size = new System.Drawing.Size(61, 13);
            this.lbltotalst.TabIndex = 18;
            this.lbltotalst.Text = "Stock total:";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(10, 369);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(97, 23);
            this.btnSuma.TabIndex = 17;
            this.btnSuma.Text = "Calcular";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtcater
            // 
            this.txtcater.Location = new System.Drawing.Point(9, 340);
            this.txtcater.Name = "txtcater";
            this.txtcater.Size = new System.Drawing.Size(151, 20);
            this.txtcater.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Categoría:";
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Location = new System.Drawing.Point(6, 302);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(132, 13);
            this.suma.TabIndex = 14;
            this.suma.Text = "Stock total (Por categoría)";
            // 
            // buscp
            // 
            this.buscp.AutoSize = true;
            this.buscp.Location = new System.Drawing.Point(6, 225);
            this.buscp.Name = "buscp";
            this.buscp.Size = new System.Drawing.Size(97, 13);
            this.buscp.TabIndex = 13;
            this.buscp.Text = "Producto a buscar:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(9, 241);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(151, 20);
            this.txtbuscar.TabIndex = 12;
            // 
            // busc
            // 
            this.busc.Location = new System.Drawing.Point(9, 267);
            this.busc.Name = "busc";
            this.busc.Size = new System.Drawing.Size(97, 23);
            this.busc.TabIndex = 11;
            this.busc.Text = "Buscar";
            this.busc.UseVisualStyleBackColor = true;
            this.busc.Click += new System.EventHandler(this.busc_Click);
            // 
            // busq
            // 
            this.busq.AutoSize = true;
            this.busq.Location = new System.Drawing.Point(6, 189);
            this.busq.Name = "busq";
            this.busq.Size = new System.Drawing.Size(58, 13);
            this.busq.TabIndex = 10;
            this.busq.Text = "Búsqueda:";
            this.busq.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // regis
            // 
            this.regis.Location = new System.Drawing.Point(54, 149);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(129, 23);
            this.regis.TabIndex = 9;
            this.regis.Text = "Registrar";
            this.regis.UseVisualStyleBackColor = true;
            this.regis.Click += new System.EventHandler(this.regis_Click);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(71, 113);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(123, 20);
            this.txtcant.TabIndex = 8;
            this.txtcant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(71, 84);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(123, 20);
            this.txtPrec.TabIndex = 7;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(71, 56);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(123, 20);
            this.txtCat.TabIndex = 6;
            this.txtCat.TextChanged += new System.EventHandler(this.txtCat_TextChanged);
            // 
            // listaproductos
            // 
            this.listaproductos.FormattingEnabled = true;
            this.listaproductos.Location = new System.Drawing.Point(32, 19);
            this.listaproductos.Name = "listaproductos";
            this.listaproductos.Size = new System.Drawing.Size(407, 394);
            this.listaproductos.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndescend);
            this.groupBox1.Controls.Add(this.btnascend);
            this.groupBox1.Controls.Add(this.lblorden);
            this.groupBox1.Controls.Add(this.listaproductos);
            this.groupBox1.Location = new System.Drawing.Point(408, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 495);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // btndescend
            // 
            this.btndescend.Location = new System.Drawing.Point(287, 453);
            this.btndescend.Name = "btndescend";
            this.btndescend.Size = new System.Drawing.Size(110, 23);
            this.btndescend.TabIndex = 21;
            this.btndescend.Text = "Descendente";
            this.btndescend.UseVisualStyleBackColor = true;
            this.btndescend.Click += new System.EventHandler(this.btndescend_Click);
            // 
            // btnascend
            // 
            this.btnascend.Location = new System.Drawing.Point(76, 453);
            this.btnascend.Name = "btnascend";
            this.btnascend.Size = new System.Drawing.Size(110, 23);
            this.btnascend.TabIndex = 20;
            this.btnascend.Text = "Ascendente";
            this.btnascend.UseVisualStyleBackColor = true;
            this.btnascend.Click += new System.EventHandler(this.btnascend_Click);
            // 
            // lblorden
            // 
            this.lblorden.AutoSize = true;
            this.lblorden.Location = new System.Drawing.Point(29, 426);
            this.lblorden.Name = "lblorden";
            this.lblorden.Size = new System.Drawing.Size(113, 13);
            this.lblorden.TabIndex = 15;
            this.lblorden.Text = "Ordenar por precio en:";
            // 
            // T2_FP_G25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(869, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RegistBusq);
            this.Controls.Add(this.TextoBienvenida);
            this.Name = "T2_FP_G25";
            this.Text = "T2_FP_G25";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegistBusq.ResumeLayout(false);
            this.RegistBusq.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoBienvenida;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label cat;
        private System.Windows.Forms.Label prec;
        private System.Windows.Forms.Label cant;
        private System.Windows.Forms.TextBox txtNombr;
        private System.Windows.Forms.GroupBox RegistBusq;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtPrec;
        private System.Windows.Forms.Button regis;
        private System.Windows.Forms.Label busq;
        private System.Windows.Forms.Label buscp;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button busc;
        private System.Windows.Forms.ListBox listaproductos;
        private System.Windows.Forms.Label suma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblorden;
        private System.Windows.Forms.TextBox txtcater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsumatot;
        private System.Windows.Forms.Label lbltotalst;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btndescend;
        private System.Windows.Forms.Button btnascend;
    }
}

