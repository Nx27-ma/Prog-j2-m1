using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    private GameObject canvasGameObject;
    private Text text;
    float currentTimeLeft;
    bool finished = false;
    GameObject playerObject;
    private Camera _camera;
    Rigidbody playerRigidBody;
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        text =  gameObject.GetComponentInChildren<Text>();
        playerRigidBody = playerObject.GetComponent<Rigidbody>();
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimeLeft -= Time.deltaTime;
        text.text = currentTimeLeft.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidBody.transform.position = Vector3.MoveTowards(gameObject.transform.position, Vector3.forward, Time.deltaTime * 10f);
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            startRun();
        }

        if (finished)
        {
            
        }

        if (currentTimeLeft < 0 && !finished)
        {
            lostGame();
        }
    }

    void startRun()
    {
        currentTimeLeft = 5;
        SceneManager.LoadScene("Running");
    }

    void lostGame()
    {
        
    }

    void wonGame()
    {
        
    }
}