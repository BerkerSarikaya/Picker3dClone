using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Movement : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public GameObject destroyCube;
    public GameObject destroyCubeTwo;
    public GameObject destroyCubeThree;
    public TextMeshPro score;
    public float speed;
    bool controlMove;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        speed = 13f;
        controlMove = true;
    }

    void Update()
    {

        ControlMovement();
    }

    void ControlMovement()
    {
        if (controlMove == true)
        {
            MoveToObject();
        }
        else
        {
            
            myRigidbody.velocity = new Vector3(0f, 0f, 0f);
        }
    }

    void MoveToObject()
    {
        myRigidbody.velocity = new Vector3(0f, 0f, speed);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -3)
            {
                transform.position += new Vector3(-0.07f, 0f, 0.07f);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 3)
            {
                transform.position += new Vector3(0.07f, 0f, 0.07f);
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ColliderToStop")
        {
            controlMove = false;
            StartCoroutine(CounterCoroutine());


        }
        if (collision.gameObject.name == "ColliderToStopForTwo")
        {
            controlMove = false;
            StartCoroutine(CounterCoroutineTwo());


        }
        if (collision.gameObject.name == "ColliderToStopforThree")
        {
            controlMove = false;
            StartCoroutine(CounterCoroutineThree());

        }
    }

    IEnumerator CounterCoroutine()
    {

        yield return new WaitForSeconds(5);
        destroyCube.SetActive(false);
        controlMove = true;

    }
    IEnumerator CounterCoroutineTwo()
    {

        yield return new WaitForSeconds(5);
        destroyCubeTwo.SetActive(false);
        controlMove = true;

    }
    IEnumerator CounterCoroutineThree()
    {

        yield return new WaitForSeconds(5);
        destroyCubeThree.SetActive(false);
        controlMove = true;

    }
    
}