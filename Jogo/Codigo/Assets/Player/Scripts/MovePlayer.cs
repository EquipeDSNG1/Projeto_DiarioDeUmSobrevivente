using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Animator anim;
    public float speed;
    public float run;
    private float dashDistance = 15;
    public float stamina;
    public float staminat;

    IEnumerator DelayDash(float waitTime) {
        speed = speed + dashDistance;
        yield return new WaitForSeconds(waitTime);
        speed = speed - dashDistance;
        stamina = stamina - staminat/5;
    }

    


    void Update()
    {
        Move();
        Run();
        dash();
    
    }

    void Move()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.magnitude);

        transform.position = transform.position + movement * speed * Time.deltaTime;
        
    }

    void Run()
    {
        if(Input.GetButtonDown("Run")){
            if(stamina>=0){
                speed = speed + run;
             GetComponent<AudioSource>().Play();
             stamina = stamina - staminat/25;
            }

        }
        if(Input.GetButtonUp("Run")){
            speed = speed - run;
            GetComponent<AudioSource>().Stop();
        }
    }

    void dash(){
        if(Input.GetButtonDown("Jump")){
            if(stamina>=0){
                StartCoroutine(DelayDash(0.2F));
            }
        }
    }

    
}
