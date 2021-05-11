using UnityEngine;

namespace Game
{
    public class CenterOfScreenRayProvider : IProvider<Ray>
    {
        private readonly IProvider<Camera> camera = new MainCameraProvider();
        private readonly IProvider<Vector2> screenPoint = new MousePositionProvider();

        public Ray Get() => camera.Get().ScreenPointToRay(screenPoint.Get());
    }
}
