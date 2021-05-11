namespace Game
{
    public class EmissionShaderKeywordProvider : IProvider<string>
    {
        private static readonly string emissionKeyword = "_EMISSION";

        public string Get() => emissionKeyword;
    }
}
