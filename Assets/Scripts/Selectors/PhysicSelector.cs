using UnityEngine;

namespace Game
{
    public class PhysicSelector : ISelector
    {
        private readonly ICondition<RaycastHit> condition = new RayCastTagCondition();
        private readonly IProvider<Ray> ray = new CenterOfScreenRayProvider();
        private readonly IProvider<ISelection, RaycastHit> selections = new SelectionProvider();

        public ISelection Get()
        {
            if (Physics.Raycast(ray.Get(), out var hit))
                if (condition.Try(hit))
                    return selections.Get(hit);
            return default;
        }
    }
}
