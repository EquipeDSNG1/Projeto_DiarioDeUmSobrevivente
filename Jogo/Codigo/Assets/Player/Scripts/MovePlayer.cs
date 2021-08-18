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
        stamina = stamina - staminat/3;
    }

    void Update()
    {
        Move();
        Run();
        dash();
        recuperarstamina();
    }

    void Move()
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

    void Run()
    {
        if(Input.GetButtonDown("Run")){
            if(stamina>=0){
                speed = speed + run;
            }

        }
        if(Input.GetButtonUp("Run")){
            speed = speed - run;
        }
    }

    void dash(){
        if(Input.GetButtonDown("Jump")){
            if(stamina>=0){
                StartCoroutine(DelayDash(0.2F));
            }
        }
    }    


    void recuperarstamina(){
        try{
            StartCoroutine(Recuperando(2.0F));
                
            }
        finally{
            if(stamina>staminat){
                stamina = staminat;
            }
        }
        
        }
    

    IEnumerator Recuperando(float espera) {
        if(stamina < staminat){
          yield return new WaitForSeconds(espera);
            stamina = stamina + staminat/10;  
        }
    }

}
