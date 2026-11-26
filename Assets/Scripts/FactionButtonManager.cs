using TMPro;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;
public class FactionButtonManager : MonoBehaviour
{
    [SerializeField] Button factionButton;
    [SerializeField] GameObject chooseButton;
    [SerializeField] RawImage default1;
    

    public void FactionButton()
    {
        chooseButton.SetActive(true);
        
    }

    public void OnClick()
    {
        FactionButton();
    }
}
