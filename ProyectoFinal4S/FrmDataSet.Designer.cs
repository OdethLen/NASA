namespace ProyectoFinal4S
{
    partial class FrmDataSet
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
            btnOpen = new Button();
            dgvData = new DataGridView();
            cmbDeleteType = new ComboBox();
            btnDelete = new Button();
            btnClearData = new Button();
            btnSave = new Button();
            cmbExportFormat = new ComboBox();
            btnExport = new Button();
            cmbClassFilter = new ComboBox();
            btnFilterClass = new Button();
            groupBox1 = new GroupBox();
            btnGoBack = new Button();
            groupBox2 = new GroupBox();
            btnGraphics = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            btnScatterPlot = new Button();
            btnExportPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(31, 22);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(102, 36);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dgvData
            // 
            dgvData.BackgroundColor = SystemColors.ControlLight;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(424, 83);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(772, 215);
            dgvData.TabIndex = 5;
            // 
            // cmbDeleteType
            // 
            cmbDeleteType.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDeleteType.FormattingEnabled = true;
            cmbDeleteType.Location = new Point(95, 21);
            cmbDeleteType.Margin = new Padding(2);
            cmbDeleteType.Name = "cmbDeleteType";
            cmbDeleteType.Size = new Size(116, 28);
            cmbDeleteType.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(31, 67);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 37);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearData
            // 
            btnClearData.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearData.Location = new Point(173, 67);
            btnClearData.Margin = new Padding(2);
            btnClearData.Name = "btnClearData";
            btnClearData.Size = new Size(102, 37);
            btnClearData.TabIndex = 14;
            btnClearData.Text = "Clear data";
            btnClearData.UseVisualStyleBackColor = true;
            btnClearData.Click += btnClearData_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Yu Gothic UI", 11.25F);
            btnSave.Location = new Point(173, 23);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 36);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbExportFormat
            // 
            cmbExportFormat.Font = new Font("Yu Gothic UI", 11.25F);
            cmbExportFormat.FormattingEnabled = true;
            cmbExportFormat.Location = new Point(837, 318);
            cmbExportFormat.Margin = new Padding(2);
            cmbExportFormat.Name = "cmbExportFormat";
            cmbExportFormat.Size = new Size(102, 28);
            cmbExportFormat.TabIndex = 16;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Yu Gothic UI", 11.25F);
            btnExport.Location = new Point(966, 313);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(102, 37);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // cmbClassFilter
            // 
            cmbClassFilter.Font = new Font("Yu Gothic UI", 11.25F);
            cmbClassFilter.FormattingEnabled = true;
            cmbClassFilter.Location = new Point(588, 28);
            cmbClassFilter.Margin = new Padding(2);
            cmbClassFilter.Name = "cmbClassFilter";
            cmbClassFilter.Size = new Size(129, 28);
            cmbClassFilter.TabIndex = 18;
            cmbClassFilter.SelectedIndexChanged += cmbClassFilter_SelectedIndexChanged;
            // 
            // btnFilterClass
            // 
            btnFilterClass.Font = new Font("Yu Gothic UI", 11.25F);
            btnFilterClass.Location = new Point(737, 23);
            btnFilterClass.Margin = new Padding(2);
            btnFilterClass.Name = "btnFilterClass";
            btnFilterClass.Size = new Size(102, 37);
            btnFilterClass.TabIndex = 19;
            btnFilterClass.Text = "Filter";
            btnFilterClass.UseVisualStyleBackColor = true;
            btnFilterClass.Click += btnFilterClass_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDeleteType);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClearData);
            groupBox1.Location = new Point(67, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 125);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Yu Gothic UI", 12F);
            btnGoBack.Location = new Point(67, 28);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(105, 37);
            btnGoBack.TabIndex = 21;
            btnGoBack.Text = "Go back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Location = new Point(67, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 84);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // btnGraphics
            // 
            btnGraphics.Font = new Font("Yu Gothic UI", 11.25F);
            btnGraphics.Location = new Point(162, 327);
            btnGraphics.Margin = new Padding(2);
            btnGraphics.Name = "btnGraphics";
            btnGraphics.Size = new Size(102, 37);
            btnGraphics.TabIndex = 23;
            btnGraphics.Text = "Graphics";
            btnGraphics.UseVisualStyleBackColor = true;
            btnGraphics.Click += btnGraphics_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(67, 380);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(295, 211);
            formsPlot1.TabIndex = 24;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(415, 380);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(485, 211);
            formsPlot2.TabIndex = 25;
            // 
            // btnScatterPlot
            // 
            btnScatterPlot.Font = new Font("Yu Gothic UI", 11.25F);
            btnScatterPlot.Location = new Point(615, 327);
            btnScatterPlot.Margin = new Padding(2);
            btnScatterPlot.Name = "btnScatterPlot";
            btnScatterPlot.Size = new Size(102, 37);
            btnScatterPlot.TabIndex = 26;
            btnScatterPlot.Text = "Scatter";
            btnScatterPlot.UseVisualStyleBackColor = true;
            btnScatterPlot.Click += btnScatterPlot_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new Font("Yu Gothic UI", 11.25F);
            btnExportPDF.Location = new Point(1094, 313);
            btnExportPDF.Margin = new Padding(2);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(102, 37);
            btnExportPDF.TabIndex = 27;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // FrmDataSet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1264, 727);
            Controls.Add(btnExportPDF);
            Controls.Add(btnScatterPlot);
            Controls.Add(formsPlot2);
            Controls.Add(formsPlot1);
            Controls.Add(btnGraphics);
            Controls.Add(groupBox2);
            Controls.Add(btnGoBack);
            Controls.Add(groupBox1);
            Controls.Add(btnFilterClass);
            Controls.Add(cmbClassFilter);
            Controls.Add(btnExport);
            Controls.Add(cmbExportFormat);
            Controls.Add(dgvData);
            Name = "FrmDataSet";
            Text = "Form2";
            Load += FrmDataSet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnOpen;
        private DataGridView dgvData;
        private ComboBox cmbDeleteType;
        private Button btnDelete;
        private Button btnClearData;
        private Button btnSave;
        private ComboBox cmbExportFormat;
        private Button btnExport;
        private ComboBox cmbClassFilter;
        private Button btnFilterClass;
        private GroupBox groupBox1;
        private Button btnGoBack;
        private GroupBox groupBox2;
        private Button btnGraphics;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private Button btnScatterPlot;
        private Button btnExportPDF;
    }
}