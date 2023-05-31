namespace PryCantallops_TP1
{
    partial class frmTablas
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
            this.btnDB = new System.Windows.Forms.Button();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreDB = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(104, 12);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(452, 33);
            this.btnDB.TabIndex = 0;
            this.btnDB.Text = "Seleccionar DataBase";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // dgvTablas
            // 
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(12, 110);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(637, 208);
            this.dgvTablas.TabIndex = 3;
            this.dgvTablas.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbTablas
            // 
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(145, 82);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(136, 21);
            this.cmbTablas.TabIndex = 4;
            this.cmbTablas.Visible = false;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar tabla";
            this.label1.Visible = false;
            // 
            // lblNombreDB
            // 
            this.lblNombreDB.AutoSize = true;
            this.lblNombreDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDB.Location = new System.Drawing.Point(247, 48);
            this.lblNombreDB.Name = "lblNombreDB";
            this.lblNombreDB.Size = new System.Drawing.Size(52, 18);
            this.lblNombreDB.TabIndex = 6;
            this.lblNombreDB.Text = "label2";
            this.lblNombreDB.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(451, 324);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(132, 33);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 362);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblNombreDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.btnDB);
            this.Name = "frmTablas";
            this.Text = "TABLAS";
            this.Load += new System.EventHandler(this.frmTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreDB;
        private System.Windows.Forms.Button btnMenu;
    }
}