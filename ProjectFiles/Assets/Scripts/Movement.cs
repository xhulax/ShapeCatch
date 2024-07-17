using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    SpriteRenderer squareSR;
    SpriteRenderer leftEarlySR, leftGoodSR, leftPerfectSR;
    SpriteRenderer MiddleEarlySR, MiddleGoodSR, MiddlePerfectSR;
    SpriteRenderer RightEarlySR, RightGoodSR, RightPerfectSR;

    void Start()
    {
        squareSR = this.GetComponent<SpriteRenderer>();
        leftEarlySR = GameObject.Find("OkSquare").GetComponent<SpriteRenderer>();
        leftGoodSR = GameObject.Find("GoodSquare").GetComponent<SpriteRenderer>();
        leftPerfectSR = GameObject.Find("PerfSquare").GetComponent<SpriteRenderer>();

        MiddleEarlySR = GameObject.Find("Middle EARLY").GetComponent<SpriteRenderer>();
        MiddleGoodSR = GameObject.Find("Middle GOOD").GetComponent<SpriteRenderer>();
        MiddlePerfectSR = GameObject.Find("Middle PERFECT").GetComponent<SpriteRenderer>();


        RightEarlySR = GameObject.Find("Right EARLY").GetComponent<SpriteRenderer>();
        RightGoodSR = GameObject.Find("Right GOOD").GetComponent<SpriteRenderer>();
        RightPerfectSR = GameObject.Find("Right PERFECT").GetComponent<SpriteRenderer>();

    }

    private void OnDestroy()
    {
        leftEarlySR.color = Color.white;
        leftGoodSR.color = Color.white;
        leftPerfectSR.color = Color.white;


        MiddleEarlySR.color = Color.white;
        MiddleGoodSR.color = Color.white;
        MiddlePerfectSR.color = Color.white;


        RightEarlySR.color = Color.white;
        RightGoodSR.color = Color.white;
        RightPerfectSR.color = Color.white;

    }

    void Update()
    {
        this.transform.position -= new Vector3(0, 0.1f);
        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(leftEarlySR.bounds))
        {
            leftEarlySR.color = Color.yellow;
            Debug.Log("EARLY");
        }
        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(leftGoodSR.bounds))
        {
            leftGoodSR.color = Color.green;
            Debug.Log("GOOD");
        }
        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(leftPerfectSR.bounds))
        {
            leftPerfectSR.color = Color.cyan;
            Debug.Log("PERFECT");
        }




        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(MiddleEarlySR.bounds))
        {
            MiddleEarlySR.color = Color.yellow;
            Debug.Log("EARLY");
        }
        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(MiddleGoodSR.bounds))
        {
            MiddleGoodSR.color = Color.green;
            Debug.Log("GOOD");
        }
        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(MiddlePerfectSR.bounds))
        {
            MiddlePerfectSR.color = Color.cyan;
            Debug.Log("PERFECT");
        }



        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(RightEarlySR.bounds))
        {
            RightEarlySR.color = Color.yellow;
            Debug.Log("EARLY");
        }
        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(RightGoodSR.bounds))
        {
            RightGoodSR.color = Color.green;
            Debug.Log("GOOD");
        }
        if (/*Input.GetKey(KeyCode.Space) && */squareSR.bounds.Intersects(RightPerfectSR.bounds))
        {
            RightPerfectSR.color = Color.cyan;
            Debug.Log("PERFECT");
        }


        if (this.transform.position.y <= -5.5) Destroy(this.gameObject);
    }
}
