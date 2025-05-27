namespace GororobaUI.Services
{
    public class MenuStateService
    {
        private bool _isCollapsed;
        public bool IsCollapsed => _isCollapsed;

        public event Action? OnChange;

        public void ToggleMenu()
        {
            _isCollapsed = !_isCollapsed;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}
