using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class PickUpCanvas : MonoBehaviour
{

    [Header("")]

    [SerializeField] GameObject LevelEndPanel; 
    public GameObject DialogPanel;
    [SerializeField] GameObject DialogPanelPos;
    Vector3 panelstartpos;

    [Header("")]
    [SerializeField] GameObject Girlsroot;

    [SerializeField] GameObject VFXroot;

    [SerializeField] TMP_Text Firstline_t;
    [SerializeField] TMP_Text Answer1_t;
    [SerializeField] TMP_Text Answer2_t;
    [SerializeField] TMP_Text Answer3_t;

    List<string> Dialog = new List<string>();
    List<int> LoseList = new List<int>() { 19 };

   [SerializeField] List<int> WinList = new List<int>() { 11 };
    public int answerindex = 0;
    List<string> FailText = new List<string>();
    List<string> FailAnswer = new List<string>();


    [SerializeField] int indexcheck = 0;
    int age = 0;
   [SerializeField] int winstep_;

    public bool lose = false;
    public bool win = false;


    [Header("Buttons")]

    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] GameObject button3;

    Vector3 buttonstartsize;

    void Start()
    {

        buttonstartsize = button1.GetComponent<RectTransform>().localScale;
        panelstartpos =DialogPanel.GetComponent<RectTransform>().anchoredPosition;
        var pos = DialogPanelPos.GetComponent<RectTransform>().anchoredPosition;
        DialogPanel.GetComponent<RectTransform>().DOAnchorPos(pos, 1f);

        FillingFailText();
        d_1();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) 
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene(0);
        }
    }

    void EndGame() 
    {
        DialogPanel.GetComponent<RectTransform>().DOAnchorPos(panelstartpos, 0.6f);
        LevelEndPanel.gameObject.SetActive(true);
        if (win)
            GetComponent<CanvasController>().win = true;
        GetComponent<CanvasController>().enabled = true;
        int girlno = PlayerPrefs.GetInt("girl");

        // int mekanno = PlayerPrefs.GetInt("mekan");
        Girlsroot.transform.GetChild(girlno-1).gameObject.SetActive(false);
    }

   

    void TextChange() 
    {
        if (!WinList.Contains(indexcheck)      /*LoseList.Contains(indexcheck)*/)
        {
            Answer2_t.transform.parent.gameObject.SetActive(false);
            Answer3_t.transform.parent.gameObject.SetActive(false);
            RandomFailText();
            lose = true;
        }
        else if (WinList.Contains(indexcheck))
        {
            if (win) 
            {
                Answer2_t.transform.parent.gameObject.SetActive(false);
                Answer3_t.transform.parent.gameObject.SetActive(false);
                Firstline_t.text = Dialog[answerindex];
                Answer1_t.text = Dialog[answerindex + 1];
            }
            
            
            if (winstep_ > 1) 
            {
                Firstline_t.text = Dialog[answerindex];
                Answer1_t.text = Dialog[answerindex + 1];
                Answer2_t.text = Dialog[answerindex + 2];
                Answer3_t.text = Dialog[answerindex + 3];
                answerindex += 4;
                winstep_--;
            }
            else 
            {
                Answer2_t.transform.parent.gameObject.SetActive(false);
                Answer3_t.transform.parent.gameObject.SetActive(false);
                Firstline_t.text = Dialog[answerindex];
                Answer1_t.text = Dialog[answerindex + 1];
                win = true;
            }
        }
        else
        {
            Firstline_t.text = Dialog[answerindex];
            Answer1_t.text = Dialog[answerindex + 1];
            Answer2_t.text = Dialog[answerindex + 2];
            Answer3_t.text = Dialog[answerindex + 3];
            answerindex += 4;
        }
    }


    void Wingirl()
    {

        GameObject win = VFXroot.transform.gameObject.transform.GetChild(0).gameObject.transform.GetChild(Random.Range(0, 2)).gameObject;

        win.SetActive(true);

        PlayerPrefs.SetInt("girl", PlayerPrefs.GetInt("girl")+1);
        PlayerPrefs.SetInt("star", PlayerPrefs.GetInt("star") + 1);

        if (PlayerPrefs.GetInt("girl") % 3 == 0) 
        {
            PlayerPrefs.SetInt("mekan", PlayerPrefs.GetInt("mekan") + 1);
            EndGame();
        }
        else 
        {
            EndGame();
        }
    }

    void Failgirl() 
    {

        PlayerPrefs.SetInt("energy", PlayerPrefs.GetInt("energy") - 1);
        GameObject.Find("Energy").transform.GetChild(PlayerPrefs.GetInt("energy")).gameObject.SetActive(false);

        GameObject fail = VFXroot.transform.gameObject.transform.GetChild(1).gameObject.transform.GetChild(Random.Range(0, 2)).gameObject;

        fail.SetActive(true);
        int girlno = PlayerPrefs.GetInt("girl");
       
        PlayerPrefs.SetInt("girl", PlayerPrefs.GetInt("girl") + 1);
        girlno = PlayerPrefs.GetInt("girl");
       

        if (PlayerPrefs.GetInt("girl") %3 == 0)
        {
            PlayerPrefs.SetInt("mekan", PlayerPrefs.GetInt("mekan") + 1);
            EndGame();
        }
        else
        {
            EndGame();
        }
    }

    void ButtonAnimation()
    {

        button1.GetComponent<RectTransform>().localScale = new Vector3(0.01f, 0.01f, 0.01f);
        button1.GetComponent<RectTransform>().DOScale(buttonstartsize, 1).SetEase(Ease.OutBack);

        button2.GetComponent<RectTransform>().localScale = new Vector3(0.01f, 0.01f, 0.01f);
        button2.GetComponent<RectTransform>().DOScale(buttonstartsize, 1).SetEase(Ease.OutBack);

        button3.GetComponent<RectTransform>().localScale = new Vector3(0.01f, 0.01f, 0.01f);
        button3.GetComponent<RectTransform>().DOScale(buttonstartsize, 1).SetEase(Ease.OutBack);

    }

    public void B_1()
    {
        ButtonAnimation();
        if (!lose && !win)
        {
            indexcheck = (age * 4) + 1;
            age++;
        }
        else if (win) 
        {
           // Firstline_t.transform.parent.gameObject.SetActive(false);  // win
            Wingirl();

          
        }
        else
        {
            
           // Firstline_t.transform.parent.gameObject.SetActive(false);   // lose
            Failgirl();
        }

        TextChange();



    }
    public void B_2()
    {
        ButtonAnimation();
        if (!lose)
        {
            indexcheck = (age * 4) + 2;
            age++;
        }
        else
        {
            Firstline_t.transform.parent.gameObject.SetActive(false);
        }
        TextChange();

    }
    public void B_3()
    {
        ButtonAnimation();
        if (!lose)
        {
            indexcheck = (age * 4) + 3;
            age++;
        }
        else
        {
            Firstline_t.transform.parent.gameObject.SetActive(false); 
        }

        TextChange();

    }

    void d_1()
    {
        

        int girlno = PlayerPrefs.GetInt("girl");
        
        // int mekanno = PlayerPrefs.GetInt("mekan");
        Girlsroot.transform.GetChild(girlno).gameObject.SetActive(true);
        Girlsroot.transform.GetChild(girlno).gameObject.GetComponent<g1beach>().DialogLanguageEn();
        Dialog = Girlsroot.transform.GetChild(girlno).GetComponent<g1beach>().GirlDialog;
        LoseList = Girlsroot.transform.GetChild(girlno).GetComponent<g1beach>().LoseList;
        WinList = Girlsroot.transform.GetChild(girlno).GetComponent<g1beach>().WinList;
        winstep_ = Girlsroot.transform.GetChild(girlno).GetComponent<g1beach>().winstep;


        Firstline_t.text = Dialog[answerindex];
        Answer1_t.text = Dialog[answerindex + 1];
        Answer2_t.text = Dialog[answerindex + 2];
        Answer3_t.text = Dialog[answerindex + 3];
        answerindex += 4;



    }

    void RandomFailText() 
    {
        int n = FailText.Count;
        int failindex = Random.Range(0, n);
        Firstline_t.text = FailText[failindex];
        Answer1_t.text = FailAnswer[failindex];
    }

    void FillingFailText()
    {
        for (int i = 0; i < 15; i++)
        {
            string strn = "" + i;
            FailText.Add(strn);
            FailAnswer.Add(strn);

        }

        if (PlayerPrefs.GetString("language") != "tr") 
        {
            FailText[0] = "Leave me alone.";
            FailText[1] = "You're a waste of time.";
            FailText[2] = "I'm bored of you.";
            FailText[3] = "I have to go.";
            FailText[4] = "I think we should stop talking.";
            FailText[5] = "I didn't like your intentions.";
            FailText[6] = "You're arrogant.";
            FailText[7] = "Leave me alone.";
            FailText[8] = "I wish you hadn't said that.";
            FailText[9] = "I'm leaving.";
            FailText[10] = "You can't be serious!";
            FailText[11] = "I don't like you.";
            FailText[12] = "I didn't like your attitude.";
            FailText[13] = "I don't have time for you.";
            FailText[14] = "That's conceited.";


            FailAnswer[0] = "As you Wish.";
            FailAnswer[1] = "You are too.";
            FailAnswer[2] = "I'm crazy about you.";
            FailAnswer[3] = "I'm sure you are.";
            FailAnswer[4] = "It's up to you.";
            FailAnswer[5] = "I don't care.";
            FailAnswer[6] = "That's right.";
            FailAnswer[7] = "With pleasure.";
            FailAnswer[8] = "I couldn't help it.";
            FailAnswer[9] = "Goodbye.";
            FailAnswer[10] = "I'll try.";
            FailAnswer[11] = "Oh well.";
            FailAnswer[12] = "My attitude was fine.";
            FailAnswer[13] = "I'm so disappointed.";
            FailAnswer[14] = "I know.";

        }
        else 
        {
           

            FailText[0] = "Git baþýmdan.";
            FailText[1] = "Zaman kaybýsýn.";
            FailText[2] = "Sýkýldým senden.";
            FailText[3] = "Acelem var gitmem lazým.";
            FailText[4] = "Sanýrým konuþmayý kesmeliyiz.";
            FailText[5] = "Niyetini sevmedim.";
            FailText[6] = "Kabasýn.";
            FailText[7] = "Beni yanlýz býrak.";
            FailText[8] = "Bunu söylemeseydin keþke.";
            FailText[9] = "Ben gidiyorum.";
            FailText[10] = "Ciddi olamazsýn!";
            FailText[11] = "Seni sevmedim.";
            FailText[12] = "Tavrýný sevmedim.";
            FailText[13] = "Sana ayýracak zamaným yok.";
            FailText[14] = "Küstahlýk bu.";


            FailAnswer[0] = "Sen bilirsin.";
            FailAnswer[1] = "Sen de öylesin.";
            FailAnswer[2] = "Ben sana çok bayýlýyorum.";
            FailAnswer[3] = "Eminim öyledir.";
            FailAnswer[4] = "Senin terciðin.";
            FailAnswer[5] = "Çok umrumda sanki.";
            FailAnswer[6] = "Öyleyim.";
            FailAnswer[7] = "Zevkle.";
            FailAnswer[8] = "Tutamadým kendimi.";
            FailAnswer[9] = "Yolun açýk olsun.";
            FailAnswer[10] = "Olurum.";
            FailAnswer[11] = "Tüh be.";
            FailAnswer[12] = "Tavrým güzeldi.";
            FailAnswer[13] = "Aman ne üzüldüm.";
            FailAnswer[14] = "Kabasýn.";
        }
        
    }


}
