namespace Eleições
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
            this.Eleições = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantidade_Votos = new System.Windows.Forms.NumericUpDown();
            this.track_votos_brancos = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultado_Eleições = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.track_votos_nulos = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade_Votos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_votos_brancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_votos_nulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Eleições
            // 
            this.Eleições.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eleições.Location = new System.Drawing.Point(343, 317);
            this.Eleições.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Eleições.Name = "Eleições";
            this.Eleições.Size = new System.Drawing.Size(125, 61);
            this.Eleições.TabIndex = 0;
            this.Eleições.Text = "Eleições";
            this.Eleições.UseVisualStyleBackColor = true;
            this.Eleições.Click += new System.EventHandler(this.Eleições_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eleições da República XYZ";
            // 
            // Quantidade_Votos
            // 
            this.Quantidade_Votos.Location = new System.Drawing.Point(459, 264);
            this.Quantidade_Votos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Quantidade_Votos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Quantidade_Votos.Name = "Quantidade_Votos";
            this.Quantidade_Votos.Size = new System.Drawing.Size(100, 20);
            this.Quantidade_Votos.TabIndex = 2;
            this.Quantidade_Votos.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // track_votos_brancos
            // 
            this.track_votos_brancos.Location = new System.Drawing.Point(88, 255);
            this.track_votos_brancos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.track_votos_brancos.Maximum = 100;
            this.track_votos_brancos.Name = "track_votos_brancos";
            this.track_votos_brancos.Size = new System.Drawing.Size(146, 45);
            this.track_votos_brancos.TabIndex = 3;
            this.track_votos_brancos.TickFrequency = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Frequência de Votos Brancos";
            // 
            // Resultado_Eleições
            // 
            this.Resultado_Eleições.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado_Eleições.FormattingEnabled = true;
            this.Resultado_Eleições.ItemHeight = 20;
            this.Resultado_Eleições.Location = new System.Drawing.Point(84, 50);
            this.Resultado_Eleições.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Resultado_Eleições.Name = "Resultado_Eleições";
            this.Resultado_Eleições.Size = new System.Drawing.Size(412, 164);
            this.Resultado_Eleições.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Frequência de Votos Nulos";
            // 
            // track_votos_nulos
            // 
            this.track_votos_nulos.Location = new System.Drawing.Point(88, 344);
            this.track_votos_nulos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.track_votos_nulos.Maximum = 100;
            this.track_votos_nulos.Name = "track_votos_nulos";
            this.track_votos_nulos.Size = new System.Drawing.Size(142, 45);
            this.track_votos_nulos.TabIndex = 7;
            this.track_votos_nulos.TickFrequency = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total de Votos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.track_votos_nulos);
            this.Controls.Add(this.Resultado_Eleições);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.track_votos_brancos);
            this.Controls.Add(this.Quantidade_Votos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eleições);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Quantidade_Votos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_votos_brancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_votos_nulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eleições;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Quantidade_Votos;
        private System.Windows.Forms.TrackBar track_votos_brancos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Resultado_Eleições;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar track_votos_nulos;
        private System.Windows.Forms.Label label4;
    }
}

