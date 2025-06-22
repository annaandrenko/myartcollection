namespace myartcollection.Forms
{
    partial class AddLinerForm
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
            cbBrand = new ComboBox();
            cbThickness = new ComboBox();
            tbQuantity = new TextBox();
            btnSave = new Button();
            lblBrand = new Label();
            lblQuantity = new Label();
            lblHardness = new Label();
            SuspendLayout();
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(129, 43);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(182, 33);
            cbBrand.TabIndex = 0;
            // 
            // cbThickness
            // 
            cbThickness.FormattingEnabled = true;
            cbThickness.Location = new Point(129, 99);
            cbThickness.Name = "cbThickness";
            cbThickness.Size = new Size(182, 33);
            cbThickness.TabIndex = 1;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(129, 159);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(182, 31);
            tbQuantity.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(129, 213);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(36, 46);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(70, 25);
            lblBrand.TabIndex = 4;
            lblBrand.Text = "Марка:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(36, 159);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(85, 25);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Кількість:";
            // 
            // lblHardness
            // 
            lblHardness.AutoSize = true;
            lblHardness.Location = new Point(36, 102);
            lblHardness.Name = "lblHardness";
            lblHardness.Size = new Size(90, 25);
            lblHardness.TabIndex = 6;
            lblHardness.Text = "Товщина:";
            // 
            // AddLinerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 288);
            Controls.Add(lblHardness);
            Controls.Add(lblQuantity);
            Controls.Add(lblBrand);
            Controls.Add(btnSave);
            Controls.Add(tbQuantity);
            Controls.Add(cbThickness);
            Controls.Add(cbBrand);
            Name = "AddLinerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddLinerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbBrand;
        private ComboBox cbThickness;
        private TextBox tbQuantity;
        private Button btnSave;
        private Label lblBrand;
        private Label lblQuantity;
        private Label lblHardness;
    }
}