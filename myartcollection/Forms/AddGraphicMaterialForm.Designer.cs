namespace myartcollection.Forms
{
    partial class AddGraphicMaterialForm
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
            LBLtYPE = new Label();
            cbType = new ComboBox();
            lblBrand = new Label();
            cbBrand = new ComboBox();
            lblQuantity = new Label();
            tbQuantity = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // LBLtYPE
            // 
            LBLtYPE.AutoSize = true;
            LBLtYPE.Location = new Point(12, 30);
            LBLtYPE.Name = "LBLtYPE";
            LBLtYPE.Size = new Size(130, 25);
            LBLtYPE.TabIndex = 0;
            LBLtYPE.Text = "Тип матеріалу:";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(166, 30);
            cbType.Name = "cbType";
            cbType.Size = new Size(182, 33);
            cbType.TabIndex = 1;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(12, 84);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(97, 25);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Виробник:";
            // 
            // cbBrand
            // 
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(166, 84);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(182, 33);
            cbBrand.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(16, 136);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(85, 25);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Кількість:";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(166, 136);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(182, 31);
            tbQuantity.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(166, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "зберігти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddGraphicMaterialForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 254);
            Controls.Add(btnSave);
            Controls.Add(tbQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cbBrand);
            Controls.Add(lblBrand);
            Controls.Add(cbType);
            Controls.Add(LBLtYPE);
            Name = "AddGraphicMaterialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddGraphicMaterialForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLtYPE;
        private ComboBox cbType;
        private Label lblBrand;
        private ComboBox cbBrand;
        private Label lblQuantity;
        private TextBox tbQuantity;
        private Button btnSave;
    }
}