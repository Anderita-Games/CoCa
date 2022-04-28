using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Leveler : MonoBehaviour
{
    public GameObject Reverse1;
    public virtual void Start()
    {
        if (PlayerPrefs.GetInt("DoneLevel5") == 0)
        {
            this.Reverse1.SetActive(false);
        }
    }

    public virtual void Update()
    {
    }

}