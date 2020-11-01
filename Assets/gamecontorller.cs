using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamecontorller : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Random.Range(0, 20) == 4)
        {
            int which = Random.Range(0, 3);
            if (GameObject.Find("enemy" + (1 + which) + "(Clone)"))
            {

            }
            else
            {
                Instantiate(prefabs[which]);
            }
        }

        if (GameObject.Find("enemy1(Clone)") && GameObject.Find("enemy2(Clone)") && GameObject.Find("enemy3(Clone)"))
        {
            SceneManager.LoadScene("Lose");
        }
    }
}