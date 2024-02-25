using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerSpin : MonoBehaviour
{
    //end position for the dagger
    private Vector3 endPos = new Vector3(-8, 3, 0);
    //axes current posistion
    private Vector3 startPos;
    private float distance = 3;
    private float time;
    //setting up animation curve
    public AnimationCurve curve;


    // Start is called before the first frame update
    void Start()
    {
        //stating the axes current posistion
        startPos = transform.position;
    }
    private void FixedUpdate()
    {
        //spins the dagger
        transform.Rotate(0, 0, 10);
    }
    // Update is called once per frame
    void Update()
    {
        //this is the set up so that the movemnt stays the same throught the movement
        time += Time.deltaTime;
        float completed = time / distance;

        //the lerp  that sends the dagger to the desired location 
        transform.position = Vector3.Lerp(startPos, endPos, curve.Evaluate(completed));

    }
}
