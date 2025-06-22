using myartcollection.Models;
using myartcollection.Services;

namespace myartcollection.Forms
{
    public partial class CategoryForm : Form
    {
        private string materialType;
        private MaterialManager manager;

        private List<ArtMaterial> categoryMaterials;
        public List<ArtMaterial> GetUpdatedList()
        {
            return categoryMaterials;
        }

        public CategoryForm(string type, List<ArtMaterial> materials)
        {
            InitializeComponent();
            this.materialType = type;
            switch (materialType)
            {
                case "олівець":
                    lblTitle.Text = "Олівці";
                    break;
                case "графічний":
                    lblTitle.Text = "Графічні матеріали";
                    break;
                case "лайнер":
                    lblTitle.Text = "Лайнери";
                    break;
                default:
                    lblTitle.Text = "Матеріали";
                    break;
            }

            categoryMaterials = new List<ArtMaterial>(materials);
            dgvList.DataSource = null;
            dgvList.DataSource = categoryMaterials;

            dgvList.Columns["Name"].HeaderText = "Назва";
            dgvList.Columns["Type"].HeaderText = "Тип";
            dgvList.Columns["Quantity"].HeaderText = "Кількість";
            dgvList.Columns["Manufacturer"].HeaderText = "Виробник";
            dgvList.Columns["Description"].HeaderText = "Опис";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form formToShow = null;
            if (materialType == "олівець")
                formToShow = new AddPencilForm();
            else if (materialType == "графічний")
                formToShow = new AddGraphicMaterialForm();
            else if (materialType == "лайнер")
                formToShow = new AddLinerForm();
            else
            {
                MessageBox.Show("Невідомий тип матеріалу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (formToShow.ShowDialog() == DialogResult.OK)
            {
                var newMaterial = formToShow.Tag as ArtMaterial;

                if (newMaterial != null)
                {
                    categoryMaterials.Add(newMaterial);
                    dgvList.DataSource = null;
                    dgvList.DataSource = categoryMaterials;
                    var allData = JsonService.Load();
                    allData.Items.RemoveAll(m => m.Type == materialType);
                    allData.Items.AddRange(categoryMaterials);
                    JsonService.Save(allData);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть рядок для видалення.");
                return;
            }
            var confirm = MessageBox.Show("Ви впевнені, що хочете видалити цей матеріал?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;
            var selected = dgvList.SelectedRows[0].DataBoundItem as ArtMaterial;
            if (selected != null)
            {
                categoryMaterials.Remove(selected);
                dgvList.DataSource = null;
                dgvList.DataSource = categoryMaterials;
                JsonService.Save(new MaterialCollection { Items = categoryMaterials });
            }
        }
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null || dgvList.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть матеріал для редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedMaterial = dgvList.CurrentRow.DataBoundItem as ArtMaterial;
            if (selectedMaterial == null)
                return;

            Form editForm = null;

            switch (selectedMaterial.Type)
            {
                case "олівець":
                    editForm = new AddPencilForm(selectedMaterial);
                    break;
                case "графічний":
                    editForm = new AddGraphicMaterialForm(selectedMaterial);
                    break;
                case "лайнер":
                    editForm = new AddLinerForm(selectedMaterial);
                    break;
            }

            if (editForm != null && editForm.ShowDialog() == DialogResult.OK)
            {
                var updatedMaterial = editForm.Tag as ArtMaterial;
                if (updatedMaterial != null)
                {
                    // Заміна у списку
                    int index = categoryMaterials.IndexOf(selectedMaterial);
                    if (index != -1)
                    {
                        categoryMaterials[index] = updatedMaterial;

                        dgvList.DataSource = null;
                        dgvList.DataSource = categoryMaterials;

                        dgvList.Columns["Name"].HeaderText = "Назва";
                        dgvList.Columns["Type"].HeaderText = "Тип";
                        dgvList.Columns["Quantity"].HeaderText = "Кількість";
                        dgvList.Columns["Manufacturer"].HeaderText = "Виробник";
                        dgvList.Columns["Description"].HeaderText = "Опис";


                        JsonService.Save(new MaterialCollection { Items = categoryMaterials });
                    }
                }
            }
        }
    }
}
