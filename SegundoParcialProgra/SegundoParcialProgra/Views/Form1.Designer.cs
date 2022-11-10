
namespace SegundoParcialProgra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtProm3 = new System.Windows.Forms.TextBox();
            this.txtProm2 = new System.Windows.Forms.TextBox();
            this.txtProm1 = new System.Windows.Forms.TextBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.txtCarrer = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1071, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Colegio | \"ECAEETF\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtProm3);
            this.groupBox1.Controls.Add(this.txtProm2);
            this.groupBox1.Controls.Add(this.txtProm1);
            this.groupBox1.Controls.Add(this.txtSignature);
            this.groupBox1.Controls.Add(this.txtCarrer);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 477);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Datos Estudiantiles";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Location = new System.Drawing.Point(229, 413);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 40);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.LightGreen;
            this.btnIngresar.Location = new System.Drawing.Point(348, 413);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(104, 40);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtProm3
            // 
            this.txtProm3.Location = new System.Drawing.Point(187, 362);
            this.txtProm3.Name = "txtProm3";
            this.txtProm3.Size = new System.Drawing.Size(265, 32);
            this.txtProm3.TabIndex = 14;
            this.txtProm3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // txtProm2
            // 
            this.txtProm2.Location = new System.Drawing.Point(187, 305);
            this.txtProm2.Name = "txtProm2";
            this.txtProm2.Size = new System.Drawing.Size(265, 32);
            this.txtProm2.TabIndex = 13;
            this.txtProm2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // txtProm1
            // 
            this.txtProm1.Location = new System.Drawing.Point(187, 250);
            this.txtProm1.Name = "txtProm1";
            this.txtProm1.Size = new System.Drawing.Size(265, 32);
            this.txtProm1.TabIndex = 12;
            this.txtProm1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(187, 197);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(265, 32);
            this.txtSignature.TabIndex = 11;
            // 
            // txtCarrer
            // 
            this.txtCarrer.Location = new System.Drawing.Point(187, 148);
            this.txtCarrer.Name = "txtCarrer";
            this.txtCarrer.Size = new System.Drawing.Size(265, 32);
            this.txtCarrer.TabIndex = 10;
            this.txtCarrer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtString_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(187, 103);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(265, 32);
            this.txtLastName.TabIndex = 9;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtString_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(187, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 32);
            this.txtName.TabIndex = 8;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtString_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Promedio 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Promedio 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Promedio 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Asignatura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carrera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Location = new System.Drawing.Point(553, 98);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.Size = new System.Drawing.Size(553, 394);
            this.dgvEstudiante.TabIndex = 3;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Cyan;
            this.btnMostrar.Location = new System.Drawing.Point(878, 500);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(228, 40);
            this.btnMostrar.TabIndex = 17;
            this.btnMostrar.Text = "Mostrar Estudiantes";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(420, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 88);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(553, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 141);
            this.panel2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 651);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El Camino al Éxito es tu Formación";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProm3;
        private System.Windows.Forms.TextBox txtProm2;
        private System.Windows.Forms.TextBox txtProm1;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.TextBox txtCarrer;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

