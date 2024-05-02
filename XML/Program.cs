using System.Reflection.PortableExecutable;
using System.Xml;
using XML;


String URLString = "https://www.w3schools.com/xml/cd_catalog.xml";
XmlTextReader Reader = new XmlTextReader(URLString);

while (Reader.Read())
{
    switch (Reader.NodeType)
    {
        case XmlNodeType.Element: // The node is an element.
            Console.Write("<" + Reader.Name);

            while (Reader.MoveToNextAttribute()) // Read the attributes.
                Console.Write(" " + Reader.Name + "='" + Reader.Value + "'");
            Console.WriteLine(">");
            break;
        case XmlNodeType.Text: //Display the text in each element.
            Console.WriteLine(Reader.Value);
            break;
        case XmlNodeType.EndElement: //Display the end of the element.
            Console.Write("</" + Reader.Name);
            Console.WriteLine(">");
            break;
    }
}



//Guardar cada elemento en un arreglo y luego imprimirlo en un nuevo fila o columna