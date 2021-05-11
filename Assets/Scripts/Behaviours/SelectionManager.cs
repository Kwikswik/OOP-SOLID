using UnityEngine;

namespace Game
{
    public class SelectionManager : MonoBehaviour
    {
        private readonly ISelector selector = new PhysicSelector();

        private ISelection selectionLast;

        private void Update()
        {
            var selection = selector.Get();

            if (selection != selectionLast)
            {
                selectionLast?.Deselect();
                selection?.Select();

                selectionLast = selection;
            }
        }
    }
}
