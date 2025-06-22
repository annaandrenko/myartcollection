using myartcollection.Models;
using myartcollection.Services;

namespace myartcollection.Forms
{
    public partial class AddPencilForm : Form
    {
        public AddPencilForm()
        {
            InitializeComponent();
            cbBrand.Items.AddRange(new string[] { "Koh-i-Noor", "Marco", "Faber-Castell" });
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHardness.Items.AddRange(new string[]
            {
                "8B", "7B", "6B", "5B", "4B", "3B", "2B", "HB",
                "2H", "3H", "4H", "5H", "6H", "7H", "8H"
            });
            cbHardness.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cbBrand.SelectedItem == null || cbHardness.SelectedItem == null || string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Кількість має бути додатнім числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ArtMaterial pencil = new ArtMaterial
            {
                Name = $"{cbBrand.SelectedItem} {cbHardness.SelectedItem}",
                Type = "олівець",
                Quantity = quantity,
                Manufacturer = cbBrand.SelectedItem.ToString(),
                Description = "М'якість: " + cbHardness.SelectedItem.ToString()
            };
            var collection = JsonService.Load();
            collection.Items.Add(pencil);
            JsonService.Save(collection);

            this.Tag = pencil;
            this.DialogResult = DialogResult.OK;
            (MainForm.ActiveForm as MainForm)?.ReloadMaterials();
            this.Close();

        }

        public AddPencilForm(ArtMaterial materialToEdit) : this()
        {
            cbBrand.SelectedItem = materialToEdit.Manufacturer;
            cbHardness.SelectedItem = materialToEdit.Description.Replace("М'якість: ", "");
            tbQuantity.Text = materialToEdit.Quantity.ToString();
        }

    }
}
