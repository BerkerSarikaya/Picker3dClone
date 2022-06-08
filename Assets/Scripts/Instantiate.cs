using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject cloneSphere;
    Vector3 clonePosition = new Vector3();
    public GameObject cloneStone;
    Vector3 stoneClonePosition = new Vector3();
    int counter;
    int counterSquare;
    int counterCloneSquare;
    public Animator cloneStoneAnima;


    void Start()
    {
        clonePosition = cloneSphere.transform.position;
        stoneClonePosition = cloneStone.transform.position;
        counter = 0;
        counterSquare = 0;
        counterCloneSquare = 0;

        CreateShapeOnPlane();

    }

    void Update()
    {
        
    }

    void MakeCloneToLeftAngle()
    {
        for (int i = 0; i < 6; i++)
        {
            clonePosition += new Vector3(-1f, 0, 2f);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
            counter++;
        }
        
    }

    void MakeCloneToRightAngle()
    {
        for (int i = 0; i < 6; i++)
        {
            clonePosition += new Vector3(+1f, 0, 2f);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
            counter++;
        }

    }

    void MakeCloneSquare()
    {
        for (int j = 0; j < 4; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                clonePosition += new Vector3(0, 0, 1);
                Instantiate(cloneSphere, clonePosition, Quaternion.identity);
                clonePosition += new Vector3(1, 0, -1);
                Instantiate(cloneSphere, clonePosition, Quaternion.identity);
                clonePosition += new Vector3(0, 0, 1);
                Instantiate(cloneSphere, clonePosition, Quaternion.identity);
                if (i != 2)
                {
                    clonePosition += new Vector3(2, 0, 6);
                    Instantiate(cloneSphere, clonePosition, Quaternion.identity);
                }
            }
            if (j != 3)
            {
                clonePosition += new Vector3(-7, 0, 2);
                Instantiate(cloneSphere, clonePosition, Quaternion.identity);
            }
        }
    }

    void CreateZigZagClones(int tour)
    {
        for (int i = 0; i < tour ; i++)
        {
            MakeCloneToRightAngle();
            MakeCloneToLeftAngle();

        }   
    }

    void CreateLetterP()
    {
        for (int i = 0; i < 4; i++)
        {
            clonePosition += new Vector3(0, 0, 1f);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(+1, 0, 0);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for(int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(0, 0, -1);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 1; i++)
        {
            clonePosition += new Vector3(-1, 0, 0);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
    }

    void CreateLetterI()
    {
        clonePosition += new Vector3(+4, 0, 8);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        for (int i = 0; i < 4; i++)
        {
            clonePosition += new Vector3(0, 0, 1);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
    }

    void CreateLetterC()
    {
        clonePosition += new Vector3(-3, 0, 4);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        for (int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(-1, 0, 0);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 4; i++)
        {
            clonePosition += new Vector3(0, 0, 1);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(1, 0, 0);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
    }

    void CreateLetterK()
    {
        clonePosition += new Vector3(1, 0, 8);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        for (int i = 0; i < 4; i++)
        {
            clonePosition += new Vector3(0, 0, 1);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        clonePosition += new Vector3(3, 0, 0);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        clonePosition += new Vector3(-1, 0, -1);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        clonePosition += new Vector3(-1, 0, -1);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        clonePosition += new Vector3(1, 0, -1);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        clonePosition += new Vector3(1, 0, -1);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);

    }

    void CreateLetterE()
    {
        clonePosition += new Vector3(-4, 0, 10);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        for (int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(-1, 0, 0);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 4; i++)
        {
            clonePosition += new Vector3(0, 0, 1);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(1, 0, 0);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        clonePosition += new Vector3(0, 0, -2);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        clonePosition += new Vector3(-1, 0, 0);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);

    }

    void CreateLetterR()
    {
        clonePosition += new Vector3(2, 0, 12);
        Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        for (int i = 0; i < 4; i++)
        {
            clonePosition += new Vector3(0, 0, 1);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 3; i++)
        {
            clonePosition += new Vector3(1, 0, 0);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(0, 0, -1);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(-1, 0, 0);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
        for (int i = 0; i < 2; i++)
        {
            clonePosition += new Vector3(1, 0, -1);
            Instantiate(cloneSphere, clonePosition, Quaternion.identity);
        }
     
    }
    void CreatePicker()
    {
        CreateLetterP();
        CreateLetterI();
        CreateLetterC();
        CreateLetterK();
        CreateLetterE();
        CreateLetterR();
    }

    void CreateShapeOnPlane()
    {
        int rnd = Random.Range(0, 3);
        if (rnd == 1)
        {
            CreateZigZagClones(3);
        }
        else if (rnd == 2)
        {
            CreatePicker();
        }
        else if (rnd == 0)
        {
            MakeCloneSquare();
        }
    }
    

    
}
