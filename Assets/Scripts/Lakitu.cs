using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lakitu : MonoBehaviour
{
    public GameObject proyectil;

    private float maxTime = 5, currentTime = 0, speed = .2f;
    private Vector2 dir = Vector2.right;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        currentTime += Time.deltaTime;

        if(currentTime >= maxTime)
        {
            dir *= -1;
            currentTime = 0;
            animator.Play("SoltarProyectil");
        }
    }

    public void SoltarProyectil()
    {
        Instantiate(proyectil, transform.position, Quaternion.identity);
    }
}
