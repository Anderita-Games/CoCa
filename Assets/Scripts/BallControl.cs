using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class BallControl : MonoBehaviour
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
            float _1 = PlayerPrefs.GetFloat("Swing");
            Vector3 _2 = this.GetComponent<Rigidbody>().velocity;
            _2.x = _1;
            this.GetComponent<Rigidbody>().velocity = _2;
        }

        {
            float _3 = this.GetComponent<Rigidbody>().velocity.y - (this.gravity * Time.deltaTime);
            Vector3 _4 = this.GetComponent<Rigidbody>().velocity;
            _4.y = _3;
            this.GetComponent<Rigidbody>().velocity = _4;
        }
        Time.timeScale = PlayerPrefs.GetInt("paused");
        if ((Input.GetKey("up") || Input.GetMouseButtonDown(0)) && (PlayerPrefs.GetFloat("isFalling") > 0))
        {

            {
                int _5 = 8;
                Vector3 _6 = this.GetComponent<Rigidbody>().velocity;
                _6.y = _5;
                this.GetComponent<Rigidbody>().velocity = _6;
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

    public BallControl()
    {
        this.jumpHeight = 10;
        this.gravity = -20f;
    }

}