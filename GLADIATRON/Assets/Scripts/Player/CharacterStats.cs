using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    
    public Stat damage;
    public Stat armor;

    void Awake()
    {
        
    }

    void Update()
    {
      
    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        
       // Debug.Log(transform.name + "takes" + damage + "damage");
        
       
    }

    public virtual void Die()
    {
        Debug.Log(transform.name + "died.");
    }
}
