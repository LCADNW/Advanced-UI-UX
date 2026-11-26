using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class ChooseButtonScript : MonoBehaviour
{
    [SerializeField] Button chooseutton;
  
    public void ChooseButton()
    {
        Application.Quit();
    }

    public void OnClick()
    {
        ChooseButton();
    }



}