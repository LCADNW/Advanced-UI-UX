using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
public class SideBarNav : MonoBehaviour
{
    [SerializeField] Button deckSelectionButton;
    [SerializeField] Button factionSelectionButton;
    [SerializeField] GameObject screen2;
    [SerializeField] GameObject screen1;
    [SerializeField] UnityEngine.UI.Image image;

    [SerializeField] Sprite deckS, factionS;
  

    private void Start()
    {
        image = GetComponent<UnityEngine.UI.Image>();

    }
    public void DeckSelectionButton()
    {
        screen2.SetActive(false);
        screen1.SetActive(true);
        image.sprite = deckS;
    }

    public void FactionSelectionButton()
    {
        screen2.SetActive(true);
        screen1.SetActive(false);
        image.sprite = factionS;

    }


    public void OnClick()
    {
     if (deckSelectionButton.CompareTag("deckS"))
        {
            Debug.Log("meow");
            DeckSelectionButton();
            return;
        }

        if (factionSelectionButton.CompareTag("factionS"))
        {
            Debug.Log("meow");
            FactionSelectionButton();
            return;
        }
    }



}
