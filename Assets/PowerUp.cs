using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PlayerControl player;

    private Vector3 scaleAddition;

    // Start is called before the first frame update
    void Start()
    {
        scaleAddition = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            player.sizePowerUp(scaleAddition);
            Destroy(gameObject);
        }
    }
}
