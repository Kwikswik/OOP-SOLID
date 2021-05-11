using UnityEngine;

namespace Game
{
    public class SwitcherMaterialProvider : IProvider<Material, Material>
    {
        private readonly IProvider<Material, Material> material = new NewEmissiveMaterialProvider();
        private readonly IProvider<Material, Material> materialDefault = new DefaultMaterialProvider();
        private readonly ICondition<Material> isMaterial = new IsEmissiveMaterialCondition();

        public Material Get(Material material)
        {
            if (isMaterial.Try(material))
                return this.material.Get(material);

            return materialDefault.Get(material);
        }
    }
}
