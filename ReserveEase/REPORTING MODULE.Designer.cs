using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

public partial class REPORTING_MODULE : Form
{
    public REPORTING_MODULE()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.txtReportSummary = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reporting Module";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Occupancy Report",
            "Revenue Report",
            "Guest Statistics"});
            this.cmbReportType.Location = new System.Drawing.Point(11, 63);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(200, 21);
            this.cmbReportType.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(217, 61);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 23);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvReportData
            // 
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Location = new System.Drawing.Point(12, 90);
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.Size = new System.Drawing.Size(760, 250);
            this.dgvReportData.TabIndex = 3;
            // 
            // txtReportSummary
            // 
            this.txtReportSummary.Location = new System.Drawing.Point(12, 360);
            this.txtReportSummary.Multiline = true;
            this.txtReportSummary.Name = "txtReportSummary";
            this.txtReportSummary.Size = new System.Drawing.Size(760, 60);
            this.txtReportSummary.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(105)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.cmbReportType);
            this.panel1.Controls.Add(this.btnGenerateReport);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 461);
            this.panel1.TabIndex = 5;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // REPORTING_MODULE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.txtReportSummary);
            this.Controls.Add(this.dgvReportData);
            this.Controls.Add(this.panel1);
            this.Name = "REPORTING_MODULE";
            this.Text = "Reporting Module";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private Label lblTitle;
    private ComboBox cmbReportType;
    private Button btnGenerateReport;
    private DataGridView dgvReportData;
    private TextBox txtReportSummary;

    private void btnGenerateReport_Click(object sender, EventArgs e)
    {
        // Code to generate and display report based on the selected report type
    }

    private Panel panel1;
    private System.DirectoryServices.DirectorySearcher directorySearcher1;
}
