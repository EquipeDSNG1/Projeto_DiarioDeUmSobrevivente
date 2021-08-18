using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    public Animator anim;
    public float speed;

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("horizontal", movement.x);
        anim.SetFloat("vertical", movement.y);
        anim.SetFloat("velocidade", movement.magnitude);

        if(movement != Vector3.zero)
        {
            anim.SetFloat("horizontalidle", movement.x);
            anim.SetFloat("verticalidle", movement.y);
        }
        transform.position = transform.position + movement * speed * Time.deltaTime;
    }
}
