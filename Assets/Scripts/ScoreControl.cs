using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ScoreControl :Instantiate
{
    public TextMeshPro score;
    bool failureControl;

    int counterScore= 0 ;

    void Start()
    {
        counterScore = 0 ;
        failureControl = true;
    }

    
    void Update()
    {
        MakeFailureControl();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        counterScore += 1;
        if(counterScore ==1)
        {
            failureControl = false;
        }
        score.text = counterScore.ToString();
        other.gameObject.SetActive(false);      
    }

    void MakeFailureControl()
    {
        if (failureControl == false)
        {
            failureControl = true;
            StartCoroutine(MakeFailureControlNumerator());
        }
    }
    IEnumerator MakeFailureControlNumerator()
    {
        yield return new WaitForSeconds(3);
        if(counterScore<20)
        {
            SceneManager.LoadScene(1);
            PlayerPrefs.DeleteAll();
        }
    }
}
