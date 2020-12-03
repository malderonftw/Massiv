using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class Extensions
{
    public static void Shuffle<T>(this IList<T> ts)
    {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i)
        {
            var r = Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}

public class Massiv : MonoBehaviour
{
    public GameObject Go1;
    public GameObject Go2;
    public GameObject Go3;
    public GameObject Go4;
    public GameObject Go5;
    public GameObject Go6;
   

    


    private void MethodForTwoArrays(GameObject[] goarray1, GameObject[] goarray2)
    {

        var list1 = goarray1.ToList();
        var list2 = goarray2.ToList();
        
        list2.Shuffle();

        foreach (var var2 in list2)
        {
            if (goarray1.Any(_ => ReferenceEquals(_, null)))
            {
                var temp = list1.IndexOf(null);
                if (temp != -1)
                {
                    list1[temp] = var2;
                }
                else
                {
                    break;
                }
            }
        }


        for (int i = 0; i < goarray1.Length; i++)
        {
            goarray1[i] = list1[i];
        }
    }
    

    private void Start()
    {
        var array1 = new[] {gameObject, gameObject, null, null, null, null, null};
        var array2 = new[] {Go1, Go2, Go3, Go4, Go5, Go6};
        MethodForTwoArrays(array1, array2);
        //foreach (var g in array1) print(g);
    }
}