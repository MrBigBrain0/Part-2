using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;

public class AxeSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void FixedUpdate()
    {
        //spins the axe
        //this isnt the code that does this but if the player gets under the axe the axe will spin around the player
        //this was indended
        transform.Rotate(0, 0, 5);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
