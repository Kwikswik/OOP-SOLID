using UnityEngine;

namespace Game
{
    public class MaterialsSelection : ISelection
    {
        private readonly IProvider<Material, Material> material = new SwitcherMaterialProvider();

        private Renderer renderer;
        private Material[] materialsOriginal;

        public MaterialsSelection(Renderer renderer)
        {
            this.renderer = renderer;
        }

        public void Select()
        {
            var materials = renderer.materials;
            var materialsSelect = GetMaterials(materials);

            materialsOriginal = materials;

            renderer.materials = materialsSelect;
        }

        public void Deselect()
        {
            renderer.materials = materialsOriginal;
            materialsOriginal = default;
        }

        private Material[] GetMaterials(Material[] materials)
        {
            if (materials == null)
                return default;

            var count = materials.Length;
            var result = new Material[count];
            for (int i = 0; i < count; i++)
                result[i] = material.Get(materials[i]);

            return result;
        }
    }
}
