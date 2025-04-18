using System;
using System.Collections.Generic;

public class RandomizedSet
{
    private Dictionary<int, int> dict;
    private List<int> list;
    private Random rand;

    public RandomizedSet()
    {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        rand = new Random();
    }

    public bool Insert(int val)
    {
        if (dict.ContainsKey(val))
        {
            return false;
        }

        list.Add(val);
        dict[val] = list.Count - 1;
        return true;
    }

    public bool Remove(int val)
    {
        if (!dict.ContainsKey(val))
        {
            return false;
        }

        int index = dict[val];
        int lastVal = list[list.Count - 1];

        list[index] = lastVal;
        dict[lastVal] = index;

        list.RemoveAt(list.Count - 1);
        dict.Remove(val);

        return true;
    }

    public int GetRandom()
    {
        int randomIndex = rand.Next(list.Count);
        return list[randomIndex];
    }
}
