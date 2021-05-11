using UnityEngine;

namespace Game
{
    public class RayCastTagCondition : ICondition<RaycastHit>
    {
        private readonly IProvider<string> tag = new SelectableTagProvider();

        public bool Try(RaycastHit data) => data.transform.tag == tag.Get();
    }
}
