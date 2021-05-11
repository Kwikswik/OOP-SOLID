using UnityEngine;

namespace Game
{
    public class MousePositionProvider : IProvider<Vector2>
    {
        public Vector2 Get() => Input.mousePosition;
    }
}
