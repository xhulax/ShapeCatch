using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int timer, frameCount, shapePick,SpeedChoice;
    public int timer2, frameCount2;
    bool timerStart;
    public string state;
    public TextMesh Timer, Counter;
    public Camera camera;
    public ShapeController controller;
   // GameObject SClone,TClone,CClone;

    

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        timer = 12;
        timer2 = 3;
        state = "title";
        controller = GameObject.Find("ShapeSpawning").GetComponent<ShapeController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (state == "title")
        {
            camera.transform.position = new Vector3(22f,0, -10f);
            if (state == "title" && Input.GetKey(KeyCode.Space)) state = "countDown";
        }
        if (state == "countDown")
        {
            camera.transform.position = new Vector3(0, 0, -10);
            Counter.transform.position = new Vector3(0, 0, -5);
            if (timer2 >= 0)
            {
                frameCount2 -= 1;
                if (frameCount2 <= 0)
                {
                    Counter.text = timer2.ToString();
                    timer2 -= 1;
                    frameCount2 = 60;
                }
            }
            if (timer2 < 0)
            {
                timerStart = true;
                timer2 = 0;
                Counter.transform.position = new Vector3(40, 0);
                state = "play";
            }

        }
        if (timerStart == true)
        {
            if (timer >= 0)
            {
                frameCount -= 1;
                if (frameCount <= 0)
                {
                    Timer.text = "Time: " + timer;
                    timer -= 1;
                    frameCount = 60;
                }

            }
        }
        if (timer <= 0)
        {
            state = "gameover";
            timerStart = false;
        }

        if (state == "gameover" && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}
