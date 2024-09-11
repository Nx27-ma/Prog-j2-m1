using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballin : MonoBehaviour
{
    public GameObject ball;
    float elapsedTime = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color randomColor()
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color randColor = new Color(r, g, b, 1f);

            return randColor;     
        }

        elapsedTime += Time.deltaTime;

        if (elapsedTime > 1f)
        {
            CreateBall(randomColor());
            elapsedTime = 0f;
        }
    }

    private void CreateBall(Color c)
    {

        GameObject P_ball = Instantiate(ball, new Vector3(Random.Range(0f, 10f), Random.Range(0f, 10f), 0), new Quaternion(0,0,0,1));
        Material material = ball.GetComponent<MeshRenderer>().sharedMaterial;
        material.color = c;
        Destroy(P_ball, 1);
    }

}
