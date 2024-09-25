using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    public GameObject prefab;
    Camera camera = Camera.main;
    RaycastHit hit;
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.Raycast(ray, out hit);
            Vector3 posT = hit.point;
            GameObject T = Instantiate(prefab, posT, Quaternion.identity);
            int size = Random.Range(1, 3);
            T.transform.localScale = new Vector3(size, size, size);
        }
    }
}
