using myartcollection.Models;
using myartcollection.Services;

namespace myartcollection.Forms
{
    public partial class AddLinerForm : Form
    {
        public AddLinerForm()
        {
            InitializeComponent();
            cbThickness.Items.AddRange(new string[]
            {
                "0.03 мм", "0.05 мм", "0.1 мм", "0.2 мм", "0.3 мм", "0.4 мм", "0.5 мм", "0.8 мм", "1.0 мм", "2.0 мм"
            });
            cbThickness.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.Items.AddRange(new string[]
            {
                "Sakura", "Faber-Castell", "Staedtler", "Micron", "FineLiners"
            });
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbBrand.SelectedItem == null || cbThickness.SelectedItem == null || string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Кількість має бути додатнім числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ArtMaterial liner = new ArtMaterial
            {
                Name = $"{cbBrand.SelectedItem} {cbThickness.SelectedItem}",
                Type = "лайнер",
                Quantity = quantity,
                Manufacturer = cbBrand.SelectedItem.ToString(),
                Description = $"Товщина: {cbThickness.SelectedItem}"
            };
            var collection = JsonService.Load();
            collection.Items.Add(liner);
            JsonService.Save(collection);

            this.Tag = liner;
            this.DialogResult = DialogResult.OK;
            (MainForm.ActiveForm as MainForm)?.ReloadMaterials();
            this.Close();
        }
        public AddLinerForm(ArtMaterial materialToEdit) : this()
        {
            cbBrand.SelectedItem = materialToEdit.Manufacturer;
            if (materialToEdit.Description.StartsWith("Товщина: "))
                cbThickness.SelectedItem = materialToEdit.Description.Replace("Товщина: ", "");

            tbQuantity.Text = materialToEdit.Quantity.ToString();
        }

    }
}

