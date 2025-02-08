using System.Xml;

namespace ComputerInfo.LibSvc
{
    internal static class XmlHelper
    {
        public static XmlDocument MergeXmlDocuments(params XmlDocument[] xmlDocuments)
        {
            XmlDocument mergedDoc = new XmlDocument();
            XmlElement root = mergedDoc.CreateElement("ComputerInfo");
            mergedDoc.AppendChild(root);

            foreach (XmlDocument doc in xmlDocuments)
            {
                XmlNode importedNode = mergedDoc.ImportNode(doc.DocumentElement, true);
                root.AppendChild(importedNode);
            }

            return mergedDoc;
        }
    }
}
