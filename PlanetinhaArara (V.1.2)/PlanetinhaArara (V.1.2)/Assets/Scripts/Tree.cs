using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    
GameObject thisTree;
private bool isFallen = false;

void Start()
{
thisTree = transform.parent.gameObject;
}

void Update()
{
   if (isFallen == false)
    {
       StartCoroutine(fallTree());
       Rigidbody rb = thisTree.AddComponent<Rigidbody>(); //acho q tem que colocar um rigidbody lá no inspector (se der erro, coloca; se não, não coloca)
       rb.isKinematic = false;
       rb.useGravity = true;
       rb.AddForce(Vector3.forward, ForceMode.Impulse);
       isFallen = true;
    }
}

IEnumerator fallTree()
{
   yield return new WaitForSeconds(5);
}
IEnumerator fallAgain()
{
   yield return new WaitForSeconds(5);
}

}


