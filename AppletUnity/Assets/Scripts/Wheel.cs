using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wheel : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;
    private bool coroutineAllowed;
    private int finalAngle;

    public GameObject panel;

    [SerializeField]
    private Text winText;
    // Start is called before the first frame update
    void Start()
    {
        coroutineAllowed = true;
        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Spin(){
        coroutineAllowed = false;
        randomValue = Random.Range(20,30);
        timeInterval = 0.1f;

        for(int i = 0; i < randomValue; i++){
            transform.Rotate(0,0,22.5f);
            if(i > Mathf.RoundToInt(randomValue * 0.5f)){

            }
            if(i > Mathf.RoundToInt(randomValue * 0.85f)){

            }
            yield return new WaitForSeconds(timeInterval);
        }

        if (Mathf.RoundToInt(transform.eulerAngles.z) %45 != 0){
            transform.Rotate(0,0,22.5f);
        }
        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

        switch(finalAngle){
            case 0:
                winText.text = "ACTIVITY 1";
                panel.gameObject.SetActive(true);
                break;
            case 45:
                winText.text = "ACTIVITY 2";
                panel.gameObject.SetActive(true);
                break;
            case 90:
                winText.text = "ACTIVITY 3";
                panel.gameObject.SetActive(true);
                break;
            case 135:
                winText.text = "ACTIVITY 4";
                panel.gameObject.SetActive(true);
                break;
            case 180:
                winText.text = "ACTIVITY 5";
                panel.gameObject.SetActive(true);
                break;
            case 225:
                winText.text = "ACTIVITY 6";
                panel.gameObject.SetActive(true);
                break;
            case 270:
                winText.text = "ACTIVITY 7";
                panel.gameObject.SetActive(true);
                break;
            case 315:
                winText.text = "ACTIVITY 8";
                panel.gameObject.SetActive(true);
                break;
        }
        coroutineAllowed = true;
    }

    public void spin(){
        StartCoroutine(Spin());
    }

    public void closePanel(){
        panel.gameObject.SetActive(false);
    }
}
