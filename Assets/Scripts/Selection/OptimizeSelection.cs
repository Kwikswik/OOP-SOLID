namespace Game
{
    public class OptimizeSelection : ISelection
    {
        private ISelection selection;
        private bool isSelected;

        public OptimizeSelection(ISelection selection) => this.selection = selection;

        public void Select()
        {
            if (!isSelected)
            {
                selection.Select();
                isSelected = true;
            }
        }

        public void Deselect()
        {
            if (isSelected)
            {
                selection.Deselect();
                isSelected = false;
            }
        }
    }
}
