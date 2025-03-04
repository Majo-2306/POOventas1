namespace POOventas1
{
    partial class Form2
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
            rbContado = new RadioButton();
            rbCredito = new RadioButton();
            btnCalcular_Click = new Button();
            dataGridView1 = new DataGridView();
            txtMonto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // rbContado
            // 
            rbContado.AutoSize = true;
            rbContado.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbContado.Location = new Point(301, 105);
            rbContado.Name = "rbContado";
            rbContado.Size = new Size(97, 26);
            rbContado.TabIndex = 0;
            rbContado.TabStop = true;
            rbContado.Text = "Contado";
            rbContado.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCredito.Location = new Point(412, 105);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(87, 26);
            rbCredito.TabIndex = 0;
            rbCredito.TabStop = true;
            rbCredito.Text = "Credito";
            rbCredito.UseVisualStyleBackColor = true;
            // 
            // btnCalcular_Click
            // 
            btnCalcular_Click.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular_Click.Location = new Point(12, 319);
            btnCalcular_Click.Name = "btnCalcular_Click";
            btnCalcular_Click.Size = new Size(231, 39);
            btnCalcular_Click.TabIndex = 1;
            btnCalcular_Click.Text = "Registrar Compra";
            btnCalcular_Click.UseVisualStyleBackColor = true;
            btnCalcular_Click.Click += btnCalcular_Click_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(487, 178);
            dataGridView1.TabIndex = 2;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(12, 102);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "Monto";
            txtMonto.Size = new Size(165, 27);
            txtMonto.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.coppel;
            ClientSize = new Size(634, 390);
            Controls.Add(txtMonto);
            Controls.Add(dataGridView1);
            Controls.Add(btnCalcular_Click);
            Controls.Add(rbCredito);
            Controls.Add(rbContado);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbContado;
        private RadioButton rbCredito;
        private Button btnCalcular_Click;
        private DataGridView dataGridView1;
        private TextBox txtMonto;
    }
}