using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChange : MonoBehaviour
{
    public GameObject square, triangle, circle,diamond;
    SpriteRenderer Square, Triangle, Circle, Diamond, Announcing;
    Color32 SColour, TColour, CColour, DColour, AnnounceColour;
    Transform OkPosition, GoodPosition, PerfectPosition;

    public TextMesh announcer, scoreAnnoune;
    public string Announce;
    float speed;

   //public TextMesh Score;

    public GameManager Game;
    public ShapeController shape;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        Square = square.GetComponent<SpriteRenderer>();
        SColour = square.GetComponent<SpriteRenderer>().color;

        Triangle = triangle.GetComponent<SpriteRenderer>();
        TColour = triangle.GetComponent<SpriteRenderer>().color;

        Circle = circle.GetComponent<SpriteRenderer>();
        CColour = circle.GetComponent<SpriteRenderer>().color;

        Diamond = diamond.GetComponent<SpriteRenderer>();
        DColour = diamond.GetComponent<SpriteRenderer>().color;
        //Default();
    }

    // Update is called once per frame
    void Update()
    {
        if (Game.state == "countDown")
        {
            scoreAnnoune.text = " ";
            announcer.text = " ";
        }
        if (Game.state == "play")
        {
            scoreAnnoune.text = " ";
            announcer.text = " ";

            SColour.r = 255;
            SColour.g = 255;
            SColour.b = 255;
            SColour.a = 125;
            square.GetComponent<SpriteRenderer>().color = SColour;

            TColour.r = 255;
            TColour.g = 255;
            TColour.b = 255;
            TColour.a = 125;
            triangle.GetComponent<SpriteRenderer>().color = TColour;

            CColour.r = 255;
            CColour.g = 255;
            CColour.b = 255;
            CColour.a = 125;
            circle.GetComponent<SpriteRenderer>().color = CColour;

            DColour.r = 255;
            DColour.g = 255;
            DColour.b = 255;
            DColour.a = 125;
            diamond.GetComponent<SpriteRenderer>().color = DColour;

            if (Announce == "ok")
            {
                announcer.color = Color.yellow;
                announcer.text = Announce;
                Debug.Log("yellow");
            }
            if (Announce == "good")
            {
                announcer.color = Color.green;
                announcer.text = Announce;
                Debug.Log("green");

            }
            if (Announce == "perfect")
            {
                announcer.color = Color.cyan;
                announcer.text = Announce;
                Debug.Log("cyan");
            }
            if (Announce == "miss")
            {
                announcer.color = Color.red;
                announcer.text = Announce;
                Debug.Log("red");
            }


            if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.A))
            {
                SColour.r = 118;
                SColour.g = 117;
                SColour.b = 117;
                square.GetComponent<SpriteRenderer>().color = SColour;

            }

            if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.W))
            {
                TColour.r = 118;
                TColour.g = 117;
                TColour.b = 117;
                triangle.GetComponent<SpriteRenderer>().color = TColour;

            }

            if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.D))
            {
                CColour.r = 118;
                CColour.g = 117;
                CColour.b = 117;
                circle.GetComponent<SpriteRenderer>().color = CColour;

            }

            if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.S))
            {
                DColour.r = 118;
                DColour.g = 117;
                DColour.b = 117;
                diamond.GetComponent<SpriteRenderer>().color = DColour;
            }
        }
        if (Game.state == "gameover")
        {
            announcer.text = " ";
            scoreAnnoune.text = "You scored: " + shape.score + " points.\n Good Job :)\n Press space to restart";
        }
    }
}
