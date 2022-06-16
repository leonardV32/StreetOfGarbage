using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject player;
    private Transform playertransform;


    // Start is called before the first frame update
    void Start()
    {
        playertransform = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMoveLeft(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            //return;
            if (playertransform.position.x <= -4)
            {
                return;
            }
            Debug.Log(obj);
            playertransform.position += new Vector3(-4, 0, 0);
        }
        Debug.Log(playertransform.position);

    }
    public void OnMoveRight(InputAction.CallbackContext obj)
    {   if (obj.performed)
        {

            if (playertransform.position.x >= 4)
            {
                return;
            }
            Debug.Log(obj);
            playertransform.position += new Vector3(4, 0, 0);
        }
        Debug.Log(playertransform.position);
    }

    public void OnThrow(InputAction.CallbackContext obj)
    {
        Debug.Log("rgshyyy");
    }


}
