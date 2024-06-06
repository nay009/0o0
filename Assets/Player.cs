using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerController : MonoBehaviour
{

    public float movdSpeed = 10;
    public float jumpForce = 10;
    public int playerHp = 1;
    public GameObject gameoverPanel;

    Rigidbody2D rg;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rg = GetComponent<Rigidbody2D>();
        gameoverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        rg.velocity = new Vector2(x * movdSpeed, rg.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.velocity = new Vector2(rg.velocity.x, jumpForce);
        }
        if (playerHp <= 0)
        {
            Time.timeScale = 0;
            gameoverPanel.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            playerHp--;
        }
    }
}