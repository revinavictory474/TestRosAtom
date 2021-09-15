using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ClientStart : MonoBehaviour
{
    [SerializeField] private Text textIP;
    [SerializeField] private Client client;
    [SerializeField] private Animator animator;
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
        }
    }
}
