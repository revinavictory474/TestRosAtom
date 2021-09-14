using UnityEngine;

namespace UI
{
    internal class ButtonSettings : MonoBehaviour
    {
        [SerializeField] private GameObject _settingsPanel;

        public void OpenSettingMenu()
        {
            _settingsPanel.SetActive(true);
        }

        //public void CloseSettingsMenu()
        //{
        //    _settingsPanel.SetActive(false);
        //}
    }
}
