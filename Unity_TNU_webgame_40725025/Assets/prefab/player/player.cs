using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed;

    private Animator player_ani;

    private SpriteRenderer player_spriteren;
    // Start is called before the first frame update
    void Start()
    {
        player_ani = GetComponent<Animator>();
        player_spriteren = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
        if(horizontalInput != 0 || verticalInput != 0)
        {
            player_ani.SetBool("is_walking", true);
        }
        else
        {
            player_ani.SetBool("is_walking", false);
        }
        if (horizontalInput < 0)
        {
            player_spriteren.flipX = true;
        }
        else if (horizontalInput > 0)
        {
            player_spriteren.flipX = false;
        }

    }
}
