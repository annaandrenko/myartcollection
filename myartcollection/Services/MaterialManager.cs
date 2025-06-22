using System.Collections.Generic;
using System.Linq;
using myartcollection.Models;

namespace myartcollection.Services
{
    public class MaterialManager
    {
        private List<ArtMaterial> materials = new();
        public List<ArtMaterial> GetAll()
        {
            return JsonService.Load().Items;
        }
        public void AddMaterial(ArtMaterial material)
        {
            materials.Add(material);
        }
        public void EditMaterial(int index, ArtMaterial updated)
        {
            if (index >= 0 && index < materials.Count)
                materials[index] = updated;
        }
        public void DeleteMaterial(int index)
        {
            if (index >= 0 && index < materials.Count)
                materials.RemoveAt(index);
        }
        public List<ArtMaterial> SearchMaterial(string keyword)
        {
            var collection = JsonService.Load();

            return collection.Items
                .Where(m =>
                    (!string.IsNullOrEmpty(m.Name) && m.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrEmpty(m.Type) && m.Type.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrEmpty(m.Manufacturer) && m.Manufacturer.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrEmpty(m.Description) && m.Description.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }
    }
}
