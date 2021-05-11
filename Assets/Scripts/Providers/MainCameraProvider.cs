using UnityEngine;

namespace Game
{
    public class MainCameraProvider : IProvider<Camera>
    {
        public Camera Get() => Camera.main;
    }
}
