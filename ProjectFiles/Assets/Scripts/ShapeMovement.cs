using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public ShapeController shape;
    public ShapeChange colours;
    public GameManager game;
    public string state;
    SpriteRenderer ThisObject, Oksquare, Goodsquare, Perfsquare;
    SpriteRenderer Okcircle, Goodcircle, Perfcircle;
    SpriteRenderer Oktriangle, Goodtriangle, Perftriangle;
    SpriteRenderer Okdiamond, Gooddiamond, Perfdiamond;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        state = "move";
        shape = GameObject.Find("ShapeSpawning").GetComponent<ShapeController>();
        colours = GameObject.Find("Player").GetComponent<ShapeChange>();
        game = GameObject.Find("GameManager").GetComponent<GameManager>();

        ThisObject = this.GetComponent<SpriteRenderer>();
        Oksquare = GameObject.Find("OkSquare").GetComponent<SpriteRenderer>();
        Goodsquare = GameObject.Find("GoodSquare").GetComponent<SpriteRenderer>();
        Perfsquare = GameObject.Find("PerfSquare").GetComponent<SpriteRenderer>();

        Okcircle = GameObject.Find("OkCircle").GetComponent<SpriteRenderer>();
        Goodcircle = GameObject.Find("GoodCircle").GetComponent<SpriteRenderer>();
        Perfcircle = GameObject.Find("PerfCircle").GetComponent<SpriteRenderer>();

        Oktriangle = GameObject.Find("OkTriangle").GetComponent<SpriteRenderer>();
        Goodtriangle = GameObject.Find("GoodTriangle").GetComponent<SpriteRenderer>();
        Perftriangle = GameObject.Find("PerfTriangle").GetComponent<SpriteRenderer>();

        Okdiamond = GameObject.Find("OkDiamond").GetComponent<SpriteRenderer>();
        Gooddiamond = GameObject.Find("GoodDiamond").GetComponent<SpriteRenderer>();
        Perfdiamond = GameObject.Find("PerfDiamond").GetComponent<SpriteRenderer>();
    }

    private void OnDestroy()
    {
        colours.Announce = state;
        if (state == "ok") shape.score += 10;
        if (state == "good") shape.score += 20;
        if (state == "perfect") shape.score += 30;

    }
    void Update()
    {
        if (game.state == "play")
        {
            this.transform.position -= new Vector3(0, speed, 0);

            //square collisions
            if ((Input.GetKeyDown(KeyCode.LeftArrow) ||Input.GetKeyDown(KeyCode.A)) && ThisObject.bounds.Intersects(Oksquare.bounds))
            {
                //shape.score += 10;
                state = "ok";
                Destroy(this.gameObject);
            }
            if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))  && ThisObject.bounds.Intersects(Goodsquare.bounds))
            {
                //shape.score += 20;
                state = "good";
                Destroy(this.gameObject);
            }
            if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))  && ThisObject.bounds.Intersects(Perfsquare.bounds))
            {
                //shape.score += 30;
                state = "perfect";
                Destroy(this.gameObject);
            }

            //triangle collisions
            if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))  && ThisObject.bounds.Intersects(Oktriangle.bounds))
            {
                //shape.score += 10;
                state = "ok";
                Destroy(this.gameObject);
            }
            if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))  && ThisObject.bounds.Intersects(Goodtriangle.bounds))
            {
                //shape.score += 20;
                state = "good";
                Destroy(this.gameObject);
            }
            if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && ThisObject.bounds.Intersects(Perftriangle.bounds))
            {
                //shape.score += 30;
                state = "perfect";
                Destroy(this.gameObject);
            }

            //cirlce collisions
            if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))  && ThisObject.bounds.Intersects(Okcircle.bounds))
            {
                //shape.score += 10;
                state = "ok";
                Destroy(this.gameObject);
            }
            if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))  && ThisObject.bounds.Intersects(Goodcircle.bounds))
            {
                //shape.score += 20;
                state = "good";
                Destroy(this.gameObject);
            }
            if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && ThisObject.bounds.Intersects(Perfcircle.bounds))
            {
                //shape.score += 30;
                state = "perfect";
                Destroy(this.gameObject);
            }

            //diamond collisions
            if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))  && ThisObject.bounds.Intersects(Okdiamond.bounds))
            {
                //shape.score += 10;
                state = "ok";
                Destroy(this.gameObject);
            }
            if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))  && ThisObject.bounds.Intersects(Gooddiamond.bounds))
            {
                //shape.score += 20;
                state = "good";
                Destroy(this.gameObject);
            }
            if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && ThisObject.bounds.Intersects(Perfdiamond.bounds))
            {
                //shape.score += 30;
                state = "perfect";
                Destroy(this.gameObject);
            }

            else if (this.transform.position.y <= -6)
            {
                state = "miss";
                Destroy(this.gameObject);
            }
        }
        if (game.state == "gameover") Destroy(this.gameObject);
    }
}

