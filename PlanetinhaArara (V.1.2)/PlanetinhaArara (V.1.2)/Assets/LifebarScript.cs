using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifebarScript : MonoBehaviour
{
    public Animator animat;
    public int lifeNum;

    // Start is called before the first frame update
    void Start()
    {
        animat = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(AraraMovement.life == lifeNum){
            animat.Play("LosingLife");
        }
    }
}
