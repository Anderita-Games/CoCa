using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class RBallControl : MonoBehaviour
{
    public int jumpHeight;
    public AudioClip Jump;
    private bool isFalling;
    public float gravity;
    public GameObject R;
    public GameObject L;
    public object bruh;
    public object bruh2;
    public virtual void Start()
    {
        PlayerPrefs.SetFloat("Swing", -4f);
        PlayerPrefs.SetFloat("isFalling", 0);
    }

    public virtual void Update()
    {

        {
            float _7 = PlayerPrefs.GetFloat("Swing");
            Vector3 _8 = this.GetComponent<Rigidbody>().velocity;
            _8.x = _7;
            this.GetComponent<Rigidbody>().velocity = _8;
        }

        {
            float _9 = this.GetComponent<Rigidbody>().velocity.y - (this.gravity * Time.deltaTime);
            Vector3 _10 = this.GetComponent<Rigidbody>().velocity;
            _10.y = _9;
            this.GetComponent<Rigidbody>().velocity = _10;
        }
        Time.timeScale = PlayerPrefs.GetInt("paused");
        if ((Input.GetKey("up") || Input.GetMouseButtonDown(0)) && (PlayerPrefs.GetFloat("isFalling") > 0))
        {

            {
                int _11 = -5;
                Vector3 _12 = this.GetComponent<Rigidbody>().velocity;
                _12.y = _11;
                this.GetComponent<Rigidbody>().velocity = _12;
            }
            PlayerPrefs.SetFloat("isFalling", PlayerPrefs.GetFloat("isFalling") - 1);
        }
    }

    public virtual IEnumerator OnCollisionStay(Collision col)
    {
        if ((col.gameObject.name == "R") || (col.gameObject.name == "L"))
        {
        }
        else
        {
            PlayerPrefs.SetFloat("isFalling", 1);
        }
        this.bruh = this.GetComponent<Rigidbody>().position.x;
        if (this.bruh == this.bruh2)
        {
            if (PlayerPrefs.GetFloat("Swing") == 4f)
            {
                PlayerPrefs.SetFloat("Swing", -4f);
            }
            else
            {
                if (PlayerPrefs.GetFloat("Swing") == -4f)
                {
                    PlayerPrefs.SetFloat("Swing", 4f);
                }
            }
        }
        yield return new WaitForSeconds(0.01f);
        this.bruh2 = this.bruh;
    }

    public RBallControl()
    {
        this.jumpHeight = 10;
        this.gravity = -20f;
    }

}