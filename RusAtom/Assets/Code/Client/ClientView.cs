using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ClientView : MonoBehaviour
{
    public Text textIP;
    public Client client;
    public Animator animator;
    private bool isConnected = false;

   

    private void Update()
    {
        if(!isConnected && textIP.text.Length==15)
        {
            isConnected = true;

            client = new Client();

            client.address = textIP.text;
            Thread thread = new Thread(new ThreadStart(client.StartConnection));
            thread.Start();
        }

        if (!animator.GetBool("isAnimated") && client.message == "Start")
        {
            animator.SetBool("isAnimated", true);
            //client.message = "";
        }

    }
}
