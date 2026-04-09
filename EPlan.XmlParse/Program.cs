using System.Xml.Linq;

XDocument xdoc = XDocument.Load("XMLFile1.xml");

string result = xdoc.Descendants("trans-unit")
    .Where(x => x.Attribute("id").Value == "42014")
    .First()
    .Element("target").Value;


//Just to double check the reuslt
//Console.WriteLine(result); 

File.WriteAllText("result.txt", result);