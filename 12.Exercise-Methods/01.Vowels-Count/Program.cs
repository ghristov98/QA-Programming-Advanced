
string text = Console.ReadLine();
int countVowels = GetVowelsCount(text);
Console.WriteLine(countVowels);
    static  int GetVowelsCount(string text)
    {
        int count = 0; // броя на гласните букви
        // обхождаме всеки един символ в текста
        for (int position = 0; position <= text.Length - 1; position++) 
        {
            char  currentSymbol = text[position];
            // проверка дали символа е гласна буква
            if (currentSymbol == 'A' || currentSymbol == 'a'
                || currentSymbol == 'E' || currentSymbol == 'e'
                || currentSymbol == 'O' || currentSymbol == 'o'
                || currentSymbol == 'I' || currentSymbol == 'i'
                || currentSymbol == 'U' || currentSymbol == 'u')
            {
                count ++; // увеличаваме броя на гласните букви с 1
            }
;
        }
        // знаем броя на гласните букви -> count
        return count;
}