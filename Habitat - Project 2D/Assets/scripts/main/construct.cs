using UnityEngine;
using System.Collections.Generic;
namespace MainFunctions
{
    public class construct
    {
        public void attackFalse()
        {

        }
        public void attackTrue(bool test)
        {

        }
    }
    public class attackManager
    {
        public void hpChange(GameObject Object,int value,valueChangeType changeType)
        {

            switch(changeType)
            {                
                case valueChangeType.decrease:
                    value *= -1;
                    break;
                default:
                    break;
            }
            Object.GetComponent<hp>().HP += value;
            if (Object.GetComponent<hp>().HP<=0)
            {
                Object.GetComponent<hp>().isAlive=false;
            }
        }
    
        //public void applyStun(Transform playerPosition)
        //{
        //    Collider2D[] collidersInRange;
        //    List<Collider2D> enemies=null;
        //    collidersInRange = Physics2D.OverlapCircleAll(playerPosition.position+new Vector3(2,0,0),4);

        //    foreach (var item in collidersInRange)
        //    {
        //        Debug.Log(item.name);
        //        if(item.tag=="enemy")
        //        {
        //            Debug.Log("ADD: " + item.name);
        //            enemies.Add(item);
        //        }
        //    }
        //    foreach (var item in enemies)
        //    {
        //        item.GetComponent<enemy>().Stun = true;
        //    }
        //}
    }
    public class spawnManager
    {
        public void spawnObject(GameObject objectToSpawn,Vector3 spawnPoint)
        {
            UnityEngine.MonoBehaviour.Instantiate(objectToSpawn, spawnPoint, Quaternion.identity);
        }
        public void randomSpawn(GameObject[] objectArray,Transform[] spawnPointArray)
        {
            MonoBehaviour.Instantiate(objectArray[Random.Range(0, objectArray.Length)], spawnPointArray[Random.Range(0, spawnPointArray.Length)].position, Quaternion.identity);
        }


    }

    public class Force
    {
        public void addForce(GameObject Object,float ForceValue,Vector3 forceDirection)
        {
            try
            {
                Object.GetComponent<Rigidbody2D>().AddForce(forceDirection * ForceValue, ForceMode2D.Impulse);
            }
            catch
            {
                Debug.Log("No Rigidbody2D in this "+Object.name);
            }
            
        }
    }
    public enum valueChangeType
    {
        increase,
        decrease,
    }

    
}