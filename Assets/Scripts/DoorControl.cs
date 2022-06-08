using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DoorControl : ScoreControl
{
    public GameObject doorCylinderLeft;
    public GameObject doorCylinderRight;
    int scoreInt;
    int constantScoreInt;
    public Animator doorLeftAnimator;
    public Animator doorRightAnimator;
    public Animator risingPlaneAnimator;
    public Image levelImage;
    int counterStone;
    
    

    public TextMeshPro constantScore;

    void Start()
    {
        levelImage.fillAmount = 0;
        counterStone = 0;
        
    }
    void Update()
    {
        DoorControlForMove();
    }

    void DoorControlForMove()
    {
        scoreInt = int.Parse(score.text.ToString());
        constantScoreInt = int.Parse(constantScore.text.ToString());
        if (scoreInt >= constantScoreInt)
        {
            cloneStoneAnima.SetBool("CloneStoneAnima", true);
            StartCoroutine(PlaneRisingTime());
        }
    }
    IEnumerator PlaneRisingTime()
    {
        yield return new WaitForSeconds(3);
        levelImage.fillAmount = 1;
        doorRightAnimator.SetBool("DoorRight", true);
        doorLeftAnimator.SetBool("DoorLeft", true);
        risingPlaneAnimator.SetBool("RisingPlane", true);
        
    }

}
 