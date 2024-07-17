using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeController : MonoBehaviour
{

    public GameObject objectToSpawn,square, triangle, circle,diamond;
    public int spawnTimer = 30;
    public int shapePick,score,TwoShapes;
    public int spawning = 30;
    public int speedUp = 200;
    public bool Double;

    public int timer, frameCount;

    public ShapeMovement shape;
    public TextMesh Score;
    public GameManager game;

    Vector3 Circle, Triangle, Square,Diamond;
    void Start()
    {
        Application.targetFrameRate = 60;
        timer = 2;
        Double = false;

        game = GameObject.Find("GameManager").GetComponent<GameManager>();
        Circle = new Vector3(4.23f, 6.5f, 0);
        Triangle = new Vector3(-1.43f, 6.5f, 0);
        Square = new Vector3(-4.23f, 6.5f, 0);
        Diamond = new Vector3(1.43f, 6.5f, 0);
    }

    public void Shapes()
    {
        shapePick = Random.Range(1, 5);
        switch (shapePick)
        {
            case 1:
                objectToSpawn = square;
                break;
            case 2:
                objectToSpawn = triangle;
                break;
            case 3:
                objectToSpawn = circle;
                break;
            case 4:
                objectToSpawn = diamond;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (game.state == "play")
        {
            Score.text = " " + score.ToString();
            spawnTimer--;
            speedUp--;
            TwoShapes = Random.Range(1,3);

            if (spawnTimer <= 0)
            {
                if (TwoShapes == 1)
                {
                    Shapes();
                    if (objectToSpawn == square) Instantiate(objectToSpawn, Square, Quaternion.identity);
                    if (objectToSpawn == circle) Instantiate(objectToSpawn, Circle, Quaternion.identity);
                    if (objectToSpawn == triangle) Instantiate(objectToSpawn, Triangle, Quaternion.identity);
                    if (objectToSpawn == diamond) Instantiate(objectToSpawn, Diamond, Quaternion.identity);
                }
                if (TwoShapes == 2 && Double == false)
                {
                    Shapes();
                    if (objectToSpawn == square) Instantiate(objectToSpawn, Square, Quaternion.identity);
                    if (objectToSpawn == circle) Instantiate(objectToSpawn, Circle, Quaternion.identity);
                    if (objectToSpawn == triangle) Instantiate(objectToSpawn, Triangle, Quaternion.identity);
                    if (objectToSpawn == diamond) Instantiate(objectToSpawn, Diamond, Quaternion.identity);
                    Shapes();
                    if (objectToSpawn == square) Instantiate(objectToSpawn, Square, Quaternion.identity);
                    if (objectToSpawn == circle) Instantiate(objectToSpawn, Circle, Quaternion.identity);
                    if (objectToSpawn == triangle) Instantiate(objectToSpawn, Triangle, Quaternion.identity);
                    if (objectToSpawn == diamond) Instantiate(objectToSpawn, Diamond, Quaternion.identity);
                    if (timer >= 0)
                    {
                        frameCount -= 1;
                        if (frameCount <= 0)
                        {
                            timer -= 1;
                            frameCount = 60;
                        }
                    }
                    if (timer < 0)
                    {
                        timer = 2;
                        Double = true;
                    }
                    if (Double == true && TwoShapes == 2) TwoShapes = 1;
                }
                spawnTimer = spawning;
                if (speedUp <= 0)
                {
                    spawning = spawnTimer - 1;
                    speedUp = 200; 
                }
            }
        }
    } 
    
}
