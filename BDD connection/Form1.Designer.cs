
namespace BDD_connection
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
            this.butDisconnect = new System.Windows.Forms.Button();
            this.butSelect = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butSubmit = new System.Windows.Forms.Button();
            this.labelContrato = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.SalaryBox = new System.Windows.Forms.NumericUpDown();
            this.MostrarTabla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.telfBox = new System.Windows.Forms.NumericUpDown();
            this.jobIdBox = new System.Windows.Forms.NumericUpDown();
            this.managerID = new System.Windows.Forms.NumericUpDown();
            this.deptId = new System.Windows.Forms.NumericUpDown();
            this.ListaEmpleados = new System.Windows.Forms.ListView();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telfBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobIdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptId)).BeginInit();
            this.SuspendLayout();
            // 
            // butDisconnect
            // 
            this.butDisconnect.Location = new System.Drawing.Point(269, 339);
            this.butDisconnect.Name = "butDisconnect";
            this.butDisconnect.Size = new System.Drawing.Size(103, 44);
            this.butDisconnect.TabIndex = 1;
            this.butDisconnect.Text = "Borrar";
            this.butDisconnect.UseVisualStyleBackColor = true;
            // 
            // butSelect
            // 
            this.butSelect.Location = new System.Drawing.Point(160, 339);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(103, 44);
            this.butSelect.TabIndex = 2;
            this.butSelect.Text = "Select";
            this.butSelect.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(120, 71);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxSname
            // 
            this.textBoxSname.Location = new System.Drawing.Point(120, 45);
            this.textBoxSname.Name = "textBoxSname";
            this.textBoxSname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(375, 339);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(103, 44);
            this.butSubmit.TabIndex = 9;
            this.butSubmit.Text = "Crear";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // labelContrato
            // 
            this.labelContrato.AutoSize = true;
            this.labelContrato.Location = new System.Drawing.Point(12, 101);
            this.labelContrato.Name = "labelContrato";
            this.labelContrato.Size = new System.Drawing.Size(105, 17);
            this.labelContrato.TabIndex = 11;
            this.labelContrato.Text = "Fecha Contrato";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(12, 236);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(64, 17);
            this.Telefono.TabIndex = 13;
            this.Telefono.Text = "Telefono";
            // 
            // SalaryBox
            // 
            this.SalaryBox.DecimalPlaces = 2;
            this.SalaryBox.Location = new System.Drawing.Point(120, 124);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(120, 22);
            this.SalaryBox.TabIndex = 14;
            // 
            // MostrarTabla
            // 
            this.MostrarTabla.Location = new System.Drawing.Point(484, 339);
            this.MostrarTabla.Name = "MostrarTabla";
            this.MostrarTabla.Size = new System.Drawing.Size(100, 44);
            this.MostrarTabla.TabIndex = 15;
            this.MostrarTabla.Text = "Mostrar Tabla";
            this.MostrarTabla.UseVisualStyleBackColor = true;
            this.MostrarTabla.Click += new System.EventHandler(this.MostrarTabla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID Trabajo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Manager ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Salario";
            // 
            // telfBox
            // 
            this.telfBox.Location = new System.Drawing.Point(120, 234);
            this.telfBox.Name = "telfBox";
            this.telfBox.Size = new System.Drawing.Size(120, 22);
            this.telfBox.TabIndex = 29;
            // 
            // jobIdBox
            // 
            this.jobIdBox.Location = new System.Drawing.Point(120, 207);
            this.jobIdBox.Name = "jobIdBox";
            this.jobIdBox.Size = new System.Drawing.Size(120, 22);
            this.jobIdBox.TabIndex = 30;
            // 
            // managerID
            // 
            this.managerID.Location = new System.Drawing.Point(120, 179);
            this.managerID.Name = "managerID";
            this.managerID.Size = new System.Drawing.Size(120, 22);
            this.managerID.TabIndex = 32;
            // 
            // deptId
            // 
            this.deptId.Location = new System.Drawing.Point(120, 151);
            this.deptId.Name = "deptId";
            this.deptId.Size = new System.Drawing.Size(120, 22);
            this.deptId.TabIndex = 33;
            // 
            // ListaEmpleados
            // 
            this.ListaEmpleados.HideSelection = false;
            this.ListaEmpleados.Location = new System.Drawing.Point(251, 12);
            this.ListaEmpleados.Name = "ListaEmpleados";
            this.ListaEmpleados.Size = new System.Drawing.Size(537, 321);
            this.ListaEmpleados.TabIndex = 34;
            this.ListaEmpleados.UseCompatibleStateImageBehavior = false;
            this.ListaEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(124, 96);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(116, 22);
            this.DatePicker.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ListaEmpleados);
            this.Controls.Add(this.deptId);
            this.Controls.Add(this.managerID);
            this.Controls.Add(this.jobIdBox);
            this.Controls.Add(this.telfBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MostrarTabla);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.labelContrato);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSname);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.butSelect);
            this.Controls.Add(this.butDisconnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telfBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobIdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDisconnect;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Label labelContrato;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.NumericUpDown SalaryBox;
        private System.Windows.Forms.Button MostrarTabla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown telfBox;
        private System.Windows.Forms.NumericUpDown jobIdBox;
        private System.Windows.Forms.NumericUpDown managerID;
        private System.Windows.Forms.NumericUpDown deptId;
        private System.Windows.Forms.ListView ListaEmpleados;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}

