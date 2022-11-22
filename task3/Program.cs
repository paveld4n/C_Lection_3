// Дан текст, в котором надо все пробелы заменить на "|"

string text = "Он говорил на том изысканном французском языке,"
 + "на котором не только говорили, но и думали наши деды, и с теми "
 + "тихими, покровительственными интонациями, которые свойственны"
 + "состаревшемуся в свете и при дворе значительному человеку.";

 //  string s = "qwerty"
 // s[3] это буква r

 string Replace(string text, char oldValue, char newValue)
 {
    string result = String.Empty; // инициализация строковой переменной result
    int length = text.Length; // показывает количество символов в стоке
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
 }

string newText = Replace(text, 'о', 'ы'); // кавычки ординарные, в них без лишних пробелов
Console.WriteLine(newText);