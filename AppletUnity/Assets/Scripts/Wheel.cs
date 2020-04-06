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

    public Text Description;

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
                Description.text = "Flex your creativity and brain function by making something. This can be a craft, DIY home project, or a digital project… anything that boosts your imagination!";
                panel.gameObject.SetActive(true);
                break;
            case 60:
                winText.text = "PRACTICE YOGA";
                Description.text = "Get ready to breathe, meditate, and move your body! Practicing yoga is a great way to reduce stress, calm the mind, and work on one’s physical health through various poses, exercises, and so on. \n ";

                panel.gameObject.SetActive(true);
                break;
            case 120:
                winText.text = "PLAY A GAME";
                Description.text = "Game up! Escape the limits of being stuck at home, and explore a wide variety of games and online activities which provide a boundless world. ";
                panel.gameObject.SetActive(true);
                break;
            case 180:
                winText.text = "MEDITATE";
                Description.text = "Calm your mind and let the soul speak! Meditation will draw your focus inward, taking any worrisome thoughts away from the external circumstances in the world. ";
                panel.gameObject.SetActive(true);
                break;
            case 240:
                winText.text = "VIDEO CHAT";
                Description.text = "Connect with a loved one and spend time with them, virtually! Video chatting and having a conversation is a great way to kill time and catch up with someone while far apart.";
                panel.gameObject.SetActive(true);
                break;
            case 300:
                winText.text = "GO OUTSIDE";
                Description.text = "Get some fresh air and vitamin D by going outside. This can be in your backyard or nearby park, as long as you remain a distance of 6 feet apart in public!";
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
