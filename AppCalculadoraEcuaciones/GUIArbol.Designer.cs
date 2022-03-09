namespace AppCalculadoraEcuaciones
{
    partial class GUIArbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIArbol));
            this.textBoxPre = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxEcuacion = new System.Windows.Forms.TextBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxPos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPos = new System.Windows.Forms.Button();
            this.buttonIn = new System.Windows.Forms.Button();
            this.buttonPre = new System.Windows.Forms.Button();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPre
            // 
            this.textBoxPre.Location = new System.Drawing.Point(164, 68);
            this.textBoxPre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPre.Name = "textBoxPre";
            this.textBoxPre.Size = new System.Drawing.Size(287, 22);
            this.textBoxPre.TabIndex = 0;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(460, 32);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(88, 34);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.Text = "Operar";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // textBoxEcuacion
            // 
            this.textBoxEcuacion.Location = new System.Drawing.Point(164, 23);
            this.textBoxEcuacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEcuacion.Name = "textBoxEcuacion";
            this.textBoxEcuacion.Size = new System.Drawing.Size(287, 22);
            this.textBoxEcuacion.TabIndex = 2;
            this.textBoxEcuacion.Text = "\r\n\r\n";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(164, 111);
            this.textBoxIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(287, 22);
            this.textBoxIn.TabIndex = 3;
            // 
            // textBoxPos
            // 
            this.textBoxPos.Location = new System.Drawing.Point(164, 156);
            this.textBoxPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPos.Name = "textBoxPos";
            this.textBoxPos.Size = new System.Drawing.Size(287, 22);
            this.textBoxPos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expresion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pre Orden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "In Orden:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pos Orden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonPos);
            this.panel1.Controls.Add(this.buttonIn);
            this.panel1.Controls.Add(this.buttonPre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPos);
            this.panel1.Controls.Add(this.textBoxIn);
            this.panel1.Controls.Add(this.textBoxEcuacion);
            this.panel1.Controls.Add(this.textBoxPre);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 211);
            this.panel1.TabIndex = 10;
            // 
            // buttonPos
            // 
            this.buttonPos.Location = new System.Drawing.Point(460, 155);
            this.buttonPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPos.Name = "buttonPos";
            this.buttonPos.Size = new System.Drawing.Size(69, 26);
            this.buttonPos.TabIndex = 13;
            this.buttonPos.Text = "Operar";
            this.buttonPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPos.UseVisualStyleBackColor = true;
            this.buttonPos.Click += new System.EventHandler(this.buttonPos_Click);
            // 
            // buttonIn
            // 
            this.buttonIn.Location = new System.Drawing.Point(460, 110);
            this.buttonIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIn.Name = "buttonIn";
            this.buttonIn.Size = new System.Drawing.Size(69, 26);
            this.buttonIn.TabIndex = 12;
            this.buttonIn.Text = "Operar";
            this.buttonIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonIn.UseVisualStyleBackColor = true;
            this.buttonIn.Click += new System.EventHandler(this.buttonIn_Click);
            // 
            // buttonPre
            // 
            this.buttonPre.Location = new System.Drawing.Point(460, 66);
            this.buttonPre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPre.Name = "buttonPre";
            this.buttonPre.Size = new System.Drawing.Size(69, 26);
            this.buttonPre.TabIndex = 11;
            this.buttonPre.Text = "Operar";
            this.buttonPre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPre.UseVisualStyleBackColor = true;
            this.buttonPre.Click += new System.EventHandler(this.buttonPre_Click);
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(164, 32);
            this.txtResp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(287, 22);
            this.txtResp.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonCalcular);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtResp);
            this.panel2.Location = new System.Drawing.Point(17, 263);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 94);
            this.panel2.TabIndex = 11;
            // 
            // GUIArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUIArbol";
            this.Text = "ARBOL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPre;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textBoxEcuacion;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.Button buttonPos;
        private System.Windows.Forms.Button buttonIn;
        private System.Windows.Forms.Button buttonPre;
        private System.Windows.Forms.Panel panel2;
    }
}

