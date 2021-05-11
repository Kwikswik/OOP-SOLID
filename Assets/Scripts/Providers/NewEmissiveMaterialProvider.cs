using UnityEngine;

namespace Game
{
    public class NewEmissiveMaterialProvider : IProvider<Material, Material>
    {
        private static int emissionID = Shader.PropertyToID("_EmissionColor");

        private readonly IProvider<string> emissionKeyword = new EmissionShaderKeywordProvider();

        private readonly IProvider<Color> color = new SelectiionColorProvider();

        public Material Get(Material material)
        {
            var result = new Material(material);
            var keyword = emissionKeyword.Get();

            if (!result.IsKeywordEnabled(keyword))
                result.EnableKeyword(keyword);

            result.SetColor(emissionID, color.Get());

            return result;
        }
    }
}
