using System.Collections.Generic;
using UnityEngine;

public class EnemyWave : MonoBehaviour
{
    List<GameObject> enemies;
    float timeleft = 1;
    void Start()
    {
        enemies = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                enemies.Add(GameObject.CreatePrimitive(PrimitiveType.Cube));
                enemies[i].AddComponent<Rigidbody>();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (GameObject i in enemies)
            {

                Destroy(i.gameObject);
                
            }
                enemies.Clear();
        }
        else
        {

            timeleft -= Time.deltaTime;

            if (timeleft < 0)
            {
                GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Cube);
                temp.AddComponent<Rigidbody>();
                enemies.Add(temp);
                timeleft = 1;
            }
        }
    }
}
