using UnityEngine;

public class Bossbehaviour : MonoBehaviour
{
    Bossshoot bossshoot;
    public float timer;

	void Start ()
    {
        bossshoot = GetComponent<Bossshoot>();
        bossshoot.enabled = false;
    }
	
    void Update ()
    {

        timer += Time.deltaTime;

        if (timer > 4)
        {
            bossshoot.enabled = true;
        }

    }
	
}
