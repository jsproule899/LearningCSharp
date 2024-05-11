// See https://aka.ms/new-console-template for more information

// 2D array of strings with hidden message
String[][] message = { 
new string[] { "Buzz", "LightYear" ,"was"},
new string[] {"once", "apon", "a"}, 
new string[]{ "time","probably" ,"the "},
new string[]{ "coolest", "character", "in", "Toy", "Story 2"},
new string[]{ "but ", "Woody "},
new string[]{ "was ", "always ", "Andy's " , "wow"},
new string[]{ "toy.", "i"},
new string[]{ "was", "never", "keen" },
new string[]{ "because ", "I ", "don't "}, 
new string[]{ "rate","Tom","Hanks.", "Woody ", "is","quite","dour"},
new string[]{ "but"," Lightyear,", "could fly, sort of...", "Anyhow"},
new string[]{ "the","movies","are", "classic"}
};

foreach(string[] sentence in message){
    foreach(string word in sentence){
        if(word==sentence.Last())
        Console.Write(word.Last().ToString().ToUpper());
    }
}

