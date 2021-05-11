using UnityEngine;

namespace Game
{
    public class RendererFromRaycastHitProvider : IProvider<Renderer, RaycastHit>
    {
        public Renderer Get(RaycastHit data) => data.transform?.GetComponent<Renderer>();
    }
}
