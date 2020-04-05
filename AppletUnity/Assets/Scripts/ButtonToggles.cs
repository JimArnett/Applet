using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToggles : MonoBehaviour
{
    public GameObject toggleObjectOne;
    public GameObject toggleObjectTwo;
    public GameObject toggleObjectThree;
    public GameObject toggleObjectFour;
    public GameObject toggleObjectFive;
    public GameObject toggleObjectSix;

    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            for (int i = 0; i < objects.Length; i++) {
                if (objects[i].activeInHierarchy) {
                    objects[i].SetActive(false);
                    break; 
                }
            }
        }
    }
    public void CloseWindowOne(){
        toggleObjectOne.SetActive(false);
    }

    public void ToggleOne(){
        toggleObjectOne.SetActive(true);
    }

    public void CloseWindowTwo(){
        toggleObjectTwo.SetActive(false);
    }

    public void ToggleTwo(){
        toggleObjectTwo.SetActive(true);
    }

    public void CloseWindowThree(){
        toggleObjectThree.SetActive(false);
    }

    public void ToggleThree(){
        toggleObjectThree.SetActive(true);
    }

    public void CloseWindowFour(){
        toggleObjectFour.SetActive(false);
    }

    public void ToggleFour(){
        toggleObjectFour.SetActive(true);
    }

    public void CloseWindowFive(){
        toggleObjectFive.SetActive(false);
    }

    public void ToggleFive(){
        toggleObjectFive.SetActive(true);
    }

    public void CloseWindowSix(){
        toggleObjectSix.SetActive(false);
    }

    public void ToggleSix(){
        toggleObjectSix.SetActive(true);
    }
}
