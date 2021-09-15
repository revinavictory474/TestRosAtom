using UnityEngine;

public class ButtonOk : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel;
    
    public void OnMouseDown()
    {
        _settingsPanel.SetActive(false);
    }
}
