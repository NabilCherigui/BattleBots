using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
    
    private void OnTriggerStay(Collider node)
    {
        if (node.CompareTag(tag))
        {
            if (node.transform.position.x > transform.position.x - (node.transform.localScale.x * 0.5) &&
                node.transform.position.x < transform.position.x - (node.transform.localScale.x * 0.3))
            {
                print("Okay");
            }
            else if (node.transform.position.x > transform.position.x - (node.transform.localScale.x * 0.3) &&
                     node.transform.position.x < transform.position.x - (node.transform.localScale.x * 0.1))
            {
                print("Great");
            }
            else if (node.transform.position.x > transform.position.x - (node.transform.localScale.x * 0.1) &&
                     node.transform.position.x < transform.position.x - (node.transform.localScale.x * -0.1))
            {
                print("Perfect");
            }
            else
            {
                print("Bad");   
            }
        }
    }
}
