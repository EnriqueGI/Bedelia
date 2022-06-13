
namespace Bedelias
{
    partial class FormDocente
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
            this.labelN6 = new System.Windows.Forms.Label();
            this.labelN3 = new System.Windows.Forms.Label();
            this.labeN2 = new System.Windows.Forms.Label();
            this.labelN1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMaterias = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxMostrarM = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelN6
            // 
            this.labelN6.AutoSize = true;
            this.labelN6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelN6.Location = new System.Drawing.Point(460, 231);
            this.labelN6.Name = "labelN6";
            this.labelN6.Size = new System.Drawing.Size(0, 20);
            this.labelN6.TabIndex = 33;
            // 
            // labelN3
            // 
            this.labelN3.AutoSize = true;
            this.labelN3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelN3.Location = new System.Drawing.Point(391, 231);
            this.labelN3.Name = "labelN3";
            this.labelN3.Size = new System.Drawing.Size(0, 20);
            this.labelN3.TabIndex = 32;
            // 
            // labeN2
            // 
            this.labeN2.AutoSize = true;
            this.labeN2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeN2.Location = new System.Drawing.Point(335, 241);
            this.labeN2.Name = "labeN2";
            this.labeN2.Size = new System.Drawing.Size(0, 20);
            this.labeN2.TabIndex = 31;
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelN1.Location = new System.Drawing.Point(268, 231);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(0, 20);
            this.labelN1.TabIndex = 30;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(199, 430);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 194);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cédula";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Edad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 103);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cargar Docente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(262, 138);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(270, 26);
            this.textEdad.TabIndex = 23;
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(262, 78);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(270, 26);
            this.textCedula.TabIndex = 22;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(262, 19);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(270, 26);
            this.textNombre.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(79, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(79, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cédula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 35);
            this.button2.TabIndex = 34;
            this.button2.Text = "Agregar Materias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(72, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "Materias";
            // 
            // labelMaterias
            // 
            this.labelMaterias.AutoSize = true;
            this.labelMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterias.ForeColor = System.Drawing.Color.PeachPuff;
            this.labelMaterias.Location = new System.Drawing.Point(567, 191);
            this.labelMaterias.Name = "labelMaterias";
            this.labelMaterias.Size = new System.Drawing.Size(0, 37);
            this.labelMaterias.TabIndex = 37;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(547, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 124);
            this.listBox1.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(797, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 64);
            this.button3.TabIndex = 39;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxMostrarM
            // 
            this.listBoxMostrarM.FormattingEnabled = true;
            this.listBoxMostrarM.ItemHeight = 20;
            this.listBoxMostrarM.Location = new System.Drawing.Point(598, 430);
            this.listBoxMostrarM.Name = "listBoxMostrarM";
            this.listBoxMostrarM.Size = new System.Drawing.Size(244, 184);
            this.listBoxMostrarM.TabIndex = 40;
            this.listBoxMostrarM.Visible = false;
            // 
            // FormDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1169, 696);
            this.Controls.Add(this.listBoxMostrarM);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelMaterias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelN6);
            this.Controls.Add(this.labelN3);
            this.Controls.Add(this.labeN2);
            this.Controls.Add(this.labelN1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDocente";
            this.Text = "FormDocente";
            this.Load += new System.EventHandler(this.FormDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN6;
        private System.Windows.Forms.Label labelN3;
        private System.Windows.Forms.Label labeN2;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMaterias;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxMostrarM;
    }
}