using UnityEngine;

namespace Game
{
    public class IsEmissiveMaterialCondition : ICondition<Material>
    {
        private readonly IProvider<string> emissionKeyword = new EmissionShaderKeywordProvider();

        public bool Try(Material material)
        {
            if (material == null)
                return false;

            var key = emissionKeyword.Get();

            if (material.IsKeywordEnabled(key))
                return true;

            if (material.HasProperty(key))
                return true;

            return true;
        }
    }
}
