using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class SettingsPanelController : MonoBehaviour
{

    [SerializeField] Button TrButton;
    [SerializeField] Button EngButton;
    [SerializeField] GameObject OpenMenuButton;
    [SerializeField] GameObject FadePanel;

    Vector3 StartAncor;

    [SerializeField] float FadepanelDuration=0.6f;

    void Awake()
    {

        FadePanel.GetComponent<Image>().DOFade(0, FadepanelDuration);

       

        StartAncor = GetComponent<RectTransform>().anchoredPosition;
        OpenMenuButton.GetComponent<RectTransform>().DOAnchorPos(new Vector3(694, -255, 0), 1).SetEase(Ease.InOutQuad);
        if (PlayerPrefs.GetString("language") == "tr") 
        {
            TrButton.interactable = false;
            EngButton.interactable = true;
        }
        else 
        {
            TrButton.interactable = true;
            EngButton.interactable = false;
        }
    }

    
    public void CloseMenu() 
    {
        GetComponent<RectTransform>().DOAnchorPos(StartAncor, 1).SetEase(Ease.InOutQuad)
            .OnComplete(() => OpenMenuButton.SetActive(true));
        
    }

   

    public void LanguageTR() 
    {
        PlayerPrefs.SetString("language", "tr");
        TrButton.interactable = false;
        EngButton.interactable = true;
        FadePanel.GetComponent<Image>().DOFade(0.2f, 0.3f)
            .OnComplete(() => SceneManager.LoadScene(0));

    }

    public void LanguageEN() 
    {
        PlayerPrefs.SetString("language", "en");
        TrButton.interactable = true;
        EngButton.interactable = false;
        FadePanel.GetComponent<Image>().DOFade(0.2f, 0.3f)
                    .OnComplete(() => SceneManager.LoadScene(0));

    }

    public void OpenMenu() 
    {
        OpenMenuButton.SetActive(false);
        GetComponent<RectTransform>().DOAnchorPos(new Vector3(0, 0, 0), 1).SetEase(Ease.InOutQuad);
    }

}
