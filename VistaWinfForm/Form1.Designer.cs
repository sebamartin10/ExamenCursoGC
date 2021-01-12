namespace VistaWinfForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblDatosVendedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnCamisa = new System.Windows.Forms.RadioButton();
            this.rdbtnPantalon = new System.Windows.Forms.RadioButton();
            this.chkMangaCorta = new System.Windows.Forms.CheckBox();
            this.chkCuelloMao = new System.Windows.Forms.CheckBox();
            this.chkChupin = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnStandard = new System.Windows.Forms.RadioButton();
            this.rdbtnPremium = new System.Windows.Forms.RadioButton();
            this.groupx = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblPrecioCotizado = new System.Windows.Forms.Label();
            this.btnCotizaciones = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotización Express";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTienda.Location = new System.Drawing.Point(12, 48);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(132, 18);
            this.lblNombreTienda.TabIndex = 1;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionTienda.Location = new System.Drawing.Point(522, 48);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(255, 57);
            this.lblDireccionTienda.TabIndex = 2;
            this.lblDireccionTienda.Text = "Dirección Tienda";
            // 
            // lblDatosVendedor
            // 
            this.lblDatosVendedor.AutoSize = true;
            this.lblDatosVendedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosVendedor.Location = new System.Drawing.Point(12, 87);
            this.lblDatosVendedor.Name = "lblDatosVendedor";
            this.lblDatosVendedor.Size = new System.Drawing.Size(285, 18);
            this.lblDatosVendedor.TabIndex = 3;
            this.lblDatosVendedor.Text = "Nombre y Apellido Vendedor + ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkChupin);
            this.groupBox1.Controls.Add(this.chkCuelloMao);
            this.groupBox1.Controls.Add(this.chkMangaCorta);
            this.groupBox1.Controls.Add(this.rdbtnPantalon);
            this.groupBox1.Controls.Add(this.rdbtnCamisa);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // rdbtnCamisa
            // 
            this.rdbtnCamisa.AutoSize = true;
            this.rdbtnCamisa.Location = new System.Drawing.Point(18, 27);
            this.rdbtnCamisa.Name = "rdbtnCamisa";
            this.rdbtnCamisa.Size = new System.Drawing.Size(86, 22);
            this.rdbtnCamisa.TabIndex = 0;
            this.rdbtnCamisa.TabStop = true;
            this.rdbtnCamisa.Text = "Camisa";
            this.rdbtnCamisa.UseVisualStyleBackColor = true;
            this.rdbtnCamisa.CheckedChanged += new System.EventHandler(this.rdbtnCamisa_CheckedChanged);
            // 
            // rdbtnPantalon
            // 
            this.rdbtnPantalon.AutoSize = true;
            this.rdbtnPantalon.Location = new System.Drawing.Point(18, 103);
            this.rdbtnPantalon.Name = "rdbtnPantalon";
            this.rdbtnPantalon.Size = new System.Drawing.Size(98, 22);
            this.rdbtnPantalon.TabIndex = 1;
            this.rdbtnPantalon.TabStop = true;
            this.rdbtnPantalon.Text = "Pantalón";
            this.rdbtnPantalon.UseVisualStyleBackColor = true;
            this.rdbtnPantalon.CheckedChanged += new System.EventHandler(this.rdbtnPantalon_CheckedChanged);
            // 
            // chkMangaCorta
            // 
            this.chkMangaCorta.AutoSize = true;
            this.chkMangaCorta.Location = new System.Drawing.Point(291, 27);
            this.chkMangaCorta.Name = "chkMangaCorta";
            this.chkMangaCorta.Size = new System.Drawing.Size(130, 22);
            this.chkMangaCorta.TabIndex = 2;
            this.chkMangaCorta.Text = "Manga Corta";
            this.chkMangaCorta.UseVisualStyleBackColor = true;
            this.chkMangaCorta.CheckedChanged += new System.EventHandler(this.chkMangaCorta_CheckedChanged);
            // 
            // chkCuelloMao
            // 
            this.chkCuelloMao.AutoSize = true;
            this.chkCuelloMao.Location = new System.Drawing.Point(513, 28);
            this.chkCuelloMao.Name = "chkCuelloMao";
            this.chkCuelloMao.Size = new System.Drawing.Size(117, 22);
            this.chkCuelloMao.TabIndex = 3;
            this.chkCuelloMao.Text = "Cuello Mao";
            this.chkCuelloMao.UseVisualStyleBackColor = true;
            this.chkCuelloMao.CheckedChanged += new System.EventHandler(this.chkCuelloMao_CheckedChanged);
            // 
            // chkChupin
            // 
            this.chkChupin.AutoSize = true;
            this.chkChupin.Location = new System.Drawing.Point(291, 103);
            this.chkChupin.Name = "chkChupin";
            this.chkChupin.Size = new System.Drawing.Size(83, 22);
            this.chkChupin.TabIndex = 4;
            this.chkChupin.Text = "Chupín";
            this.chkChupin.UseVisualStyleBackColor = true;
            this.chkChupin.CheckedChanged += new System.EventHandler(this.chkChupin_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStockDisponible);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 62);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Location = new System.Drawing.Point(15, 32);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(265, 18);
            this.lblStockDisponible.TabIndex = 0;
            this.lblStockDisponible.Text = "Unidades de stock disponibles:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnPremium);
            this.groupBox3.Controls.Add(this.rdbtnStandard);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad de prenda";
            // 
            // rdbtnStandard
            // 
            this.rdbtnStandard.AutoSize = true;
            this.rdbtnStandard.Checked = true;
            this.rdbtnStandard.Location = new System.Drawing.Point(18, 50);
            this.rdbtnStandard.Name = "rdbtnStandard";
            this.rdbtnStandard.Size = new System.Drawing.Size(99, 22);
            this.rdbtnStandard.TabIndex = 0;
            this.rdbtnStandard.TabStop = true;
            this.rdbtnStandard.Text = "Standard";
            this.rdbtnStandard.UseVisualStyleBackColor = true;
            this.rdbtnStandard.CheckedChanged += new System.EventHandler(this.rdbtnStandard_CheckedChanged);
            // 
            // rdbtnPremium
            // 
            this.rdbtnPremium.AutoSize = true;
            this.rdbtnPremium.Location = new System.Drawing.Point(186, 50);
            this.rdbtnPremium.Name = "rdbtnPremium";
            this.rdbtnPremium.Size = new System.Drawing.Size(97, 22);
            this.rdbtnPremium.TabIndex = 1;
            this.rdbtnPremium.Text = "Premium";
            this.rdbtnPremium.UseVisualStyleBackColor = true;
            this.rdbtnPremium.CheckedChanged += new System.EventHandler(this.rdbtnPremium_CheckedChanged);
            // 
            // groupx
            // 
            this.groupx.Controls.Add(this.txtCantidad);
            this.groupx.Controls.Add(this.label3);
            this.groupx.Controls.Add(this.label2);
            this.groupx.Controls.Add(this.txtPrecio);
            this.groupx.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupx.Location = new System.Drawing.Point(415, 403);
            this.groupx.Name = "groupx";
            this.groupx.Size = new System.Drawing.Size(362, 100);
            this.groupx.TabIndex = 7;
            this.groupx.TabStop = false;
            this.groupx.Text = "Precio unitario y cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(43, 45);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 27);
            this.txtPrecio.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(243, 45);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 27);
            this.txtCantidad.TabIndex = 3;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.Location = new System.Drawing.Point(12, 530);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(332, 36);
            this.btnCotizar.TabIndex = 8;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lblPrecioCotizado
            // 
            this.lblPrecioCotizado.AutoSize = true;
            this.lblPrecioCotizado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCotizado.Location = new System.Drawing.Point(412, 541);
            this.lblPrecioCotizado.Name = "lblPrecioCotizado";
            this.lblPrecioCotizado.Size = new System.Drawing.Size(135, 18);
            this.lblPrecioCotizado.TabIndex = 9;
            this.lblPrecioCotizado.Text = "Precio Cotizado";
            // 
            // btnCotizaciones
            // 
            this.btnCotizaciones.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizaciones.Location = new System.Drawing.Point(637, 87);
            this.btnCotizaciones.Name = "btnCotizaciones";
            this.btnCotizaciones.Size = new System.Drawing.Size(140, 55);
            this.btnCotizaciones.TabIndex = 10;
            this.btnCotizaciones.Text = "Mis Cotizaciones";
            this.btnCotizaciones.UseVisualStyleBackColor = true;
            this.btnCotizaciones.Click += new System.EventHandler(this.btnCotizaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.btnCotizaciones);
            this.Controls.Add(this.lblPrecioCotizado);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.groupx);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDatosVendedor);
            this.Controls.Add(this.lblDireccionTienda);
            this.Controls.Add(this.lblNombreTienda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupx.ResumeLayout(false);
            this.groupx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblDatosVendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkChupin;
        private System.Windows.Forms.CheckBox chkCuelloMao;
        private System.Windows.Forms.CheckBox chkMangaCorta;
        private System.Windows.Forms.RadioButton rdbtnPantalon;
        private System.Windows.Forms.RadioButton rdbtnCamisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbtnPremium;
        private System.Windows.Forms.RadioButton rdbtnStandard;
        private System.Windows.Forms.GroupBox groupx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label lblPrecioCotizado;
        private System.Windows.Forms.Button btnCotizaciones;
    }
}

