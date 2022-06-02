Console.WriteLine("1.UC 1\n2.UC 2\n3.Remove word\nEnter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        HashTable.MyMapNode<int, string> hash = new HashTable.MyMapNode<int, string>(5);
        hash.add(0, "to");
        hash.add(1, "be");
        hash.add(2, "or");
        hash.add(3, "not");
        hash.add(4, "to");
        hash.add(5, "be");
        hash.getFrequency("to");
        hash.getFrequency("be");
        hash.getFrequency("or");
        hash.getFrequency("not");
        break;
    case 2:
        string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        string[] words = phrase.ToLower().Split(" ");
        var dist = words.Distinct();
        int length = 0;
        foreach (var word in dist)
            length++;
        HashTable.MyMapNode<string, int> map = new HashTable.MyMapNode<string, int>(length);
        int count = 1;
        foreach (string word in words)
        {
            if (map.ContainsKey(word))
            {
                count = map.GetValue(word) + 1;
                map.Remove(word);
                map.add(word, count);
            }
            else
            {
                map.add(word, 1);
            }
        }
        Console.WriteLine("Frequency-->Count");
        foreach (string key in dist)
        {
            Console.WriteLine(key + "-->" + map.GetValue(key));
        }
        break;
    case 3:
        string phrase1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        string[] words1 = phrase1.ToLower().Split(" ");
        var dist1 = words1.Distinct();
        int length1 = 0;
        foreach (var word in dist1)
            length1++;
        HashTable.MyMapNode<string, int> map1 = new HashTable.MyMapNode<string, int>(length1);
        int count1 = 1;
        foreach (string word in words1)
        {
            if (word == "avoidable")
            {
                continue;
            }
            else if (map1.ContainsKey(word))
            {
                count = map1.GetValue(word) + 1;
                map1.Remove(word);
                map1.add(word, count);
            }
            else
            {
                map1.add(word, 1);
            }
        }
        Console.WriteLine("Frequency-->Count");
        foreach (string key in dist1)
        {
            Console.WriteLine(key +"-->"+ map1.GetValue(key));
        }
        break;

}
