using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelControl : MonoBehaviour
{
    public TextMeshProUGUI levelNow;
    public TextMeshProUGUI levelFuture;
    public GameObject finishLine;
    int counterScene;
    int counterLevel;
    int counterLevelPrefs;
    bool boolLevel;

    public void Start()
    {
        GetStarted();
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
    }

    void GetStarted()
    {
        if (PlayerPrefs.HasKey("counterLevelSave"))
        {
            counterLevel = PlayerPrefs.GetInt("counterLevelSave");
        }
        else
        {
            counterLevel = 1;
        }
        levelNow.text = counterLevel.ToString();
        levelFuture.text = (counterLevel + 1).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bottom")
        {
            counterLevel++;
            Debug.Log(counterLevel);
            PlayerPrefs.SetInt("counterLevelSave", counterLevel);
            //levelNow.text = counterLevel.ToString();
            //levelFuture.text = (counterLevel + 1).ToString();
            StartCoroutine(SceneControlCoroutine());
        }
        
    }
    
    void SceneControl()
    {
        if (counterLevel%3 ==1)
        {
            SceneManager.LoadScene(1);
        }
       else if(counterLevel%3 ==2)
        {
            SceneManager.LoadScene(2);
        }
       else if(counterLevel%3==0)
        {
            SceneManager.LoadScene(3);
        }
    }

    IEnumerator SceneControlCoroutine()
    {
        
        yield return new WaitForSeconds(3);
        SceneControl();
    }


}
    