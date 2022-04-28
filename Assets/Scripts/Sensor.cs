using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Sensor : MonoBehaviour
{
    public GameObject sphere;
    public Vector3 spherePos;
    public virtual void Start()
    {
    }

    public virtual void Update()
    {
        this.sphere = GameObject.Find("Sphere");

        {
            float _13 = this.sphere.transform.position.y;
            Vector3 _14 = this.transform.position;
            _14.y = _13;
            this.transform.position = _14;
        }

        {
            float _15 = this.sphere.transform.position.x;
            Vector3 _16 = this.transform.position;
            _16.x = _15;
            this.transform.position = _16;
        }
    }

    public virtual void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
        }
        else
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
        if (col.gameObject.name == "Sphere")
        {
        }
        else
        {
            PlayerPrefs.SetFloat("isFalling", 2);
        }
    }

}