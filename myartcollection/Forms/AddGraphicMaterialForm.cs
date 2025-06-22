using myartcollection.Models;
using myartcollection.Services;

namespace myartcollection.Forms
{
    public partial class AddGraphicMaterialForm : Form
    {
        public AddGraphicMaterialForm()
        {
            InitializeComponent();
            cbType.Items.AddRange(new string[]
            {
                "вугілля", "сепія", "сангіна"
            });
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.Items.AddRange(new string[]
            {
                "Koh-i-Noor", "Cretacolor", "Faber-Castell", "Derwent"
            });
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbType.SelectedItem == null || cbBrand.SelectedItem == null || string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Кількість має бути додатнім числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var graphic = new ArtMaterial
            {
                Name = $"{cbBrand.SelectedItem} {cbType.SelectedItem}",
                Type = "графічний",
                Quantity = quantity,
                Manufacturer = cbBrand.SelectedItem.ToString(),
                Description = $"Тип: {cbType.SelectedItem}"
            };
            var collection = JsonService.Load();
            collection.Items.Add(graphic);
            JsonService.Save(collection);

            this.Tag = graphic;
            this.DialogResult = DialogResult.OK;
            (MainForm.ActiveForm as MainForm)?.ReloadMaterials();
            this.Close();
        }
        public AddGraphicMaterialForm(ArtMaterial materialToEdit) : this()
        {
            cbType.SelectedItem = materialToEdit.Name; // Припускаємо, що Name — це "Уголь", "Сепія" або "Сангіна"
            tbQuantity.Text = materialToEdit.Quantity.ToString();
        }
    }
}