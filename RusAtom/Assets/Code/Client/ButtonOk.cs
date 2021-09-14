using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOk : MonoBehaviour
{
    public Client client;
    public Animator animator;

    [SerializeField] private Text textIP;

    private void Awake()
    {
        client = new Client();
    }

    public void OnMouseDown()
    {
        client.StartConnection();    
    }

    private void Update()
    {
        client.address = textIP.text;

        if (client.message == "Start")
        {
            animator.SetBool("isAnimated", true);
        }
    }
}
