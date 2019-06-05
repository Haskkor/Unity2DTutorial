using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxHealth = 5;
    public int health
    {
        get { return currentHealth; }
    }
    private int currentHealth;
    Rigidbody2D rigidbody2d;
    
    // Start is called before the first frame update
    void Start()
    {
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        // Debug.Log(horizontal);
        Vector2 position = rigidbody2d.position;
        position.x += speed * horizontal * Time.deltaTime;
        position.y += speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
    }
}
