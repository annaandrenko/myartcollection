namespace myartcollection.Forms
{
    partial class AddPencilForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbHardness;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblHardness;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cbBrand = new ComboBox();
            cbHardness = new ComboBox();
            tbQuantity = new TextBox();
            lblBrand = new Label();
            lblHardness = new Label();
            lblQuantity = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(150, 27);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(200, 33);
            cbBrand.TabIndex = 1;
            // 
            // cbHardness
            // 
            cbHardness.FormattingEnabled = true;
            cbHardness.Location = new Point(150, 77);
            cbHardness.Name = "cbHardness";
            cbHardness.Size = new Size(200, 33);
            cbHardness.TabIndex = 3;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(150, 127);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(200, 31);
            tbQuantity.TabIndex = 5;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(30, 30);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(70, 25);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Марка:";
            // 
            // lblHardness
            // 
            lblHardness.AutoSize = true;
            lblHardness.Location = new Point(30, 80);
            lblHardness.Name = "lblHardness";
            lblHardness.Size = new Size(82, 25);
            lblHardness.TabIndex = 2;
            lblHardness.Text = "М'якість:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(30, 130);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(85, 25);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Кількість:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // AddPencilForm
            // 
            ClientSize = new Size(400, 250);
            Controls.Add(btnSave);
            Controls.Add(tbQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cbHardness);
            Controls.Add(lblHardness);
            Controls.Add(cbBrand);
            Controls.Add(lblBrand);
            Name = "AddPencilForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додавання олівця";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
