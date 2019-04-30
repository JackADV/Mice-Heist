using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public interface IDamageable<T>
//{
//    void Damage(T DamageTaken);
//}

public class DamageOverTime : MonoBehaviour//, IDamageable<float>
{
    public float damage = 1.0f; // The amount of damage to be applied per second
    public bool ignoreCaster = true;
    public float delayBeforeCasting = 0.0f; // Timer before the ability is activated
    public float applyEveryNSeconds = 1.0f; // How many seconds the effect lasts for
    public int applyDamageNTimes = 1; // How many times the damage is meant to happen

    private bool delied = false;

    private int appliedTimes = 0;

    private bool test = false;

    private void OnTriggerStay(Collider other)
    {


        //IDamageable takeDamage = other.gameObject.GetComponent<IDamagable>();
        //if (takeDamage != null)
        //{
        //    StartCoroutine(CastDamage(takeDamage));
        //}

    }
    //IEnumerator CastDamage(IDamagable damageable)
    //{
    //    if (!test && appliedTimes <= applyDamageNTimes || !test && applyEveryNSeconds == 0)
    //    {
    //        test = true;
    //        if (!delied)
    //        {
    //            yield return new WaitForSeconds(delayBeforeCasting);
    //            delied = true;
    //        }
    //        else
    //        {
    //            yield return new WaitForSeconds(applyEveryNSeconds);
    //        }
    //        damageable.TakeDamage(damage);
    //        appliedTimes++;
    //        test = false;
    //    }
    //}

    //public void Damage(float DamageTaken)
    //{
    //    throw new System.NotImplementedException();
    //}
}
