namespace Puntos
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.observacionestextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estudianteIDtextBox = new System.Windows.Forms.TextBox();
            this.pagoIDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.vacioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.montonumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.vacioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montonumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nombre";
            // 
            // nombretextBox
            // 
            this.nombretextBox.Location = new System.Drawing.Point(123, 48);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(170, 20);
            this.nombretextBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Observaciones";
            // 
            // observacionestextBox
            // 
            this.observacionestextBox.Location = new System.Drawing.Point(123, 190);
            this.observacionestextBox.Name = "observacionestextBox";
            this.observacionestextBox.Size = new System.Drawing.Size(170, 20);
            this.observacionestextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Monto";
            // 
            // estudianteIDtextBox
            // 
            this.estudianteIDtextBox.Location = new System.Drawing.Point(123, 151);
            this.estudianteIDtextBox.Name = "estudianteIDtextBox";
            this.estudianteIDtextBox.Size = new System.Drawing.Size(170, 20);
            this.estudianteIDtextBox.TabIndex = 23;
            // 
            // pagoIDtextBox
            // 
            this.pagoIDtextBox.Location = new System.Drawing.Point(123, 9);
            this.pagoIDtextBox.Name = "pagoIDtextBox";
            this.pagoIDtextBox.Size = new System.Drawing.Size(170, 20);
            this.pagoIDtextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "EstudianteID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "PagoID";
            // 
            // fechadateTimePicker
            // 
            this.fechadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechadateTimePicker.Location = new System.Drawing.Point(124, 118);
            this.fechadateTimePicker.Name = "fechadateTimePicker";
            this.fechadateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.fechadateTimePicker.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Image = global::Puntos.Properties.Resources.DocumentEdit_40924;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModificar.Location = new System.Drawing.Point(237, 238);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(66, 59);
            this.buttonModificar.TabIndex = 39;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::Puntos.Properties.Resources.delete_remove_page_document_16678;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(165, 238);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(66, 59);
            this.buttonEliminar.TabIndex = 38;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Image = global::Puntos.Properties.Resources.New_File_36861;
            this.buttonNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNuevo.Location = new System.Drawing.Point(94, 238);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(65, 59);
            this.buttonNuevo.TabIndex = 33;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Image = global::Puntos.Properties.Resources.Save_as_37111;
            this.buttonRegistrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRegistrar.Location = new System.Drawing.Point(22, 238);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(66, 59);
            this.buttonRegistrar.TabIndex = 32;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // vacioerrorProvider
            // 
            this.vacioerrorProvider.ContainerControl = this;
            // 
            // montonumericUpDown
            // 
            this.montonumericUpDown.Location = new System.Drawing.Point(124, 88);
            this.montonumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.montonumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.montonumericUpDown.Name = "montonumericUpDown";
            this.montonumericUpDown.Size = new System.Drawing.Size(169, 20);
            this.montonumericUpDown.TabIndex = 40;
            this.montonumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 314);
            this.Controls.Add(this.montonumericUpDown);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.fechadateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.observacionestextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.estudianteIDtextBox);
            this.Controls.Add(this.pagoIDtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.vacioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montonumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombretextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox observacionestextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox estudianteIDtextBox;
        private System.Windows.Forms.TextBox pagoIDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.ErrorProvider vacioerrorProvider;
        private System.Windows.Forms.NumericUpDown montonumericUpDown;
    }
}

