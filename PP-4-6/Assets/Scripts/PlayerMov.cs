using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMov : MonoBehaviour
{
    public int vida = 3;
    private Rigidbody2D rb2d;
    public float velocidad = 5;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Caminar();
    }
    void Caminar()
    {
        var Movimiento_X = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(Movimiento_X * velocidad, 0);
    }
    public void PerderVida()
    {
        vida--;
        Debug.Log("Vidas restantes: " + vida);

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
