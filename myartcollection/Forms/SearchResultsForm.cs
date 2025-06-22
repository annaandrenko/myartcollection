using myartcollection.Models;

namespace myartcollection.Forms
{
    public partial class SearchResultsForm : Form
    {
        public SearchResultsForm(List<ArtMaterial> results, string keyword)
        {
            InitializeComponent();
            lblTitle.Text = $"Результати пошуку: {keyword}";
            dgvResults.DataSource = results;
        }
        private Label lblTitle;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(137, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(-2, 46);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 62;
            dgvResults.Size = new Size(360, 225);
            dgvResults.TabIndex = 1;
            // 
            // SearchResultsForm
            // 
            ClientSize = new Size(355, 271);
            Controls.Add(dgvResults);
            Controls.Add(lblTitle);
            Name = "SearchResultsForm";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private DataGridView dgvResults;
    }
}
