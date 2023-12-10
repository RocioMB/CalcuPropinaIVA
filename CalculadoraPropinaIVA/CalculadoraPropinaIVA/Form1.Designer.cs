namespace CalculadoraPropinaIVA
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.resultadoIVA = new System.Windows.Forms.Label();
            this.resultadoPropina = new System.Windows.Forms.Label();
            this.totalCuenta = new System.Windows.Forms.TextBox();
            this.totalVA = new System.Windows.Forms.TextBox();
            this.totalPropina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(564, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // resultadoIVA
            // 
            this.resultadoIVA.AutoSize = true;
            this.resultadoIVA.Location = new System.Drawing.Point(575, 153);
            this.resultadoIVA.Name = "resultadoIVA";
            this.resultadoIVA.Size = new System.Drawing.Size(0, 16);
            this.resultadoIVA.TabIndex = 1;
            // 
            // resultadoPropina
            // 
            this.resultadoPropina.AutoSize = true;
            this.resultadoPropina.Location = new System.Drawing.Point(575, 217);
            this.resultadoPropina.Name = "resultadoPropina";
            this.resultadoPropina.Size = new System.Drawing.Size(0, 16);
            this.resultadoPropina.TabIndex = 2;
            // 
            // totalCuenta
            // 
            this.totalCuenta.Location = new System.Drawing.Point(179, 104);
            this.totalCuenta.Name = "totalCuenta";
            this.totalCuenta.Size = new System.Drawing.Size(100, 22);
            this.totalCuenta.TabIndex = 3;
            // 
            // totalVA
            // 
            this.totalVA.Location = new System.Drawing.Point(183, 198);
            this.totalVA.Name = "totalVA";
            this.totalVA.Size = new System.Drawing.Size(100, 22);
            this.totalVA.TabIndex = 4;
            // 
            // totalPropina
            // 
            this.totalPropina.Location = new System.Drawing.Point(183, 271);
            this.totalPropina.Name = "totalPropina";
            this.totalPropina.Size = new System.Drawing.Size(100, 22);
            this.totalPropina.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Porcentaje Propina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Porcentaje IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Cuenta + IVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado Propina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPropina);
            this.Controls.Add(this.totalVA);
            this.Controls.Add(this.totalCuenta);
            this.Controls.Add(this.resultadoPropina);
            this.Controls.Add(this.resultadoIVA);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label resultadoIVA;
        private System.Windows.Forms.Label resultadoPropina;
        private System.Windows.Forms.TextBox totalCuenta;
        private System.Windows.Forms.TextBox totalVA;
        private System.Windows.Forms.TextBox totalPropina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

