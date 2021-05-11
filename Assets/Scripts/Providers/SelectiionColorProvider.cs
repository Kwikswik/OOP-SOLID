using UnityEngine;

namespace Game
{
    public class SelectiionColorProvider : IProvider<Color>
    {
        public Color Get() => new Color(2, 0, 0, 1);
    }
}
