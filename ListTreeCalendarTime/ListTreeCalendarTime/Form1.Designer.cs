
namespace ListTreeCalendarTime
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
            this.dateTime = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateTime.Location = new System.Drawing.Point(0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Size = new System.Drawing.Size(800, 29);
            this.dateTime.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Azua: Azua de Compostela",
            "Bahoruco: Neiba",
            "Barahona: Santa Cruz de Barahona",
            "Dajabón: Dajabón",
            "Distrito Nacional: Santo Domingo",
            "Duarte: San Francisco de Macorís",
            "Elías Piña: Comendador",
            "El Seibo: Santa Cruz de El Seibo",
            "Espaillat: Moca",
            "Hato Mayor: Hato Mayor del Rey",
            "Hermanas Mirabal: Salcedo",
            "Independencia: Jimaní",
            "La Altagracia: Salvaleón de Higüey",
            "La Romana: La Romana",
            "La Vega: La Vega",
            "María Trinidad Sánchez: Nagua",
            "Monseñor Nouel: Bonao",
            "Monte Cristi: San Fernando de Monte Cristi",
            "Monte Plata: Monte Plata",
            "Pedernales: Pedernales",
            "Peravia: Baní",
            "Puerto Plata: San Felipe de Puerto Plata",
            "Samaná: Santa Bárbara de Samaná",
            "San Cristóbal: San Cristóbal",
            "San José de Ocoa: San José de Ocoa",
            "San Juan: San Juan de Maguana",
            "San Pedro de Macorís: San Pedro de Macorís",
            "Sánchez Ramírez: Cotuí",
            "Santiago: Santiago de los Caballeros",
            "Santiago Rodríguez: San Ignacio de Sabaneta",
            "Santo Domingo: Santo Domingo Este",
            "Valverde: Santa Cruz de Mao"});
            this.comboBox1.Location = new System.Drawing.Point(13, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(775, 355);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

