using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
public class SelectButtonScript : MonoBehaviour
{
    [SerializeField] Button selectButton;
    [SerializeField] GameObject screen2;
    [SerializeField] GameObject screen1;


    public void SelectButton()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
        
    }

    public void OnClick()
    {
        SelectButton();
    }



}
