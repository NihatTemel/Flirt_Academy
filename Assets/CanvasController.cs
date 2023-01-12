using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{

    [SerializeField] float duration = 1;

    public GameObject StarRoot;
    public GameObject NextButton;
    public GameObject LevelCompeted;
    public GameObject LevelFailed;
    public GameObject MenuButton;

    [SerializeField] Image LevelEndPanel;
    public GameObject DialogPanel;
    [SerializeField] GameObject DialogPanelPos;
    [SerializeField] GameObject NextMapText;

    public GameObject[] StarSpaces;
    public GameObject[] Stars;
    public float overshootAmount = 0.1f;

    [Header("")]

    [SerializeField] Slider mySlider;

    public bool win = false;
    public int starsno;


    private void Start()
    {

        Debug.Log("Starts -> " + PlayerPrefs.GetInt("star"));

        LevelEndPanel.DOFade(0.3f, 0.5f);

        MenuButton.SetActive(false);

        SliderControl();

        //TweenStarsScale();


        if (win)
            LevelCompeted.GetComponent<RectTransform>().DOAnchorPos(new Vector3(0, 897, 0), duration).SetEase(Ease.InOutQuad); // .OnComplete(() => TweenStarsScale());
        else
            LevelFailed.GetComponent<RectTransform>().DOAnchorPos(new Vector3(0, 897, 0), duration).SetEase(Ease.InOutQuad); //.OnComplete(() => TweenStarsScale());

        if (PlayerPrefs.GetInt("girl") % 3 == 0)
        {
            starsno = PlayerPrefs.GetInt("star");
            PlayerPrefs.SetInt("star", 0);
            StarRoot.SetActive(true);
            StarRoot.GetComponent<RectTransform>().DOAnchorPos(new Vector3(0, 0, 0), duration).SetEase(Ease.InOutQuad).OnComplete(() => TweenStarsScale());
        }

    }

    void SliderControl() 
    {
        float n;
        if(PlayerPrefs.GetInt("girl") % 3 == 1) 
        {
            n = 0.33f;
            mySlider.value = 0;
        }
        else if(PlayerPrefs.GetInt("girl") % 3 == 2)
        {
            n = 0.66f;
            mySlider.value = 0.33f;
        }
        else 
        {
            n = 1;
            mySlider.value = 0.66f;
           // NextMapText.transform.DOScale(new Vector3(7, 7, 7), 1f).SetEase(Ease.InOutQuad);
        }
        mySlider.DOValue(n, 2.5f)
            .OnComplete(() => NextButton.GetComponent<RectTransform>().DOAnchorPos(new Vector3(0, -1032, 0), duration / 2).SetEase(Ease.InOutQuad)); /*.OnComplete(() => NextMapText.transform.DOScale(new Vector3(7, 7, 7) + new Vector3(overshootAmount * 2, overshootAmount * 2, overshootAmount * 2), 1.75f).SetEase(Ease.OutBounce)
            .OnComplete(() => NextMapText.transform.DOScale(new Vector3(7, 7, 7) + new Vector3(overshootAmount * 2, overshootAmount * 2, overshootAmount * 2), 1.75f)
            .SetEase(Ease.OutBounce)
            .OnComplete(() => NextMapText.transform.DOScale(new Vector3(7, 7, 7), 1f).SetEase(Ease.InOutQuad),)
            .OnComplete(() => NextButton.GetComponent<RectTransform>().DOAnchorPos(new Vector3(0, -1032, 0), duration / 2).SetEase(Ease.InOutQuad))));*/
    }


    public void TweenStarsScale()
    {
        if(starsno > 0)
             TweenStarScale(0);
        else 
        {
           // NextButton.GetComponent<RectTransform>().DOAnchorPos(new Vector3(0, -1032, 0), duration / 2).SetEase(Ease.InOutQuad);
        }
    }

    private void TweenStarScale(int index)
    {
        
        
        Stars[index].transform.DOScale(new Vector3(1, 1, 1) + new Vector3(overshootAmount * 2, overshootAmount * 2, overshootAmount * 2), 1.75f)
            .SetEase(Ease.OutBounce)
            .OnComplete(() => Stars[index].transform.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.InOutQuad))
            .OnComplete(() =>
            {
                
                if (index < starsno - 1 )
                {
                    
                    TweenStarScale(index + 1);
                }
                //PlayerPrefs.SetInt("star", PlayerPrefs.GetInt("star") - 1);
            });
    }



    public void NextLevel() 
    {
        SceneManager.LoadScene(0);
    }

}

    
