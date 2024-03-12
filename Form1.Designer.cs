namespace Pvolume
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
            lblRaio = new Label();
            lblAltura = new Label();
            lblVolume = new Label();
            txtRaio = new TextBox();
            txtVolume = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblRaio
            // 
            lblRaio.AutoSize = true;
            lblRaio.Location = new Point(120, 49);
            lblRaio.Name = "lblRaio";
            lblRaio.Size = new Size(30, 15);
            lblRaio.TabIndex = 0;
            lblRaio.Text = "Raio";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(120, 144);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura";
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(120, 247);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(47, 15);
            lblVolume.TabIndex = 2;
            lblVolume.Text = "Volume";
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(252, 45);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(182, 23);
            txtRaio.TabIndex = 3;
            txtRaio.TextChanged += txtRaio_TextChanged;
            txtRaio.Validated += txtRaio_Validated;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(252, 239);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(182, 23);
            txtVolume.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(252, 136);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(182, 23);
            txtAltura.TabIndex = 5;
            txtAltura.Validated += txtAltura_Validated;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(203, 320);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(141, 82);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(433, 320);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(142, 82);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtVolume);
            Controls.Add(txtRaio);
            Controls.Add(lblVolume);
            Controls.Add(lblAltura);
            Controls.Add(lblRaio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRaio;
        private Label lblAltura;
        private Label lblVolume;
        private TextBox txtRaio;
        private TextBox txtVolume;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Button btnFechar;
    }
}
