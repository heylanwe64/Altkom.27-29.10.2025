namespace DesignPatterns.Structural.Facade.III
{
    internal class ConverterFacade : IJsonConverter, IXmlConverter, IByteArrayConverter
    {
        IJsonConverter jsonConverter;
        IXmlConverter xmlConverter;
        IByteArrayConverter byteArrayConverter;

        public ConverterFacade(IJsonConverter jsonConverter, IXmlConverter xmlConverter, IByteArrayConverter byteArrayConverter)
        {
            this.jsonConverter = jsonConverter;
            this.xmlConverter = xmlConverter;
            this.byteArrayConverter = byteArrayConverter;
        }


        public string ToJson<T>(T obj)
        {
            return jsonConverter.ToJson(obj);
        }
        public string ToXml<T>(T obj)
        {
            return xmlConverter.ToXml(obj);
        }
        public byte[] ToByteArray<T>(T obj)
        {
            return byteArrayConverter.ToByteArray(obj);
        }
    }
}
