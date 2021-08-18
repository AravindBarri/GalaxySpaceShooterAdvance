using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float enemySpeed; //enemy speed
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //move down 
        transform.Translate(Vector3.down * Time.deltaTime * enemySpeed);
        //when the enemy off the screen on the bottom he needs to respawn with new random x position
        if (this.transform.position.y < -6.0f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Laser")
        {
            if (collision.transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            anim.SetTrigger("Explode");
            Invoke("destroyEnemy", 2);
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Player")
        {
            //need to damage player
            Player player = collision.GetComponent<Player>();
            if (player != null)
            {
                player.Damage();
            }
        }

        //this.gameObject.SetActive(false);
    }
    void destroyEnemy()
    {
        Destroy(this.gameObject);
    }
}
