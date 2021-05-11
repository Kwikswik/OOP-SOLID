using UnityEngine;

namespace Game
{
    public class DefaultMaterialProvider : IProvider<Material, Material>
    {
        public Material Get(Material material) => material;
    }
}
