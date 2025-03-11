using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class ContinueExperiment : MonoBehaviour
{
    public GameObject demoSession; 
    public GameObject NormalTrainingSession;
    public GameObject TextAfterTraining;

    public GameObject block1;
    public GameObject block2;

    public bool block2Included = false;

    private bool enableDemo = true;
    private bool enableTraining = false;
    private bool enableBlock1 = false;
    private bool enableBlock2 = false;

    private TMP_Text textMP;

    // Start is called before the first frame update
    void Start()
    {
        textMP = GetComponent<TMP_Text>(); 
    }

    // Update is called once per frame
    void Update()
    {

        if (demoSession.GetComponent<demoTrials>().allStimGiven && enableDemo == true)
        {
            PracticeText();
            enableTraining = true;

            if (Input.GetKeyDown(KeyCode.Return) && enableTraining)
            {
                ClearText();
                NormalTrainingSession.SetActive(true);
                gameObject.SetActive(false);
                enableDemo = false;
            }
        }

        else if (NormalTrainingSession.GetComponent<NBacktrainingSession>().allStimGiven && enableTraining == true)
        {
            AfterPracticeText();
            enableBlock1 = true;


            if (Input.GetKeyDown(KeyCode.RightAlt) && enableBlock1)
            {
                ClearText();
                TextAfterTraining.SetActive(true);
                gameObject.SetActive(false);
                enableTraining = false;
            }

            if (Input.GetKeyDown(KeyCode.LeftAlt) && enableTraining)
            {
                ClearText();
                NormalTrainingSession.SetActive(true);
                NormalTrainingSession.GetComponent<NBacktrainingSession>().ResetTraining();
                gameObject.SetActive(false);
                enableTraining = true;
            }
        }
        else if (block1.GetComponent<NBacktrainingSession>().allStimGiven && enableBlock1 == true)
        {
            if (block2Included == false)
            {

                FinishingTheGameText();
                enableBlock2 = true;

                if (Input.GetKeyDown(KeyCode.Return) && enableBlock2)
                {
                    ClearText();
                    gameObject.SetActive(false);
                    enableBlock1 = false;
#if UNITY_EDITOR
                    EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
                }
            }
            if (block2Included)
            {
                AfterBlock1Text();
                enableBlock2 = true;
                if (Input.GetKeyDown(KeyCode.Return) && enableBlock2)
                {
                    ClearText();
                    block2.SetActive(true);
                    gameObject.SetActive(false);
                    enableBlock1 = false;
                }

            }
        }
        else if (block1.GetComponent<NBacktrainingSession>().allStimGiven && enableBlock2 == true)
        {
            FinishingTheGameText();
            if (Input.GetKeyDown(KeyCode.Return) && enableBlock2)
            {
                ClearText();
                gameObject.SetActive(false);
                enableBlock2 = false;
#if UNITY_EDITOR
                EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
            }
        }
    }
    private void PracticeText()
    {
        textMP.text = "Pause \nNu skal du �ve dig lidt...\nG�r dig klar \nTryk p� Enter n�r du er klar";
    }
    private void AfterPracticeText()
    {
        textMP.text = "Pause \nGodt G�et \nVil du �ve dig en gang til? venstre opt = ja / h�jre opt = nej";
    }
    private void AfterBlock1Text()
    {
        textMP.text = "Pause \nGodt G�et \nLad os g�r det sammen en gang til.\nTryk p� Enter for at starte";
    }
    private void FinishingTheGameText()
    {
        textMP.text = "Pause \nTAK � Nu er du f�rdig! \nTryk p� Enter for at afslutte";
    }
    private void ClearText()
    {
        textMP.text = ""; 
    }
}
