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
        Console.WriteLine($"{"Frequency",20} | {"Count",10}\n");
        foreach (string key in dist)
        {
            Console.WriteLine($"{key,20} | {map.GetValue(key),10}");
        }
        break;
}
