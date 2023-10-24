//string city = "Ankara";
////Console.WriteLine(city[0]);
////Console.ReadLine();

//foreach (var item in city)
//{
//    Console.WriteLine(item);
//}

//string city2 = "İstanbul";
//string result = city + city2;
//Console.WriteLine(String.Format("{0} {1}",city,city2));



string sentence = "My name is Atilla Güngör";
var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Arda Güngör";
var result3 = sentence.EndsWith("ğ");
var result4 = sentence.StartsWith("My name");
var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3,4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ","-");
var result13 = sentence.Remove(2,5);
Console.WriteLine(result13);
Console.ReadLine();