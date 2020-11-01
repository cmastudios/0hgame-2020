using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public Text scoreUI;
    public Transform attackZone;

    private int bonks;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        bonks = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector2.left * 1000f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector2.right * 1000f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Collider2D[] hits = Physics2D.OverlapCircleAll(attackZone.position, 0.7f);
            foreach (Collider2D hit in hits)
            {
                if (hit.GetComponent<fetus>())
                {
                    Destroy(hit.gameObject);
                    Bonk();
                }
            }
        }
    }


    void Bonk()
    {
        bonks++;
        scoreUI.text = "Convicts bonked: " + bonks;
    }
}
