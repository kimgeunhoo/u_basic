using TMPro;
using UnityEngine;

public class TitleLocalize : MonoBehaviour
{
    TextMeshProUGUI titleText;

    [SerializeField] private string engTitle;
    [SerializeField] private string korTitle;
    public bool Iskorean = true;
    public bool IsEnglish;
    public bool IsJapan;

    private void Awake()
    {
        titleText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        //titleText.text = "ÇÃ·§Æû °ÔÀÓ";
        //titleText.SetText("ÇÃ·§Æû °ÔÀÓ2");
        //titleText.SetText("PlatForm Game");
        if (Iskorean)
        {
            titleText.SetText(korTitle);
        }
        else if (Iskorean)
        {
            titleText.SetText(engTitle);
        }
           
    }

}
