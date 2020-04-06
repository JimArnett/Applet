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
            transform.Rotate(0,0,30f);
            if(i > Mathf.RoundToInt(randomValue * 0.6f)){

            }
            yield return new WaitForSeconds(timeInterval);
        }

        if (Mathf.RoundToInt(transform.eulerAngles.z) % 60 != 0){
            transform.Rotate(0,0,30f);
        }
        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);
        Debug.Log(finalAngle);
        switch(finalAngle){
            case 0:
                winText.text = "CREATE";
                panel.gameObject.SetActive(true);
                break;
            case 60:
                winText.text = "PRACTICE YOGA";
                panel.gameObject.SetActive(true);
                break;
            case 120:
                winText.text = "PLAY A GAME";
                panel.gameObject.SetActive(true);
                break;
            case 180:
                winText.text = "MEDITATE";
                panel.gameObject.SetActive(true);
                break;
            case 240:
                winText.text = "VIDEO CHAT";
                panel.gameObject.SetActive(true);
                break;
            case 300:
                winText.text = "GO OUTSIDE";
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
