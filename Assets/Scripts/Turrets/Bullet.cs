using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;

    public int damage = 5;

    public float chilliRadius = 0f;
    public float plumRadius = 0f;
    public GameObject impacteffect;
    public GameObject spicy;
    public void Seek (Transform _target)
    {
        target = _target;
    }
	
	void Update ()
    {
		if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);

	}

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impacteffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);

        if (chilliRadius > 0f)
        {
            Explode();
        }
        if(plumRadius > 0f)
        {
            Splatter();
        }
        else
        {
            Damage(target);
            AlternateDamage(target);
        }

        Destroy(gameObject);
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, chilliRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Instantiate(spicy, this.transform.position, Quaternion.identity);
                Damage(collider.transform);

                Instantiate(spicy, this.transform.position, Quaternion.identity);
                AlternateDamage(collider.transform);

            }
        }
    }

    void Splatter()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, plumRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);

                AlternateDamage(collider.transform);
            }
        }
    }

    void Damage (Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }
    }

    void AlternateDamage(Transform alternateEnemy)
    {
        AlternateEnemy ae = alternateEnemy.GetComponent<AlternateEnemy>();

        if (ae != null)
        {
            ae.TakeDamage(damage);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chilliRadius);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, plumRadius);
    }

}
