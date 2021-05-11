using UnityEngine;

namespace Game
{
    public class SelectionProvider : IProvider<ISelection, RaycastHit>
    {
        private readonly IProvider<Renderer, RaycastHit> renderer = new RendererFromRaycastHitProvider();

        public ISelection Get(RaycastHit data) => new OptimizeSelection(new MaterialsSelection(renderer.Get(data)));
    }
}
