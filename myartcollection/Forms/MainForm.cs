using System.ComponentModel;
using System.Data;
using myartcollection.Models;
using myartcollection.Services;

namespace myartcollection.Forms
{
    public partial class MainForm : Form
    {
        private MaterialCollection materialCollection;
        private ComboBox cmbCriteria;
        private List<ArtMaterial> allMaterials;

        public MainForm()
        {
            InitializeComponent();

            cmbCriteria.Items.AddRange(new string[] { "Тип", "Виробник", "Кількість", "Ім'я", "Опис" });
            cmbCriteria.DropDownStyle = ComboBoxStyle.DropDownList;

            materialCollection = JsonService.Load();
            allMaterials = materialCollection.Items;

            cmbSearch.Items.Clear();
            cmbSearch.Text = "";
            dgvMaterials.DataSource = null;

        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbSearch = new ComboBox();
            btnSearch = new Button();
            dgvMaterials = new DataGridView();
            cmbCriteria = new ComboBox();
            ((ISupportInitialize)dgvMaterials).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aurora", 27.9999962F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 19);
            label1.Name = "label1";
            label1.Size = new Size(413, 66);
            label1.TabIndex = 0;
            label1.Text = "мої матеріали";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Aurora ExtraBold", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(38, 133);
            button1.Name = "button1";
            button1.Size = new Size(510, 103);
            button1.TabIndex = 1;
            button1.Text = "олівці";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Font = new Font("Aurora ExtraBold", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(38, 256);
            button2.Name = "button2";
            button2.Size = new Size(510, 103);
            button2.TabIndex = 2;
            button2.Text = "графічні матеріли";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Font = new Font("Aurora ExtraBold", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(38, 389);
            button3.Name = "button3";
            button3.Size = new Size(510, 103);
            button3.TabIndex = 3;
            button3.Text = "лайнери";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cmbSearch
            // 
            cmbSearch.BackColor = Color.White;
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Location = new Point(780, 119);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(149, 33);
            cmbSearch.TabIndex = 4;
        //    cmbSearch.SelectedIndexChanged += cmbSearch_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Aurora ExtraBold", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(712, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(217, 69);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "пошук";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvMaterials
            // 
            dgvMaterials.BackgroundColor = Color.MintCream;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Aurora", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Peru;
            dataGridViewCellStyle1.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Aurora", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.Peru;
            dataGridViewCellStyle2.SelectionBackColor = Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMaterials.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMaterials.GridColor = Color.SaddleBrown;
            dgvMaterials.Location = new Point(628, 179);
            dgvMaterials.Name = "dgvMaterials";
            dgvMaterials.ReadOnly = true;
            dgvMaterials.RowHeadersWidth = 62;
            dgvMaterials.Size = new Size(301, 313);
            dgvMaterials.TabIndex = 6;
            dgvMaterials.CellContentClick += dgvMaterials_CellContentClick;
            // 
            // cmbCriteria
            // 
            cmbCriteria.BackColor = Color.White;
            cmbCriteria.FormattingEnabled = true;
            cmbCriteria.Location = new Point(625, 119);
            cmbCriteria.Name = "cmbCriteria";
            cmbCriteria.Size = new Size(149, 33);
            cmbCriteria.TabIndex = 7;
            cmbCriteria.SelectedIndexChanged += cmbCriteria_SelectedIndexChanged;
            // 
            // MainForm
            // 
            BackColor = Color.Orange;
            ClientSize = new Size(957, 532);
            Controls.Add(cmbCriteria);
            Controls.Add(dgvMaterials);
            Controls.Add(btnSearch);
            Controls.Add(cmbSearch);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize)dgvMaterials).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label label1;
        private Button button1;
        private Button button2;
        private ComboBox cmbSearch;
        private Button btnSearch;
        private DataGridView dgvMaterials;
        private Button button3;

        private void button1_Click(object sender, EventArgs e)
        {
            materialCollection = JsonService.Load();
            allMaterials = materialCollection.Items;
            var pencils = allMaterials
                .Where(m => m.Type == "олівець")
                .ToList();

            var form = new CategoryForm("олівець", pencils);

            if (form.ShowDialog() == DialogResult.OK)
            {
                allMaterials.RemoveAll(m => m.Type == "олівець");
                allMaterials.AddRange(form.GetUpdatedList());
                JsonService.Save(new MaterialCollection { Items = allMaterials });
                UpdateSearchSuggestions();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbCriteria.SelectedItem == null || cmbSearch.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть критерій та значення для пошуку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string criterion = cmbCriteria.SelectedItem.ToString();
            string keyword = cmbSearch.SelectedItem.ToString();

            var results = allMaterials.Where(mat =>
                (criterion == "Тип" && mat.Type == keyword) ||
                (criterion == "Виробник" && mat.Manufacturer == keyword) ||
                (criterion == "Кількість" && mat.Quantity.ToString() == keyword) ||
                (criterion == "Ім'я" && mat.Name == keyword) ||
                (criterion == "Опис" && mat.Description == keyword)
            ).ToList();

            dgvMaterials.DataSource = results;
            UpdateGridHeaders();
        }

        public void UpdateSearchSuggestions()
        {
            var suggestions = new AutoCompleteStringCollection();

            foreach (var mat in allMaterials)
            {
                suggestions.Add(mat.Name);
                suggestions.Add(mat.Type);
            }

            cmbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbSearch.AutoCompleteCustomSource = suggestions;

            cmbSearch.Items.Clear();
            cmbSearch.Items.AddRange(suggestions.Cast<string>().Distinct().ToArray());
        }
        private MaterialManager manager = new MaterialManager();
      //  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
      //{
      //    string selected = cmbSearch.Text.Trim();
      //    var results = manager.SearchMaterial(selected);
      ///    dgvMaterials.DataSource = results;
       // }

        private List<ArtMaterial> pencils;

        private void button2_Click(object sender, EventArgs e)
        {
            materialCollection = JsonService.Load();
            allMaterials = materialCollection.Items;

            var graphic = allMaterials
                .Where(m => m.Type == "графічний")
                .ToList();

            var form = new CategoryForm("графічний", graphic);

            if (form.ShowDialog() == DialogResult.OK)
            {
                allMaterials.RemoveAll(m => m.Type == "графічний");
                allMaterials.AddRange(form.GetUpdatedList());
                JsonService.Save(new MaterialCollection { Items = allMaterials });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            materialCollection = JsonService.Load();
            allMaterials = materialCollection.Items;

            var liners = allMaterials
                .Where(m => m.Type == "лайнер")
                .ToList();

            var form = new CategoryForm("лайнер", liners);

            if (form.ShowDialog() == DialogResult.OK)
            {
                allMaterials.RemoveAll(m => m.Type == "лайнер");
                allMaterials.AddRange(form.GetUpdatedList());
                JsonService.Save(new MaterialCollection { Items = allMaterials });
            }
        }

        private void dgvMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSearchValues();
            if (cmbCriteria.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть критерій пошуку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCriterion = cmbCriteria.SelectedItem.ToString();

            var values = new HashSet<string>();

            foreach (var mat in allMaterials)
            {
                switch (selectedCriterion)
                {
                    case "Тип":
                        values.Add(mat.Type);
                        break;
                    case "Виробник":
                        values.Add(mat.Manufacturer);
                        break;
                    case "Кількість":
                        values.Add(mat.Quantity.ToString());
                        break;
                    case "Ім'я":
                        values.Add(mat.Name);
                        break;
                    case "Опис":
                        values.Add(mat.Description);
                        break;
                }

            }

            cmbSearch.Items.Clear();
            cmbSearch.Items.AddRange(values.ToArray());
        }

        private void UpdateGridHeaders()
        {
            if (dgvMaterials.Columns.Contains("Name")) dgvMaterials.Columns["Name"].HeaderText = "Назва";
            if (dgvMaterials.Columns.Contains("Type")) dgvMaterials.Columns["Type"].HeaderText = "Тип";
            if (dgvMaterials.Columns.Contains("Quantity")) dgvMaterials.Columns["Quantity"].HeaderText = "Кількість";
            if (dgvMaterials.Columns.Contains("Manufacturer")) dgvMaterials.Columns["Manufacturer"].HeaderText = "Виробник";
            if (dgvMaterials.Columns.Contains("Description")) dgvMaterials.Columns["Description"].HeaderText = "Опис";
        }
        public void UpdateSearchValues()
        {
            if (cmbCriteria.SelectedItem == null)
                return;

            string selectedCriterion = cmbCriteria.SelectedItem.ToString();
            var values = new HashSet<string>();

            foreach (var mat in allMaterials)
            {
                switch (selectedCriterion)
                {
                    case "Тип":
                        values.Add(mat.Type);
                        break;
                    case "Виробник":
                        values.Add(mat.Manufacturer);
                        break;
                    case "Кількість":
                        values.Add(mat.Quantity.ToString());
                        break;
                    case "Назва":
                        values.Add(mat.Name);
                        break;
                    case "Опис":
                        values.Add(mat.Description);
                        break;
                }
            }

            cmbSearch.Items.Clear();
            cmbSearch.Items.AddRange(values.OrderBy(v => v).ToArray());
        }

        public void ReloadMaterials()
        {
            materialCollection = JsonService.Load();
            allMaterials = materialCollection.Items;
            UpdateSearchSuggestions();
        }
    }
}
